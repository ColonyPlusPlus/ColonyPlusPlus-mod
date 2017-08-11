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

           /* // And register!
            Types.Blocks.Pillar pillar = new Types.Blocks.Pillar("pillar");
            Types.Blocks.WildBerryBush wildBerryBush                    = new Types.Blocks.WildBerryBush("wildberrybush");
            Types.Blocks.Window window                                  = new Types.Blocks.Window("window");
            Types.Blocks.WindowXMinus windowxminus = new Types.Blocks.WindowXMinus("windowx-");
            Types.Blocks.WindowXPlus windowxplus = new Types.Blocks.WindowXPlus("windowx+");
            Types.Blocks.WindowZMinus windowzminus = new Types.Blocks.WindowZMinus("windowz-");
            Types.Blocks.WindowZPlus windowzplus = new Types.Blocks.WindowZPlus("windowz+");
            Types.Blocks.WindowTwoHigh windowtwohigh                    = new Types.Blocks.WindowTwoHigh("windowtwohigh");
            Types.Blocks.WindowTwoHighXMinus windowtwohighxminus = new Types.Blocks.WindowTwoHighXMinus("windowtwohighx-");
            Types.Blocks.WindowTwoHighXPlus windowtwohighxplus = new Types.Blocks.WindowTwoHighXPlus("windowtwohighx+");
            Types.Blocks.WindowTwoHighZMinus windowtwohighzminus = new Types.Blocks.WindowTwoHighZMinus("windowtwohighz-");
            Types.Blocks.WindowTwoHighZPlus windowtwohighzplus = new Types.Blocks.WindowTwoHighZPlus("windowtwohighz+");
            Types.Blocks.Sugarcane sugarcane                            = new Types.Blocks.Sugarcane("sugarcane");
            Types.Blocks.VegetablePatch vegetablepatch                  = new Types.Blocks.VegetablePatch("vegetablepatch");

            // logs
            Types.Blocks.LogCube logcube                                = new Types.Blocks.LogCube("logcube");
            Types.Blocks.LogCubeTemperate logcubetemperate              = new Types.Blocks.LogCubeTemperate("logcubetemperate");
            Types.Blocks.LogCubeTaiga logcubetaiga                      = new Types.Blocks.LogCubeTaiga("logcubetaiga");
            Types.Blocks.LogCubeRotated logcuberotated                  = new Types.Blocks.LogCubeRotated("logcuberotated");
            Types.Blocks.LogCubeTemperateRotated logcubetemperaterotated = new Types.Blocks.LogCubeTemperateRotated("logcubetemperaterotated");
            Types.Blocks.LogCubeTemperateRotatedX logcubetemperaterotatedx = new Types.Blocks.LogCubeTemperateRotatedX("logcubetemperaterotatedx");
            Types.Blocks.LogCubeTemperateRotatedZ logcubetemperaterotatedz = new Types.Blocks.LogCubeTemperateRotatedZ("logcubetemperaterotatedz");
            Types.Blocks.LogCubeTaigaRotated logcubetaigarotated        = new Types.Blocks.LogCubeTaigaRotated("logcubetaigarotated");
            Types.Blocks.LogCubeTaigaRotatedX logcubetaigarotatedx      = new Types.Blocks.LogCubeTaigaRotatedX("logcubetaigarotatedx");
            Types.Blocks.LogCubeTaigaRotatedZ logcubetaigarotatedz      = new Types.Blocks.LogCubeTaigaRotatedZ("logcubetaigarotatedz");
            */

            // job stuff
            /*Types.JobBlocks.PotteryTable potterytable = new Types.JobBlocks.PotteryTable("potterytable");
            Types.JobBlocks.MasonTable masontable = new Types.JobBlocks.MasonTable("masontable");
            Types.JobBlocks.Sawmill sawmill = new Types.JobBlocks.Sawmill("sawmill");
            Types.JobBlocks.Anvil anvil = new Types.JobBlocks.Anvil("anvil");
            Types.JobBlocks.ChickenCoop chickencoop = new Types.JobBlocks.ChickenCoop("chickencoop");
            Types.JobBlocks.Well well = new Types.JobBlocks.Well("well");
            //Types.Blocks.WellTop welltop = new Types.Blocks.WellTop("welltop");*/
            

            // interactive Items
            //Types.blocks.ChickenCoop chickencoop = new Types.blocks.ChickenCoop("chickencoop");

            // Decorative blocks

            // clay block orientations
            DecorativeTypeManager.TypeOption[] clayblocktypes = new DecorativeTypeManager.TypeOption[] { DecorativeTypeManager.TypeOption.Block,
                DecorativeTypeManager.TypeOption.Curve, DecorativeTypeManager.TypeOption.CurveRotated, DecorativeTypeManager.TypeOption.CurveCorner,
                DecorativeTypeManager.TypeOption.Slope, DecorativeTypeManager.TypeOption.SlopeCorner, DecorativeTypeManager.TypeOption.SlopeInsideCorner,
                DecorativeTypeManager.TypeOption.UpsideDownSlope, DecorativeTypeManager.TypeOption.UpsideDownSlopeCorner, DecorativeTypeManager.TypeOption.UpsideDownSlopInsideCorner,
                DecorativeTypeManager.TypeOption.TwoStairs, DecorativeTypeManager.TypeOption.FourStairs };

            List<KeyValuePair<string, int>> clayblockReqs = new List<KeyValuePair<string, int>>() { new KeyValuePair<string, int>("clay", 1), new KeyValuePair<string, int>("waterbottle", 1) };

            Classes.Managers.DecorativeTypeManager clayblock = new DecorativeTypeManager("clayblock", "clayblock", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockblack = new DecorativeTypeManager("clayblockblack", "clayblockblack", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockblue = new DecorativeTypeManager("clayblockblue", "clayblockblue", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockbrown = new DecorativeTypeManager("clayblockbrown", "clayblockbrown", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockcyan = new DecorativeTypeManager("clayblockcyan", "clayblockcyan", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockgray = new DecorativeTypeManager("clayblockgray", "clayblockgray", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockgreen = new DecorativeTypeManager("clayblockgreen", "clayblockgreen", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblocklightblue = new DecorativeTypeManager("clayblocklightblue", "clayblocklightblue", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblocklime = new DecorativeTypeManager("clayblocklime", "clayblocklime", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockmagenta = new DecorativeTypeManager("clayblockmagenta", "clayblockmagenta", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockorange = new DecorativeTypeManager("clayblockorange", "clayblockorange", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockpink = new DecorativeTypeManager("clayblockpink", "clayblockpink", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockpurple = new DecorativeTypeManager("clayblockpurple", "clayblockpurple", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockred = new DecorativeTypeManager("clayblockred", "clayblockred", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblocksilver = new DecorativeTypeManager("clayblocksilver", "clayblocksilver", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockwhite = new DecorativeTypeManager("clayblockwhite", "clayblockwhite", clayblockReqs, "pottery", clayblocktypes);
            Classes.Managers.DecorativeTypeManager clayblockyellow = new DecorativeTypeManager("clayblockyellow", "clayblockyellow", clayblockReqs, "pottery", clayblocktypes);
        }
    }
}
