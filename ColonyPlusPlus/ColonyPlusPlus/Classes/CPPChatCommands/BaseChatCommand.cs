using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz.Chatting;
using ChatCommands;

namespace ColonyPlusPlus.Classes.CPPChatCommands
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
            string[] splits = chatItem.Split(' ');
            if (isMasterCommand)
            {
                if (splits.Length <= 1)
                {
                    return false;
                }
                BaseChatCommand newCommand;
                if (Managers.ChatCommandManager.ChatCommandsList.TryGetValue(splits[0] + " " + splits[1], out newCommand))
                    return newCommand.TryDoCommand(ply, chatItem);
                else
                {
                    Chat.Send(ply, "Command " + splits[1] + " is not a part of " + splits[0]);
                    return true;
                }
            }
            int cuts = ChatCommandPrefix.Split(' ').Length;
            string[] cutsplits = new string[splits.Length - cuts];
            for (int i = 0; i < cutsplits.Length; i++)
            {
                cutsplits[i] = splits[i + cuts];
            }
            if (isTargetingCommand)
            {
                string[] newsplits = splits;
                if (cutsplits.Length == 0)
                {
                    Chat.Send(ply, "This command requires a target.");
                    return true;
                }
                NetworkID target = GetSubject(cutsplits, out newsplits);
                
                if (target == NetworkID.Invalid)
                {
                    Chat.Send(ply, "Player " + cutsplits[0] + " not found.");
                    return true;
                }
                return RunCommand(ply, newsplits, target);
            }
            return RunCommand(ply, cutsplits, NetworkID.Invalid);
        }

        protected abstract bool RunCommand(Players.Player id, string[] args, NetworkID target);

        private static NetworkID GetSubject(string[] argsBefore, out string[] argsAfter)
        {
            argsAfter = argsBefore;
            if (argsBefore.Length < 1)
            {
                return NetworkID.Invalid;
            }
            Players.Player player;
            int spacer = 0;
            if (argsBefore[0].StartsWith("\"") && !(argsBefore[1].EndsWith("\"")))
            {
                string total = argsBefore[0];
                while (!(argsBefore[1 + spacer].EndsWith("\"")))
                {
                    total += " " + argsBefore[1 + spacer];
                    spacer++;
                    if (spacer + 1 >= argsBefore.Length)
                    {
                        return NetworkID.Invalid;
                    }
                }
                total += " " + argsBefore[1 + spacer];
                spacer++;
                argsAfter[0] = total;
            }
            argsAfter[0] = argsAfter[0].Trim('"');
            if (Players.TryMatchName(argsAfter[0], out player))
            {
                string name = argsAfter[0];
                argsAfter = new string[argsAfter.Length - spacer];
                argsAfter[0] = name;
                for (int i = 1 + spacer; i < argsBefore.Length; i++)
                {
                    argsAfter[i - spacer] = argsBefore[i];
                }
                return player.ID;
            }
            return NetworkID.Invalid;
        }
    }
}
