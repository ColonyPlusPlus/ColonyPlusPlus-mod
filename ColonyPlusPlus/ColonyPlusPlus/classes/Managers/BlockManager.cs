using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes.Managers
{
    class BlockManager
    {
        public static void registerTypes()
        {
            classes.Utilities.WriteLog("Starting To Register Blocks");

            types.blocks.WildBerryBush wildBerryBush                = new types.blocks.WildBerryBush("wildberrybush");
            types.blocks.Sugarcane sugarcane                        = new types.blocks.Sugarcane("sugarcane");
            types.blocks.VegetablePatch vegetablepatch              = new types.blocks.VegetablePatch("vegetablepatch");
        }
    }
}
