using ChatCommands;
using NPC;
using Permissions;
using ColonyPlusPlus.Classes.Helpers;
using System;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{

    public class Debug : BaseChatCommand
    {
        public Debug() : base("/cppdebug")
        {

        }

        override protected bool RunCommand(Players.Player player, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(player, "debug") && Classes.Managers.ConfigManager.getConfigBoolean("debug.enabled"))
            {
                if (args.Length > 0)
                {
                    string commandType = args[0];

                    switch (commandType)
                    {
                        case "output_types":
                            Pipliz.JSON.JSONNode node = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

                            foreach (string typename in Managers.TypeManager.AddedTypes)
                            {
                                Pipliz.JSON.JSONNode itemJson = ItemTypes.GetTypesJSON.GetAs<Pipliz.JSON.JSONNode>(typename);
                                node.SetAs<Pipliz.JSON.JSONNode>(typename, itemJson);
                            }

                            Pipliz.JSON.JSON.Serialize(GetJSONPath("types"), node);
                            Chat.send(player, "Debug Command" + commandType, Chat.ChatColour.yellow);
                            return true;

                        default:
                            Chat.send(player, "Invalid Debug Command", Chat.ChatColour.yellow);
                            return false;

                    }
                }
                else
                {
                    Chat.send(player, "Invalid Debug Command", Chat.ChatColour.yellow);
                    Chat.send(player, "Usage: /debug {command} {arguments...}", Chat.ChatColour.yellow);
                    return false;
                }

            

            } else
            {
                Chat.send(player, "You are unable to use debug commands", Chat.ChatColour.yellow);
                return false;
            }
           
        }

        private static string GetJSONPath(string type)
        {
            return "gamedata/debug/" + type + ".json";
        }
    }
}

