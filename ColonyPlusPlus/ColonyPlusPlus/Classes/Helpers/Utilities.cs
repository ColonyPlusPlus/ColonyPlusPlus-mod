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

        public static bool ValidateIcon(string exists)
        {
            return File.Exists(Directory.GetCurrentDirectory()  + "/gamedata/textures/icons/" + exists + ".png");
        }

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
