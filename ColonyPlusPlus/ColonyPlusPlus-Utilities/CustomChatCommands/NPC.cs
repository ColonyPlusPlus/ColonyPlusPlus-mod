using Permissions;
using System;

namespace ColonyPlusPlusUtilities.CustomChatCommands
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
                            ColonyAPI.Helpers.Chat.sendSilent(player, "NPC Info for: " + npcD.name + " (ID: " + npcID + ")", ColonyAPI.Helpers.Chat.ChatColour.cyan);
                            ColonyAPI.Helpers.Chat.sendSilent(player, "Levels:", ColonyAPI.Helpers.Chat.ChatColour.cyan);
                            foreach (string job in npcD.XPData.XPLevels.Keys)
                            {
                                ColonyAPI.Helpers.Chat.sendSilent(player, String.Format("{0}: {1} ({2}/{3} XP)",job, npcD.XPData.XPLevels[job], npcD.XPData.getRawXP(job), npcD.XPData.getXPForNextLevel(npcD.XPData.XPLevels[job])), ColonyAPI.Helpers.Chat.ChatColour.cyan);
                            }
                        }
                        
                    }

                } else
                {
                    ColonyAPI.Helpers.Chat.sendSilent(player, "Invalid arguments. Usage:", ColonyAPI.Helpers.Chat.ChatColour.orange);
                    ColonyAPI.Helpers.Chat.sendSilent(player, "/npc info <id> - get info on an NPC of ID 'id'", ColonyAPI.Helpers.Chat.ChatColour.orange);
                }
                return true;


            }
            else
            {
                ColonyAPI.Helpers.Chat.sendSilent(player, "You are unable to use NPC commands", ColonyAPI.Helpers.Chat.ChatColour.yellow);
                return false;
            }

        }
    }
}

