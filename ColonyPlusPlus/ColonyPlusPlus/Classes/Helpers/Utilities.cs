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
    }
}
