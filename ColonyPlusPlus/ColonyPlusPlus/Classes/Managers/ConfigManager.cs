using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz.JSON;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class ConfigManager
    {

        private static JSONNode configSettings;


        public static string getConfigString(string identifier)
        {
            try
            {
                string ret;
                configSettings.TryGetAs<string>(identifier, out ret);
                return ret;
            }
            catch (Exception exception)
            {
                Utilities.WriteLog("Error getting configuration (" + identifier + "):" + exception.Message);
                return "";
            }

        }

        public static bool getConfigBoolean(string identifier)
        {
            try
            {
                bool ret;
                configSettings.TryGetAs<bool>(identifier, out ret);
                return ret;
            }
            catch (Exception exception)
            {
                Utilities.WriteLog("Error getting configuration (" + identifier + "):" + exception.Message);
                return false;
            }

        }

        public static int getConfigInt(string identifier)
        {
            try
            {
                int ret;
                configSettings.TryGetAs<int>(identifier, out ret);
                return ret;
            }
            catch (Exception exception)
            {
                Utilities.WriteLog("Error getting configuration (" + identifier + "):" + exception.Message);
                return -1;
            }

        }

        public static float getConfigFloat(string identifier)
        {
            try
            {
                float ret;
                configSettings.TryGetAs<float>(identifier, out ret);
                return ret;
            }
            catch (Exception exception)
            {
                Utilities.WriteLog("Error getting configuration (" + identifier + "):" + exception.Message);
                return 0.0f;
            }

        }

        public static JSONNode getConfigNode(string identifier)
        {
            try
            {
                JSONNode ret;
                configSettings.TryGetAs<JSONNode>(identifier, out ret);
                return ret;
            }
            catch (Exception exception)
            {
                Utilities.WriteLog("Error getting configuration (" + identifier + "):" + exception.Message);
                return new JSONNode(NodeType.Array);
            }

        }

        /// <summary>
        /// Initialise the config manager
        /// </summary>
        public static void initialise()
        {
            try
            {
                Pipliz.JSON.JSON.Deserialize(getConfigLocation(), out configSettings, true);
            }
            catch (Exception exception2)
            {
                Utilities.WriteLog("Error loading configuration:" + exception2.Message);
            }
        }

        /// <summary>
        /// Get the config location
        /// </summary>
        /// <returns></returns>
        private static string getConfigLocation()
        {
            return "gamedata/mods/ColonyPlusPlus/config.json";
        }
    }
}
