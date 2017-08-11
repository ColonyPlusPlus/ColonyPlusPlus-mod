﻿using General.Networking;
using Pipliz;
using Pipliz.Chatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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

        public static void sendSilent(Players.Player player, string message, ChatColour colour = ChatColour.white, ChatStyle style = ChatStyle.normal, Pipliz.Chatting.ChatSenderType sender = Pipliz.Chatting.ChatSenderType.Server)
        {
            ChatSenderType type = ChatSenderType.Server;

            if (!(player.ID == NetworkID.Server))
            {
                string messageBuilt = buildMessage(message, colour, style);

                using (ByteBuilder byteBuilder = ByteBuilder.Get())
                {
                    byteBuilder.Write((ushort)ClientMessageType.Chat);
                    byteBuilder.Write((byte)type);
                    byteBuilder.Write(messageBuilt);
                    NetworkWrapper.Send(byteBuilder.ToArray(), player, NetworkMessageReliability.ReliableWithBuffering);
                }
            }
            //send(player, message, colour, style, sender);
        }

        public static void sendAllSilent(string message, ChatColour colour = ChatColour.white, ChatStyle style = ChatStyle.normal, Pipliz.Chatting.ChatSenderType sender = Pipliz.Chatting.ChatSenderType.Server)
        {
            ChatSenderType type = ChatSenderType.Server;
            string messageBuilt = buildMessage(message, colour, style);


            using (ByteBuilder byteBuilder = ByteBuilder.Get())
            {
                byteBuilder.Write((ushort)ClientMessageType.Chat);
                byteBuilder.Write((byte)type);
                byteBuilder.Write(messageBuilt);
                Players.SendToAll(byteBuilder.ToArray(), NetworkMessageReliability.ReliableWithBuffering);
            }

            //sendToAll(message, colour, style, sender);
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

        /// <summary>
        /// Splits chat into individual parameters, quoted text becomes 1 parameter
        /// </summary>
        /// <param name="chat"></param>
        /// <param name="prefix"></param>
        /// <returns>command parameter array</returns>
        public static string[] ParseChatCommand(this string chat, string prefix)
        {
            if (!chat.Contains(" "))
                return new string[0];
            
            chat = chat.Remove(0, prefix.Length);

            return Regex.Split(chat, "(?<=^[^\"]*(?:\"[^\"]*\"[^\"]*)*) (?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
        }
    }
}
