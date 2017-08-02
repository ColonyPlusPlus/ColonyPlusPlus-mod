using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Helpers
{

    

    public static class Chat
    {
        public enum ChatColour
        {
            black,
            blue,
            brown,
            cyan,
            darkblue,
            green,
            grey,
            lightblue,
            lime,
            magenta,
            maroon,
            navy,
            olive,
            orange,
            purple,
            red,
            silver,
            teal,
            white,
            yellow
        }

        public enum ChatStyle
        {
            normal,
            bold,
            italic,
            bolditalic
        }

        public static void send(Players.Player ply, string message, ChatColour colour = ChatColour.white, ChatStyle style = ChatStyle.normal, Pipliz.Chatting.ChatSenderType sender = Pipliz.Chatting.ChatSenderType.Server)
        {
            string messageBuilt = buildMessage(message, colour, style);
            Pipliz.Chatting.Chat.Send(ply, messageBuilt, sender);
        }

        public static void sendToAll(string message, ChatColour colour = ChatColour.white, ChatStyle style = ChatStyle.normal, Pipliz.Chatting.ChatSenderType sender = Pipliz.Chatting.ChatSenderType.Server)
        {
            string messageBuilt = buildMessage(message, colour, style);
            Pipliz.Chatting.Chat.SendToAll(messageBuilt, sender);
        }

        public static void sendToAllBut(Players.Player ply, string message, ChatColour colour = ChatColour.white, ChatStyle style = ChatStyle.normal, Pipliz.Chatting.ChatSenderType sender = Pipliz.Chatting.ChatSenderType.Server)
        {
            string messageBuilt = buildMessage(message, colour, style);
            Pipliz.Chatting.Chat.SendToAllBut(ply, messageBuilt, sender);
        }

        public static string buildMessage(string message, ChatColour colour = ChatColour.white, ChatStyle style = ChatStyle.normal)
        {
            string colorPrefix = "<color=" + colour.ToString() + ">";
            string colorSuffix = "</color>";
            string stylePrefix, styleSuffix;

            switch (style)
            {

                case ChatStyle.bold:
                    stylePrefix = "<b>";
                    styleSuffix = "</b>";
                    break;
                case ChatStyle.bolditalic:
                    stylePrefix = "<b><i>";
                    styleSuffix = "</i></b>";
                    break;
                case ChatStyle.italic:
                    stylePrefix = "<i>";
                    styleSuffix = "</i>";
                    break;
                default:
                    stylePrefix = "";
                    styleSuffix = "";
                    break;
            }

            return stylePrefix + colorPrefix + message + colorSuffix + styleSuffix;
        }
    }
}
