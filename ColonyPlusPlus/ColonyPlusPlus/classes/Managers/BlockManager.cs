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
            types.blocks.WildBerryBush wildBerryBush                    = new types.blocks.WildBerryBush("wildberrybush");
            types.blocks.Sugarcane sugarcane                            = new types.blocks.Sugarcane("sugarcane");
            types.blocks.VegetablePatch vegetablepatch                  = new types.blocks.VegetablePatch("vegetablepatch");

            // Decorative blocks
            classes.Managers.DecorativeTypeManager clayblock = new DecorativeTypeManager("clayblock", "clayblock", "clay", "crafting", new DecorativeTypeManager.TypeOption[] { DecorativeTypeManager.TypeOption.Block, DecorativeTypeManager.TypeOption.Curve, DecorativeTypeManager.TypeOption.CurveRotated, DecorativeTypeManager.TypeOption.CurveCorner, DecorativeTypeManager.TypeOption.Slope });
            //types.Blocks.Decorative.ClayBlock clayblock = new types.Blocks.Decorative.ClayBlock("clayblock");
            types.Blocks.Decorative.ClayBlock clayblockblack = new types.Blocks.Decorative.ClayBlock("clayblockblack");
            types.Blocks.Decorative.ClayBlock clayblockblue = new types.Blocks.Decorative.ClayBlock("clayblockblue");
            types.Blocks.Decorative.ClayBlock clayblockbrown = new types.Blocks.Decorative.ClayBlock("clayblockbrown");
            types.Blocks.Decorative.ClayBlock clayblockcyan = new types.Blocks.Decorative.ClayBlock("clayblockcyan");
            types.Blocks.Decorative.ClayBlock clayblockgray = new types.Blocks.Decorative.ClayBlock("clayblockgray");
            types.Blocks.Decorative.ClayBlock clayblockgreen = new types.Blocks.Decorative.ClayBlock("clayblockgreen");
            types.Blocks.Decorative.ClayBlock clayblocklightblue = new types.Blocks.Decorative.ClayBlock("clayblocklightblue");
            types.Blocks.Decorative.ClayBlock clayblocklime = new types.Blocks.Decorative.ClayBlock("clayblocklime");
            types.Blocks.Decorative.ClayBlock clayblockmagenta = new types.Blocks.Decorative.ClayBlock("clayblockmagenta");
            types.Blocks.Decorative.ClayBlock clayblockorange = new types.Blocks.Decorative.ClayBlock("clayblockorange");
            types.Blocks.Decorative.ClayBlock clayblockpink = new types.Blocks.Decorative.ClayBlock("clayblockpink");
            types.Blocks.Decorative.ClayBlock clayblockpurple = new types.Blocks.Decorative.ClayBlock("clayblockpurple");
            types.Blocks.Decorative.ClayBlock clayblockred = new types.Blocks.Decorative.ClayBlock("clayblockred");
            types.Blocks.Decorative.ClayBlock clayblocksilver = new types.Blocks.Decorative.ClayBlock("clayblocksilver");
            types.Blocks.Decorative.ClayBlock clayblockwhite = new types.Blocks.Decorative.ClayBlock("clayblockwhite");
            types.Blocks.Decorative.ClayBlock clayblockyellow = new types.Blocks.Decorative.ClayBlock("clayblockyellow");

            
        }
    }
}
