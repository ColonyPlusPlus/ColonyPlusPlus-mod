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
            //Base Game Blocks!
            types.GameBaseItems.Air air                             = new types.GameBaseItems.Air("air");
            types.GameBaseItems.Dirt dirt                           = new types.GameBaseItems.Dirt("dirt");
            types.GameBaseItems.Grass grass                         = new types.GameBaseItems.Grass("grass");
            types.GameBaseItems.GrassRainforest grassrainforest     = new types.GameBaseItems.GrassRainforest("grassrainforest");
            types.GameBaseItems.GrassSavanna grasssavanna           = new types.GameBaseItems.GrassSavanna("grasssavanna");
            types.GameBaseItems.GrassTaiga grasstaiga               = new types.GameBaseItems.GrassTaiga("grasstaiga");
            types.GameBaseItems.GrassTemperate grasstemperate       = new types.GameBaseItems.GrassTemperate("grasstemperate");
            types.GameBaseItems.GrassTundra grasstundra             = new types.GameBaseItems.GrassTundra("grasstundra");
            types.GameBaseItems.Sand sand                           = new types.GameBaseItems.Sand("sand");
            types.GameBaseItems.Snow snow                           = new types.GameBaseItems.Snow("snow");
            types.GameBaseItems.Water water                         = new types.GameBaseItems.Water("water");

            // Tell the player what we're doing here
            classes.Utilities.WriteLog("Starting To Register Blocks");

            // And register!
            types.blocks.WildBerryBush wildBerryBush                = new types.blocks.WildBerryBush("wildberrybush");
            types.blocks.Sugarcane sugarcane                        = new types.blocks.Sugarcane("sugarcane");
            types.blocks.VegetablePatch vegetablepatch              = new types.blocks.VegetablePatch("vegetablepatch");
        }
    }
}
