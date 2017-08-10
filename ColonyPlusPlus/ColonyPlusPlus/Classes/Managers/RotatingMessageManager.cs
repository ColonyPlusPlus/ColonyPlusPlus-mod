using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Helpers;
using Pipliz.JSON;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class RotatingMessageManager
    {
        private static Chat.ChatColour rotatorColor = Chat.ChatColour.white;
        private static Chat.ChatStyle rotatorStyle = Chat.ChatStyle.normal;
        public static bool rotatorEnabled = false;
        private static int rotatorSecondsBetween = 60;
        public static List<string> rotatorMessages = new List<string>();
        private static int messageIndex = 0;
        private static long nextUpdateTime = 0;

        public static void initialise()
        {
            string rotatorColorConf = ConfigManager.getConfigString("rotatingmessages.color");
            if (Enum.IsDefined(typeof(Chat.ChatColour), rotatorColorConf))
            {
                rotatorColor = (Chat.ChatColour)Enum.Parse(typeof(Chat.ChatColour), rotatorColorConf);
            }

            string rotatorStyleConf = ConfigManager.getConfigString("rotatingmessages.style");
            if (Enum.IsDefined(typeof(Chat.ChatStyle), rotatorStyleConf))
            {
                rotatorStyle = (Chat.ChatStyle)Enum.Parse(typeof(Chat.ChatStyle), rotatorStyleConf);
            }

            rotatorEnabled = ConfigManager.getConfigBoolean("rotatingmessages.enabled");

            rotatorSecondsBetween = ConfigManager.getConfigInt("rotatingmessages.interval");

            JSONNode rotatorMessagesConf = ConfigManager.getConfigNode("rotatingmessages.list");

            foreach (JSONNode message in rotatorMessagesConf.LoopArray())
            {
                rotatorMessages.Add(message.GetAs<string>());
            }

            nextUpdateTime = nextUpdate();

            Utilities.WriteLog(String.Format("Rotator is enabled ({0}) with {1} messages playing every {2} seconds. Next update: {3}", rotatorEnabled.ToString(), rotatorMessages.Count, rotatorSecondsBetween, nextUpdateTime));
        }

        public static long nextUpdate()
        {
            return (long)(rotatorSecondsBetween * 1000 + Pipliz.Time.MillisecondsSinceStart);
        }

        public static void doRotate()
        {
            Chat.sendToAll(rotatorMessages[messageIndex], rotatorColor, rotatorStyle);

            if (messageIndex < rotatorMessages.Count - 1)
            {
                messageIndex += 1;
            } else
            {
                messageIndex = 0;
            }

            nextUpdateTime = nextUpdate();
        }

        public static void doRun() {

            if((Pipliz.Time.MillisecondsSinceStart > nextUpdateTime) && (rotatorEnabled == true))
            {
                doRotate();
            }
        }
    }
}
