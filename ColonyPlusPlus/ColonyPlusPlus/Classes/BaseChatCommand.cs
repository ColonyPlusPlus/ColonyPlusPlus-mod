using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz.Chatting;
using ChatCommands;

namespace ColonyPlusPlus.Classes
{
    public abstract class BaseChatCommand
    {
        public string ChatCommandPrefix;
        protected bool isTargetingCommand;
        protected bool isMasterCommand;

        public BaseChatCommand(string prefix, bool istargetcom = false, bool ismastercom = false)
        {
            ChatCommandPrefix = prefix;
            isTargetingCommand = istargetcom;
            isMasterCommand = ismastercom;
        }

        public bool TryDoCommand(Players.Player ply, string chatItem)
        {
            var commandParameters = Helpers.Chat.ParseChatCommand(chatItem, ChatCommandPrefix);

            if (isMasterCommand)
            {
                if (commandParameters.Length == 0)
                    return false;

                BaseChatCommand newCommand;
                if (Managers.ChatCommandManager.ChatCommandsList.TryGetValue(ChatCommandPrefix + " " + commandParameters[0], out newCommand))
                    return newCommand.TryDoCommand(ply, chatItem);

                Chat.Send(ply, $"Command {commandParameters[0]} is not a part of {ChatCommandPrefix}");
                return true;
            }

            if (isTargetingCommand)
            {

                if (commandParameters.Length == 0)
                {
                    Chat.Send(ply, "This command requires a target.");
                    return true;
                }
                var targets = new List<NetworkID>();
                commandParameters.ToList().ForEach(x =>
                {
                    Players.Player targetPlayer;
                    if (!String.IsNullOrEmpty(x) && Players.TryMatchName(x, out targetPlayer))
                        targets.Add(targetPlayer.ID);
                });

                if (targets.Count == 0)
                {
                    Chat.Send(ply, $"Player {commandParameters[0]} not found");
                    return true;
                }
                return RunCommand(ply, commandParameters, targets.ToArray());
            }
            return RunCommand(ply, commandParameters, new NetworkID[0]);
        }

        protected abstract bool RunCommand(Players.Player id, string[] args, NetworkID[] targets);

        
    }
}
