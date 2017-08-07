using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Managers
{
    class BlockManager
    {
        // Register all blocks
        public static void register()
        {
           

            // Tell the player what we're doing here
            Classes.Utilities.WriteLog("Starting To Register Blocks");

            // And register!
            Types.Blocks.WildBerryBush wildBerryBush                    = new Types.Blocks.WildBerryBush("wildberrybush");
            Types.Blocks.Sugarcane sugarcane                            = new Types.Blocks.Sugarcane("sugarcane");
            Types.Blocks.VegetablePatch vegetablepatch = new Types.Blocks.VegetablePatch("vegetablepatch");

            // logs
            Types.Blocks.LogCube logcube = new Types.Blocks.LogCube("logcube");
            Types.Blocks.LogCubeTemperate logcubetemperate = new Types.Blocks.LogCubeTemperate("logcubetemperate");
            Types.Blocks.LogCubeTaiga logcubetaiga = new Types.Blocks.LogCubeTaiga("logcubetaiga");
            Types.Blocks.LogCubeRotated logcuberotated = new Types.Blocks.LogCubeRotated("logcuberotated");
            Types.Blocks.LogCubeTemperateRotated logcubetemperaterotated = new Types.Blocks.LogCubeTemperateRotated("logcubetemperaterotated");
            Types.Blocks.LogCubeTemperateRotatedX logcubetemperaterotatedx = new Types.Blocks.LogCubeTemperateRotatedX("logcubetemperaterotatedx");
            Types.Blocks.LogCubeTemperateRotatedZ logcubetemperaterotatedz = new Types.Blocks.LogCubeTemperateRotatedZ("logcubetemperaterotatedz");
            Types.Blocks.LogCubeTaigaRotated logcubetaigarotated = new Types.Blocks.LogCubeTaigaRotated("logcubetaigarotated");
            Types.Blocks.LogCubeTaigaRotatedX logcubetaigarotatedx = new Types.Blocks.LogCubeTaigaRotatedX("logcubetaigarotatedx");
            Types.Blocks.LogCubeTaigaRotatedZ logcubetaigarotatedz = new Types.Blocks.LogCubeTaigaRotatedZ("logcubetaigarotatedz");


            // job stuff
            Types.JobBlocks.PotteryTable potterytable = new Types.JobBlocks.PotteryTable("potterytable");
            Types.JobBlocks.MasonTable masontable = new Types.JobBlocks.MasonTable("masontable");
            Types.JobBlocks.Sawmill sawmill = new Types.JobBlocks.Sawmill("sawmill");
            Types.JobBlocks.Anvil anvil = new Types.JobBlocks.Anvil("anvil");
            Types.JobBlocks.ChickenCoop chickencoop = new Types.JobBlocks.ChickenCoop("chickencoop");

            Types.JobBlocks.QuiverShortbow quiver               = new Types.JobBlocks.QuiverShortbow("quivershortbow");
            Types.JobBlocks.QuiverShortbowxMinus quiverxminus   = new Types.JobBlocks.QuiverShortbowxMinus("quivershortbowx-");
            Types.JobBlocks.QuiverShortbowxPlus quiverxplus     = new Types.JobBlocks.QuiverShortbowxPlus("quivershortbowx+");
            Types.JobBlocks.QuiverShortbowzMinus quiverzminus   = new Types.JobBlocks.QuiverShortbowzMinus("quivershortbowz-");
            Types.JobBlocks.QuiverShortbowzPlus quiverzplus     = new Types.JobBlocks.QuiverShortbowzPlus("quivershortbowz+");
            Types.JobBlocks.QuiverT2 quivert2                   = new Types.JobBlocks.QuiverT2("quivert2");
            Types.JobBlocks.QuiverT2xMinus quivert2xminus       = new Types.JobBlocks.QuiverT2xMinus("quivert2x-");
            Types.JobBlocks.QuiverT2xPlus quivert2xplus         = new Types.JobBlocks.QuiverT2xPlus("quivert2x+");
            Types.JobBlocks.QuiverT2zMinus quivert2zminus       = new Types.JobBlocks.QuiverT2zMinus("quivert2z-");
            Types.JobBlocks.QuiverT2zPlus quivert2zplus         = new Types.JobBlocks.QuiverT2zPlus("quivert2z+");
            Types.JobBlocks.QuiverT3 quivert3                   = new Types.JobBlocks.QuiverT3("quivert3");
            Types.JobBlocks.QuiverT3xMinus quivert3xminus       = new Types.JobBlocks.QuiverT3xMinus("quivert3x-");
            Types.JobBlocks.QuiverT3xPlus quivert3xplus         = new Types.JobBlocks.QuiverT3xPlus("quivert3x+");
            Types.JobBlocks.QuiverT3zMinus quivert3zminus       = new Types.JobBlocks.QuiverT3zMinus("quivert3z-");
            Types.JobBlocks.QuiverT3zPlus quivert3zplus         = new Types.JobBlocks.QuiverT3zPlus("quivert3z+");
            Types.JobBlocks.QuiverT4 quivert4                   = new Types.JobBlocks.QuiverT4("quivert4");
            Types.JobBlocks.QuiverT4xMinus quivert4xminus       = new Types.JobBlocks.QuiverT4xMinus("quivert4x-");
            Types.JobBlocks.QuiverT4xPlus quivert4xplus         = new Types.JobBlocks.QuiverT4xPlus("quivert4x+");
            Types.JobBlocks.QuiverT4zMinus quivert4zminus       = new Types.JobBlocks.QuiverT4zMinus("quivert4z-");
            Types.JobBlocks.QuiverT4zPlus quivert4zplus         = new Types.JobBlocks.QuiverT4zPlus("quivert4z+");
            Types.JobBlocks.QuiverT5 quivert5                   = new Types.JobBlocks.QuiverT5("quivert5");
            Types.JobBlocks.QuiverT5xMinus quivert5xminus       = new Types.JobBlocks.QuiverT5xMinus("quivert5x-");
            Types.JobBlocks.QuiverT5xPlus quivert5xplus         = new Types.JobBlocks.QuiverT5xPlus("quivert5x+");
            Types.JobBlocks.QuiverT5zMinus quivert5zminus       = new Types.JobBlocks.QuiverT5zMinus("quivert5z-");
            Types.JobBlocks.QuiverT5zPlus quivert5zplus         = new Types.JobBlocks.QuiverT5zPlus("quivert5z+");

            // interactive Items
            //Types.blocks.ChickenCoop chickencoop = new Types.blocks.ChickenCoop("chickencoop");

            // Decorative blocks

            // clay block orientations
            DecorativeTypeManager.TypeOption[] clayblocktypes = new DecorativeTypeManager.TypeOption[] { DecorativeTypeManager.TypeOption.Block,
                DecorativeTypeManager.TypeOption.Curve, DecorativeTypeManager.TypeOption.CurveRotated, DecorativeTypeManager.TypeOption.CurveCorner,
                DecorativeTypeManager.TypeOption.Slope, DecorativeTypeManager.TypeOption.SlopeCorner, DecorativeTypeManager.TypeOption.SlopeInsideCorner,
                DecorativeTypeManager.TypeOption.UpsideDownSlope, DecorativeTypeManager.TypeOption.UpsideDownSlopeCorner, DecorativeTypeManager.TypeOption.UpsideDownSlopInsideCorner,
                DecorativeTypeManager.TypeOption.TwoStairs, DecorativeTypeManager.TypeOption.FourStairs };

            Classes.Managers.DecorativeTypeManager clayblock = new DecorativeTypeManager("clayblock", "clayblock", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockblack = new DecorativeTypeManager("clayblockblack", "clayblockblack", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockblue = new DecorativeTypeManager("clayblockblue", "clayblockblue", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockbrown = new DecorativeTypeManager("clayblockbrown", "clayblockbrown", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockcyan = new DecorativeTypeManager("clayblockcyan", "clayblockcyan", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockgray = new DecorativeTypeManager("clayblockgray", "clayblockgray", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockgreen = new DecorativeTypeManager("clayblockgreen", "clayblockgreen", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblocklightblue = new DecorativeTypeManager("clayblocklightblue", "clayblocklightblue", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblocklime = new DecorativeTypeManager("clayblocklime", "clayblocklime", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockmagenta = new DecorativeTypeManager("clayblockmagenta", "clayblockmagenta", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockorange = new DecorativeTypeManager("clayblockorange", "clayblockorange", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockpink = new DecorativeTypeManager("clayblockpink", "clayblockpink", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockpurple = new DecorativeTypeManager("clayblockpurple", "clayblockpurple", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockred = new DecorativeTypeManager("clayblockred", "clayblockred", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblocksilver = new DecorativeTypeManager("clayblocksilver", "clayblocksilver", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockwhite = new DecorativeTypeManager("clayblockwhite", "clayblockwhite", "clay", "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockyellow = new DecorativeTypeManager("clayblockyellow", "clayblockyellow", "clay", "pottery", clayblocktypes);


        }
    }
}
