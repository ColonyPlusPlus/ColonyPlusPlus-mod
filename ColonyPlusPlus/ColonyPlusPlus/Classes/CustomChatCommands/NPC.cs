using ChatCommands;
using NPC;
using Permissions;
using ColonyPlusPlus.Classes.Helpers;
using System;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{

    public class NPC : BaseChatCommand
    {
        public NPC() : base("/npc", false, true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            return false;
        }




    }

    public class NPCInfo : BaseChatCommand
    {
        public NPCInfo() : base("/npc info")
        {

        }

        override protected bool RunCommand(Players.Player player, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(player, "npc.info"))
            {
                if (args.Length == 1)
                {
                    int npcID = 0;
                    int.TryParse(args[0], out npcID);

                    if(Managers.NPCManager.npcExists(npcID))
                    {
                        Data.NPCData npcD = Managers.NPCManager.getNPCData(npcID, player);

                        if(npcD.owner == player || PermissionsManager.HasPermission(player, "npc.admin"))
                        {
                            // is their NPC or is admin
                            Helpers.Chat.sendSilent(player, "NPC Info for: " + npcD.name + " (ID: " + npcID + ")", Helpers.Chat.ChatColour.cyan);
                            Helpers.Chat.sendSilent(player, "Levels:", Helpers.Chat.ChatColour.cyan);
                            foreach (string job in npcD.XPData.XPLevels.Keys)
                            {
                                Helpers.Chat.sendSilent(player, String.Format("{0}: {1} ({2}/{3} XP)",job, npcD.XPData.XPLevels[job], npcD.XPData.getRawXP(job), npcD.XPData.getXPForNextLevel(npcD.XPData.XPLevels[job])), Helpers.Chat.ChatColour.cyan);
                            }
                        }
                        
                    }

                } else
                {
                    Helpers.Chat.sendSilent(player, "Invalid arguments. Usage:", Helpers.Chat.ChatColour.orange);
                    Helpers.Chat.sendSilent(player, "/npc info <id> - get info on an NPC of ID 'id'", Helpers.Chat.ChatColour.orange);
                }
                return true;


            }
            else
            {
                Chat.sendSilent(player, "You are unable to use NPC commands", Chat.ChatColour.yellow);
                return false;
            }

        }
    }
}

