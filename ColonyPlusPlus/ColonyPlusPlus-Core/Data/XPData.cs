using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Classes.Data
{
    public class XPData
    {
        public Dictionary<string, ushort> XPAmounts;
        public Dictionary<string, int> XPLevels;

        public XPData()
        {
            XPAmounts = new Dictionary<string, ushort>();
            XPLevels = new Dictionary<string, int>();
        }

        public void addXP(int npcID, string jobtype, Players.Player owner)
        {
            addXPAmount(npcID, jobtype, 1, owner);
        }

        public void addXPAmount(int npcID, string jobtype, ushort amount, Players.Player owner)
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
                    NPCData n = Managers.NPCManager.getNPCData(npcID, owner);
                    // the NPC has levelled up!
                    XPLevels[jobtype] += 1;
                    Helpers.Chat.sendSilent(owner, String.Format("{0} [{1}] has gained a level in {2} (Level: {3}, {4}% efficiency boost)", n.name, npcID, jobtype, XPLevels[jobtype], Math.Round((1 - getCraftingMultiplier(jobtype)) * 100,0)), Helpers.Chat.ChatColour.orange);
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

        public ushort getXPForNextLevel(int level)
        {
            int baseXP = Managers.NPCManager.baseXP;
            int maxLevel = Managers.NPCManager.maxLevel;
            float XPMultiplier = Managers.NPCManager.XPMultiplier;

            if(level + 1 > maxLevel)
            {
                level = level - 1;
            }
            ushort xp = (ushort)Math.Floor(baseXP * Math.Pow(XPMultiplier,(level + 1)));

            return xp;
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
