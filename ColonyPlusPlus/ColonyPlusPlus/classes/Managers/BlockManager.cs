using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes.Managers
{
    class BlockManager
    {
        // Register all blocks
        public static void register()
        {
            // Tell the player what we're doing here
            classes.Utilities.WriteLog("Starting To Register Blocks");

            // And register!
            types.blocks.WildBerryBush wildBerryBush                = new types.blocks.WildBerryBush("wildberrybush");
            types.blocks.Sugarcane sugarcane                        = new types.blocks.Sugarcane("sugarcane");
            types.blocks.VegetablePatch vegetablepatch              = new types.blocks.VegetablePatch("vegetablepatch");
        }
    }
}
