using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes
{
    public static class Utilities
    {
        // Write a log entry
        public static void WriteLog(string message)
        {
            Pipliz.Log.Write("[ColonyPlusPlus]: " + message);
        }

        public static void WriteLog(string message, Helpers.Chat.ChatColour color, Helpers.Chat.ChatStyle style)
        {
            Pipliz.Log.Write(Helpers.Chat.buildMessage("[ColonyPlusPlus]: " + message, color, style));
        }

        public static void WriteLogError(string message)
        {
            Pipliz.Log.Write("[ColonyPlusPlus]: " + message);
        }

        public static bool ValidateIcon(string exists)
        {
            return File.Exists(Directory.GetCurrentDirectory()  + "/gamedata/textures/icons/" + exists + ".png");
        }

        public static void MakeDirectoriesIfNeeded(string path)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
        }

        /// <summary>
        /// Finds the player that these arguments are trying to address.
        /// Be sure when you pass the arguments that you remove the command from them.
        /// IE. /trade send Dadadah 1 1 1 1 > the array will be
        /// ["/trade", "send", "Dadadah", "1", "1", "1", "1"]
        /// You need to cut off the command itself, so this example would change to
        /// ["Dadadah", "1", "1", "1", "1"]
        /// </summary>
        /// <param name="argsBefore">The array of strings that are the arguments.</param>
        /// <param name="argsAfter">The array of arguments after we have parsed the string.</param>
        /// <returns>The subject these arguments are targeting.</returns>
        public static NetworkID GetSubject(string[] argsBefore, out string[] argsAfter)
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
