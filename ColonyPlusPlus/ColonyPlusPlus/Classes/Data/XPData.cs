﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Data
{
    public class XPData
    {
        private Dictionary<string, ushort> XPAmounts;
        private Dictionary<string, int> XPLevels;

        public XPData()
        {
            XPAmounts = new Dictionary<string, ushort>();
            XPLevels = new Dictionary<string, int>();
        }

        public void addXP(string jobtype, Players.Player owner)
        {
            addXPAmount(jobtype, 1, owner);
        }

        public void addXPAmount(string jobtype, ushort amount, Players.Player owner)
        {
            if (XPAmounts.ContainsKey(jobtype))
            {
                XPAmounts[jobtype] += amount;
            }
            else
            {
                XPAmounts.Add(jobtype, amount);
            }

            if (XPLevels.ContainsKey(jobtype))
            {
                //Utilities.WriteLog("Level: " + XPLevels[jobtype] + "/" + getLevel(jobtype));
                if (getLevel(jobtype) > XPLevels[jobtype])
                {
                    // the NPC has levelled up!
                    XPLevels[jobtype] += 1;
                    Helpers.Chat.send(owner, String.Format("NPC [{0}] has levelled up! Now level {1} ({2} XP) ({3}% efficiency boost)", jobtype, XPLevels[jobtype], XPAmounts[jobtype], Math.Round((1 - getCraftingMultiplier(jobtype)) * 100,0)), Helpers.Chat.ChatColour.orange);
                }
            }
            else
            {
                //Utilities.WriteLog("Job type level: " + jobtype + " does not exist, adding...");
                XPLevels.Add(jobtype, 0);
            }

            //Utilities.WriteLog("Updated XP for NPC for job " + jobtype + " added " + amount + "XP to total " + XPAmounts[jobtype]);
        }

        public void setXP(string jobtype, ushort amount)
        {
            if (XPAmounts.ContainsKey(jobtype))
            {
                XPAmounts[jobtype] = amount;
            }
            else
            {
                XPAmounts.Add(jobtype, amount);
            }
        }

        public ushort getRawXP(string jobtype)
        {
            if(XPAmounts.ContainsKey(jobtype))
            {
                return XPAmounts[jobtype];
            } else
            {
                return 0;
            }
        }

        public int getLevel(string jobtype)
        {
            int level = 0;
            int baseXP = Managers.NPCManager.baseXP;
            int maxLevel = Managers.NPCManager.maxLevel;
            float XPMultiplier = Managers.NPCManager.XPMultiplier;

            if (XPAmounts.ContainsKey(jobtype))
            {
                ushort xp = XPAmounts[jobtype];

                if(xp > baseXP)
                {
                    double levelMultiplier = (double)xp / (double)baseXP;
                    double levelD = Math.Log(levelMultiplier, XPMultiplier);
                    int levelI = (int)Math.Floor(levelD);

                    level = levelI;
                    if (levelI > maxLevel)
                    {
                        level = maxLevel;
                    }
                    else if (levelI < 0)
                    {
                        level = 0;
                    }
                }
               

            }

            return level;
        }

        public float getCraftingMultiplier(string jobtype)
        {
            int level = getLevel(jobtype);

            // 2% bonus per level
            return (float)(1 - (level * Managers.NPCManager.EfficiencyPerLevel));
        }

        public void recalculateAllLevels(bool silent = true)
        {
            if(XPAmounts.Count > 0)
            {
                foreach (string job in XPAmounts.Keys)
                {
                    if(XPLevels.ContainsKey(job))
                    {
                        XPLevels[job] = getLevel(job);
                    } else
                    {
                        XPLevels.Add(job, getLevel(job));
                    }

                    if (silent == false)
                    {
                        Utilities.WriteLog("Updated NPC level in " + job + " to level " + getLevel(job));
                    }
                }

                
            }
            
        }

        public Pipliz.JSON.JSONNode toJSON()
        {
            Pipliz.JSON.JSONNode node = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

            if(XPAmounts.Count > 0)
            {
                foreach(string jobname in XPAmounts.Keys)
                {
                    node.SetAs(jobname, XPAmounts[jobname]);
                }
            }

            return node;
        }
    }
}