using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Managers
{
    class BaseGameManager
    {
        // Register all blocks
        public static void registerBlocks()
        {
            Classes.Utilities.WriteLog("Starting To Register Basegame Items");

            //Base Game Blocks!

            
           

            Classes.Utilities.WriteLog("Finished Registering Basegame Blocks");


        }

        public static void registerItems()
        {
            // Tell the player what we're doing
            Classes.Utilities.WriteLog("Starting To Register Basegame Items");


            Classes.Utilities.WriteLog("Finished Registering Basegame Items");
        }
    }
}
