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
            types.Blocks.LogCubeTagiaRotatedX logcubetaigarotatedx = new types.Blocks.LogCubeTaigaRotatedX("logcubetaigarotatedx");
            types.Blocks.LogCubeTaigaRotatedZ logcubetaigarotatedz = new types.Blocks.LogCubeTtaigaRotatedZ("logcubetaigarotatedz");



            // Decorative blocks

            // clay block orientations
            DecorativeTypeManager.TypeOption[] clayblocktypes = new DecorativeTypeManager.TypeOption[] { DecorativeTypeManager.TypeOption.Block, DecorativeTypeManager.TypeOption.Curve, DecorativeTypeManager.TypeOption.CurveRotated, DecorativeTypeManager.TypeOption.CurveCorner, DecorativeTypeManager.TypeOption.Slope, DecorativeTypeManager.TypeOption.SlopeCorner };

            classes.Managers.DecorativeTypeManager clayblock = new DecorativeTypeManager("clayblock", "clayblock", "clay", "crafting", clayblocktypes);
            //types.Blocks.Decorative.ClayBlock clayblock = new types.Blocks.Decorative.ClayBlock("clayblock");
            classes.Managers.DecorativeTypeManager clayblockblack = new DecorativeTypeManager("clayblockblack", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockblue = new DecorativeTypeManager("clayblockblue", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockbrown = new DecorativeTypeManager("clayblockbrown", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockcyan = new DecorativeTypeManager("clayblockcyan", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockgray = new DecorativeTypeManager("clayblockgray", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockgreen = new DecorativeTypeManager("clayblockgreen", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblocklightblue = new DecorativeTypeManager("clayblocklightblue", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblocklime = new DecorativeTypeManager("clayblocklime", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockmagenta = new DecorativeTypeManager("clayblockmagenta", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockorange = new DecorativeTypeManager("clayblockorange", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockpink = new DecorativeTypeManager("clayblockpink", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockpurple = new DecorativeTypeManager("clayblockpurple", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockred = new DecorativeTypeManager("clayblockred", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblocksilver = new DecorativeTypeManager("clayblocksilver", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockwhite = new DecorativeTypeManager("clayblockwhite", "clayblock", "clay", "crafting", clayblocktypes);
            classes.Managers.DecorativeTypeManager clayblockyellow = new DecorativeTypeManager("clayblockyellow", "clayblock", "clay", "crafting", clayblocktypes);


        }
    }
}
