using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
    public static class Utilities
    {
        // Write a log entry
        public static void WriteLog(string message)
        {
            Pipliz.Log.Write("[ColonyPlusPlus]: " + message);
        }
    }
}
