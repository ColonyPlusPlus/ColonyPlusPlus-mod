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
            //Base Game Special Items
            types.GameBase.Special.BannerTool bannertool                = new types.GameBase.Special.BannerTool("bannertool");
            types.GameBase.Special.CommandTool commandtool              = new types.GameBase.Special.CommandTool("commandtool");
            types.GameBase.Special.ConstructionTool constructiontool    = new types.GameBase.Special.ConstructionTool("constructiontool");
            types.GameBase.Special.LumberArea lumberarea                = new types.GameBase.Special.LumberArea("lumberarea");
            types.GameBase.Special.MissingError missingerror            = new types.GameBase.Special.MissingError("missingerror");
            types.GameBase.Special.SaveTool savetool                    = new types.GameBase.Special.SaveTool("savetool");

            //Base Game Blocks!
            types.GameBase.Blocks.Adobe adobe                           = new types.GameBase.Blocks.Adobe("adobe");
            types.GameBase.Blocks.Air air                               = new types.GameBase.Blocks.Air("air");
            types.GameBase.Blocks.Bed bed                               = new types.GameBase.Blocks.Bed("bed");
            types.GameBase.Blocks.BedEnd bedend                         = new types.GameBase.Blocks.BedEnd("bedend");
            types.GameBase.Blocks.BerryBush berrybush                   = new types.GameBase.Blocks.BerryBush("berrybush");
            types.GameBase.Blocks.BlackPlanks blackplanks               = new types.GameBase.Blocks.BlackPlanks("blackplanks");
            types.GameBase.Blocks.Bricks bricks                         = new types.GameBase.Blocks.Bricks("bricks");
            types.GameBase.Blocks.CherrySapling cherrysapling           = new types.GameBase.Blocks.CherrySapling("cherrysapling");
            types.GameBase.Blocks.CoatedPlanks coatedplanks             = new types.GameBase.Blocks.CoatedPlanks("coatedplanks");
            types.GameBase.Blocks.Crate crate                           = new types.GameBase.Blocks.Crate("crate");
            types.GameBase.Blocks.Dirt dirt                             = new types.GameBase.Blocks.Dirt("dirt");
            types.GameBase.Blocks.FlaxStage flaxstage                   = new types.GameBase.Blocks.FlaxStage("flaxstage");
            types.GameBase.Blocks.FlaxStageOne flaxstageone             = new types.GameBase.Blocks.FlaxStageOne("flaxstage1");
            types.GameBase.Blocks.FlaxStageTwo flaxstagetwo             = new types.GameBase.Blocks.FlaxStageTwo("flaxstage2");
            types.GameBase.Blocks.FurnaceLit furnacelit                 = new types.GameBase.Blocks.FurnaceLit("furnacelit");
            types.GameBase.Blocks.Grass grass                           = new types.GameBase.Blocks.Grass("grass");
            types.GameBase.Blocks.GrassRainforest grassrainforest       = new types.GameBase.Blocks.GrassRainforest("grassrainforest");
            types.GameBase.Blocks.GrassSavanna grasssavanna             = new types.GameBase.Blocks.GrassSavanna("grasssavanna");
            types.GameBase.Blocks.GrassTaiga grasstaiga                 = new types.GameBase.Blocks.GrassTaiga("grasstaiga");
            types.GameBase.Blocks.GrassTemperate grasstemperate         = new types.GameBase.Blocks.GrassTemperate("grasstemperate");
            types.GameBase.Blocks.GrassTundra grasstundra               = new types.GameBase.Blocks.GrassTundra("grasstundra");
            types.GameBase.Blocks.Grindstone grindstone                 = new types.GameBase.Blocks.Grindstone("grindstone");
            types.GameBase.Blocks.Leaves leaves                         = new types.GameBase.Blocks.Leaves("leaves");
            types.GameBase.Blocks.LeavesTaiga leavestaiga               = new types.GameBase.Blocks.LeavesTaiga("leavestaiga");
            types.GameBase.Blocks.LeavesTemperate leavestemperate       = new types.GameBase.Blocks.LeavesTemperate("leavestemperate");
            types.GameBase.Blocks.CherryBlossom cherryblossom           = new types.GameBase.Blocks.CherryBlossom("cherryblossom");
            types.GameBase.Blocks.Log log                               = new types.GameBase.Blocks.Log("log");
            types.GameBase.Blocks.LogTaiga logtaiga                     = new types.GameBase.Blocks.LogTaiga("logtaiga");
            types.GameBase.Blocks.LogTemperate logtemperate             = new types.GameBase.Blocks.LogTemperate("logtemperate");
            types.GameBase.Blocks.Mint mint                             = new types.GameBase.Blocks.Mint("mint");
            types.GameBase.Blocks.OvenLit ovenlit                       = new types.GameBase.Blocks.OvenLit("ovenlit");
            types.GameBase.Blocks.Planks planks                         = new types.GameBase.Blocks.Planks("planks");
            types.GameBase.Blocks.PlasterBlock plasterblock             = new types.GameBase.Blocks.PlasterBlock("plasterblock");
            types.GameBase.Blocks.Quiver quiver                         = new types.GameBase.Blocks.Quiver("quiver");
            types.GameBase.Blocks.RedPlanks redplanks                   = new types.GameBase.Blocks.RedPlanks("redplanks");
            types.GameBase.Blocks.Sand sand                             = new types.GameBase.Blocks.Sand("sand");
            types.GameBase.Blocks.Sappling sappling                     = new types.GameBase.Blocks.Sappling("sappling");
            types.GameBase.Blocks.Shop shop                             = new types.GameBase.Blocks.Shop("shop");
            types.GameBase.Blocks.Snow snow                             = new types.GameBase.Blocks.Snow("snow");
            types.GameBase.Blocks.StoneBlock stoneblock                 = new types.GameBase.Blocks.StoneBlock("stoneblock");
            types.GameBase.Blocks.StoneBricks stonebricks               = new types.GameBase.Blocks.StoneBricks("stonebricks");
            types.GameBase.Blocks.Torch torch                           = new types.GameBase.Blocks.Torch("torch");
            types.GameBase.Blocks.TorchxMinus torchxMinus               = new types.GameBase.Blocks.TorchxMinus("torchx-");
            types.GameBase.Blocks.TorchxPlus torchxPlus                 = new types.GameBase.Blocks.TorchxPlus("torchx+");
            types.GameBase.Blocks.TorchyPlus torchyPlus                 = new types.GameBase.Blocks.TorchyPlus("torchy+");
            types.GameBase.Blocks.TorchzMinus torchzMinus               = new types.GameBase.Blocks.TorchzMinus("torchz-");
            types.GameBase.Blocks.TorchzPlus torchzPlus                 = new types.GameBase.Blocks.TorchzPlus("torchz+");
            types.GameBase.Blocks.Water water                           = new types.GameBase.Blocks.Water("water");
            types.GameBase.Blocks.WheatStage wheatstage                 = new types.GameBase.Blocks.WheatStage("wheatstage");
            types.GameBase.Blocks.WheatStageOne wheatstageone           = new types.GameBase.Blocks.WheatStageOne("wheatstage1");
            types.GameBase.Blocks.WheatStageTwo wheatstagetwo           = new types.GameBase.Blocks.WheatStageTwo("wheatstage2");
            types.GameBase.Blocks.WheatStageThree wheatstagethree       = new types.GameBase.Blocks.WheatStageThree("wheatstage3");
            types.GameBase.Blocks.Workbench workbench                   = new types.GameBase.Blocks.Workbench("workbench");

            // Tell the player what we're doing here
            classes.Utilities.WriteLog("Starting To Register Blocks");

            // And register!
            types.blocks.WildBerryBush wildBerryBush                    = new types.blocks.WildBerryBush("wildberrybush");
            types.blocks.Sugarcane sugarcane                            = new types.blocks.Sugarcane("sugarcane");
            types.blocks.VegetablePatch vegetablepatch                  = new types.blocks.VegetablePatch("vegetablepatch");
        }
    }
}
