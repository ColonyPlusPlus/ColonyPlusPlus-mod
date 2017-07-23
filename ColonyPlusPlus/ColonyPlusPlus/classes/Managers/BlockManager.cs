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
            types.blocks.VegetablePatch vegetablepatch = new types.blocks.VegetablePatch("vegetablepatch");

            // logs
            types.Blocks.LogCube logcube = new types.Blocks.LogCube("logcube");
            types.Blocks.LogCubeTemperate logcubetemperate = new types.Blocks.LogCubeTemperate("logcubetemperate");
            types.Blocks.LogCubeTaiga logcubetaiga = new types.Blocks.LogCubeTaiga("logcubetaiga");
            types.Blocks.LogCubeRotated logcuberotated = new types.Blocks.LogCubeRotated("logcuberotated");
            types.Blocks.LogCubeTemperateRotated logcubetemperaterotated = new types.Blocks.LogCubeTemperateRotated("logcubetemperaterotated");
            types.Blocks.LogCubeTemperateRotatedX logcubetemperaterotatedx = new types.Blocks.LogCubeTemperateRotatedX("logcubetemperaterotatedx");
            types.Blocks.LogCubeTemperateRotatedZ logcubetemperaterotatedz = new types.Blocks.LogCubeTemperateRotatedZ("logcubetemperaterotatedz");
            types.Blocks.LogCubeTaigaRotated logcubetaigarotated = new types.Blocks.LogCubeTaigaRotated("logcubetaigarotated");
            types.Blocks.LogCubeTaigaRotatedX logcubetaigarotatedx = new types.Blocks.LogCubeTaigaRotatedX("logcubetaigarotatedx");
            types.Blocks.LogCubeTaigaRotatedZ logcubetaigarotatedz = new types.Blocks.LogCubeTaigaRotatedZ("logcubetaigarotatedz");

            // interactive items
            //types.blocks.ChickenCoop chickencoop = new types.blocks.ChickenCoop("chickencoop");

            // Decorative blocks

            // clay block orientations
            DecorativeTypeManager.TypeOption[] clayblocktypes = new DecorativeTypeManager.TypeOption[] { DecorativeTypeManager.TypeOption.Block, DecorativeTypeManager.TypeOption.Curve, DecorativeTypeManager.TypeOption.CurveRotated, DecorativeTypeManager.TypeOption.CurveCorner, DecorativeTypeManager.TypeOption.Slope, DecorativeTypeManager.TypeOption.SlopeCorner };

            classes.Managers.DecorativeTypeManager clayblock = new DecorativeTypeManager("clayblock", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockblack = new DecorativeTypeManager("clayblockblack", "clayblockblack", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockblue = new DecorativeTypeManager("clayblockblue", "clayblockblue", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockbrown = new DecorativeTypeManager("clayblockbrown", "clayblockbrown", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockcyan = new DecorativeTypeManager("clayblockcyan", "clayblockcyan", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockgray = new DecorativeTypeManager("clayblockgray", "clayblockgray", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockgreen = new DecorativeTypeManager("clayblockgreen", "clayblockgreen", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblocklightblue = new DecorativeTypeManager("clayblocklightblue", "clayblocklightblue", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblocklime = new DecorativeTypeManager("clayblocklime", "clayblocklime", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockmagenta = new DecorativeTypeManager("clayblockmagenta", "clayblockmagenta", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockorange = new DecorativeTypeManager("clayblockorange", "clayblockorange", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockpink = new DecorativeTypeManager("clayblockpink", "clayblockpink", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockpurple = new DecorativeTypeManager("clayblockpurple", "clayblockpurple", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockred = new DecorativeTypeManager("clayblockred", "clayblockred", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblocksilver = new DecorativeTypeManager("clayblocksilver", "clayblocksilver", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockwhite = new DecorativeTypeManager("clayblockwhite", "clayblockwhite", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockyellow = new DecorativeTypeManager("clayblockyellow", "clayblockyellow", "clay", "crafting", clayblocktypes);


        }
    }
}
