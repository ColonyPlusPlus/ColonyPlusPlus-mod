using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusDecorative.Managers;

namespace ColonyPlusPlusDecorative.Managers
{
    class BlockManager
    {
        // Register all blocks
        public static void register()
        {

            // Tell the player what we're doing here
            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Decorative", "Starting To Register Blocks");

            // clay block orientations
            
            DecorativeTypeManager.TypeOption[] clayblocktypes = new DecorativeTypeManager.TypeOption[] { DecorativeTypeManager.TypeOption.Block,
                DecorativeTypeManager.TypeOption.Curve, DecorativeTypeManager.TypeOption.CurveRotated, DecorativeTypeManager.TypeOption.CurveCorner,
                DecorativeTypeManager.TypeOption.Slope, DecorativeTypeManager.TypeOption.SlopeCorner, DecorativeTypeManager.TypeOption.SlopeInsideCorner,
                DecorativeTypeManager.TypeOption.UpsideDownSlope, DecorativeTypeManager.TypeOption.UpsideDownSlopeCorner, DecorativeTypeManager.TypeOption.UpsideDownSlopInsideCorner,
                DecorativeTypeManager.TypeOption.TwoStairs, DecorativeTypeManager.TypeOption.FourStairs };

            List<KeyValuePair<string, int>> clayblockReqs = new List<KeyValuePair<string, int>>() { new KeyValuePair<string, int>("clay", 1), new KeyValuePair<string, int>("waterbottle", 1) };

            DecorativeTypeManager clayblock = new DecorativeTypeManager("clayblock", "clayblock", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockblack = new DecorativeTypeManager("clayblockblack", "clayblockblack", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockblue = new DecorativeTypeManager("clayblockblue", "clayblockblue", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockbrown = new DecorativeTypeManager("clayblockbrown", "clayblockbrown", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockcyan = new DecorativeTypeManager("clayblockcyan", "clayblockcyan", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockgray = new DecorativeTypeManager("clayblockgray", "clayblockgray", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockgreen = new DecorativeTypeManager("clayblockgreen", "clayblockgreen", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblocklightblue = new DecorativeTypeManager("clayblocklightblue", "clayblocklightblue", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblocklime = new DecorativeTypeManager("clayblocklime", "clayblocklime", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockmagenta = new DecorativeTypeManager("clayblockmagenta", "clayblockmagenta", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockorange = new DecorativeTypeManager("clayblockorange", "clayblockorange", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockpink = new DecorativeTypeManager("clayblockpink", "clayblockpink", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockpurple = new DecorativeTypeManager("clayblockpurple", "clayblockpurple", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockred = new DecorativeTypeManager("clayblockred", "clayblockred", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblocksilver = new DecorativeTypeManager("clayblocksilver", "clayblocksilver", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockwhite = new DecorativeTypeManager("clayblockwhite", "clayblockwhite", clayblockReqs, "pottery", clayblocktypes);
            DecorativeTypeManager clayblockyellow = new DecorativeTypeManager("clayblockyellow", "clayblockyellow", clayblockReqs, "pottery", clayblocktypes);
        }
    }
}
