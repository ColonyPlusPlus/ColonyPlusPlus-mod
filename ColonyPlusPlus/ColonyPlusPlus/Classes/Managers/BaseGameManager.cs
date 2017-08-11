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

            Types.GameBase.Blocks.Grass grass = new Types.GameBase.Blocks.Grass("grass");
            Types.GameBase.Blocks.GrassRainforest grassrainforest = new Types.GameBase.Blocks.GrassRainforest("grassrainforest");
            Types.GameBase.Blocks.GrassSavanna grasssavanna = new Types.GameBase.Blocks.GrassSavanna("grasssavanna");
            Types.GameBase.Blocks.GrassTaiga grasstaiga = new Types.GameBase.Blocks.GrassTaiga("grasstaiga");
            Types.GameBase.Blocks.GrassTemperate grasstemperate = new Types.GameBase.Blocks.GrassTemperate("grasstemperate");
            Types.GameBase.Blocks.GrassTundra grasstundra = new Types.GameBase.Blocks.GrassTundra("grasstundra");
            Types.GameBase.Blocks.Leaves leaves = new Types.GameBase.Blocks.Leaves("leaves");
            Types.GameBase.Blocks.LeavesTaiga leavestaiga = new Types.GameBase.Blocks.LeavesTaiga("leavestaiga");
            Types.GameBase.Blocks.LeavesTemperate leavestemperate = new Types.GameBase.Blocks.LeavesTemperate("leavestemperate");
            Types.GameBase.Blocks.Log log = new Types.GameBase.Blocks.Log("log");
            Types.GameBase.Blocks.LogTaiga logtaiga = new Types.GameBase.Blocks.LogTaiga("logtaiga");
            Types.GameBase.Blocks.LogTemperate logtemperate = new Types.GameBase.Blocks.LogTemperate("logtemperate");
            Types.GameBase.Blocks.StoneBlock stoneblock = new Types.GameBase.Blocks.StoneBlock("stoneblock");
           

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
