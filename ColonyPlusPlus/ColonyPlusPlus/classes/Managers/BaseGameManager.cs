using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes.Managers
{
    class BaseGameManager
    {
        // Register all blocks
        public static void registerBlocks()
        {
            classes.Utilities.WriteLog("Starting To Register Basegame Items");

            //Base Game Special Items
            types.GameBase.Special.Banner banner = new types.GameBase.Special.Banner("banner");
            types.GameBase.Special.BannerTool bannertool = new types.GameBase.Special.BannerTool("bannertool");
            types.GameBase.Special.CommandTool commandtool = new types.GameBase.Special.CommandTool("commandtool");
            types.GameBase.Special.ConstructionTool constructiontool = new types.GameBase.Special.ConstructionTool("constructiontool");
            types.GameBase.Special.LumberArea lumberarea = new types.GameBase.Special.LumberArea("lumberarea");
            types.GameBase.Special.MissingError missingerror = new types.GameBase.Special.MissingError("missingerror");
            types.GameBase.Special.ErrorNoFuel errornofuel = new types.GameBase.Special.ErrorNoFuel("errornofuel");
            types.GameBase.Special.ErrorNoPath errornopath = new types.GameBase.Special.ErrorNoPath("errornopath");
            types.GameBase.Special.ErrorIdle erroridle = new types.GameBase.Special.ErrorIdle("erroridle");
            types.GameBase.Special.SaveTool savetool = new types.GameBase.Special.SaveTool("savetool");

            //Base Game Blocks!
            types.GameBase.Blocks.Adobe adobe = new types.GameBase.Blocks.Adobe("adobe");
            types.GameBase.Blocks.Air air = new types.GameBase.Blocks.Air("air");
            types.GameBase.Blocks.Bed bed = new types.GameBase.Blocks.Bed("bed");
            types.GameBase.Blocks.BedxMinus bedxminus = new types.GameBase.Blocks.BedxMinus("bedx-");
            types.GameBase.Blocks.BedxPlus bedxplus = new types.GameBase.Blocks.BedxPlus("bedx+");
            types.GameBase.Blocks.BedzMinus bedzminus = new types.GameBase.Blocks.BedzMinus("bedz-");
            types.GameBase.Blocks.BedzPlus bedzplus = new types.GameBase.Blocks.BedzPlus("bedz+");
            types.GameBase.Blocks.BedEnd bedend = new types.GameBase.Blocks.BedEnd("bedend");
            types.GameBase.Blocks.BedendxMinus bedendxminus = new types.GameBase.Blocks.BedendxMinus("bedendx-");
            types.GameBase.Blocks.BedendxPlus bedendxplus = new types.GameBase.Blocks.BedendxPlus("bedendx+");
            types.GameBase.Blocks.BedendzMinus bedendzminus = new types.GameBase.Blocks.BedendzMinus("bedendz-");
            types.GameBase.Blocks.BedendzPlus bedendzplus = new types.GameBase.Blocks.BedendzPlus("bedendz+");
            types.GameBase.Blocks.BerryBush berrybush = new types.GameBase.Blocks.BerryBush("berrybush");
            types.GameBase.Blocks.BlackPlanks blackplanks = new types.GameBase.Blocks.BlackPlanks("blackplanks");
            types.GameBase.Blocks.Bricks bricks = new types.GameBase.Blocks.Bricks("bricks");
            types.GameBase.Blocks.CherrySapling cherrysapling = new types.GameBase.Blocks.CherrySapling("cherrysapling");
            types.GameBase.Blocks.CoatedPlanks coatedplanks = new types.GameBase.Blocks.CoatedPlanks("coatedplanks");
            types.GameBase.Blocks.Crate crate = new types.GameBase.Blocks.Crate("crate");
            types.GameBase.Blocks.Dirt dirt = new types.GameBase.Blocks.Dirt("dirt");
            types.GameBase.Blocks.FlaxStage flaxstage = new types.GameBase.Blocks.FlaxStage("flaxstage");
            types.GameBase.Blocks.FlaxStageOne flaxstageone = new types.GameBase.Blocks.FlaxStageOne("flaxstage1");
            types.GameBase.Blocks.FlaxStageTwo flaxstagetwo = new types.GameBase.Blocks.FlaxStageTwo("flaxstage2");
            types.GameBase.Blocks.Furnace furnace = new types.GameBase.Blocks.Furnace("furnace");
            types.GameBase.Blocks.FurnancexMinus furnacexminus = new types.GameBase.Blocks.FurnancexMinus("furnacex-");
            types.GameBase.Blocks.FurnancexPlus furnacexplus = new types.GameBase.Blocks.FurnancexPlus("furnacex+");
            types.GameBase.Blocks.FurnancezMinus furnacezminus = new types.GameBase.Blocks.FurnancezMinus("furnacez-");
            types.GameBase.Blocks.FurnancezPlus furnacezplus = new types.GameBase.Blocks.FurnancezPlus("furnacez+");
            types.GameBase.Blocks.FurnaceLit furnacelit = new types.GameBase.Blocks.FurnaceLit("furnacelit");
            types.GameBase.Blocks.FurnancelitxMinus furnacelitxminus = new types.GameBase.Blocks.FurnancelitxMinus("furnacelitx-");
            types.GameBase.Blocks.FurnancelitxPlus furnacelitxplus = new types.GameBase.Blocks.FurnancelitxPlus("furnacelitx+");
            types.GameBase.Blocks.FurnancelitzMinus furnacelitzminus = new types.GameBase.Blocks.FurnancelitzMinus("furnacelitz-");
            types.GameBase.Blocks.FurnancelitzPlus furnacelitzplus = new types.GameBase.Blocks.FurnancelitzPlus("furnacelitz+");
            types.GameBase.Blocks.Grass grass = new types.GameBase.Blocks.Grass("grass");
            types.GameBase.Blocks.GrassRainforest grassrainforest = new types.GameBase.Blocks.GrassRainforest("grassrainforest");
            types.GameBase.Blocks.GrassSavanna grasssavanna = new types.GameBase.Blocks.GrassSavanna("grasssavanna");
            types.GameBase.Blocks.GrassTaiga grasstaiga = new types.GameBase.Blocks.GrassTaiga("grasstaiga");
            types.GameBase.Blocks.GrassTemperate grasstemperate = new types.GameBase.Blocks.GrassTemperate("grasstemperate");
            types.GameBase.Blocks.GrassTundra grasstundra = new types.GameBase.Blocks.GrassTundra("grasstundra");
            types.GameBase.Blocks.Grindstone grindstone = new types.GameBase.Blocks.Grindstone("grindstone");
            types.GameBase.Blocks.InfiniteClay infiniteclay = new types.GameBase.Blocks.InfiniteClay("infiniteclay");
            types.GameBase.Blocks.infiniteCoal infinitecoal = new types.GameBase.Blocks.infiniteCoal("infinitecoal");
            types.GameBase.Blocks.InfiniteGold infinitegold = new types.GameBase.Blocks.InfiniteGold("infinitegold");
            types.GameBase.Blocks.InfiniteGypsum infinitegypsum = new types.GameBase.Blocks.InfiniteGypsum("infinitegypsum");
            types.GameBase.Blocks.InfiniteIron infiniteiron = new types.GameBase.Blocks.InfiniteIron("infiniteiron");
            types.GameBase.Blocks.InfiniteStone infinitestone = new types.GameBase.Blocks.InfiniteStone("infinitestone");
            types.GameBase.Blocks.Leaves leaves = new types.GameBase.Blocks.Leaves("leaves");
            types.GameBase.Blocks.LeavesTaiga leavestaiga = new types.GameBase.Blocks.LeavesTaiga("leavestaiga");
            types.GameBase.Blocks.LeavesTemperate leavestemperate = new types.GameBase.Blocks.LeavesTemperate("leavestemperate");
            types.GameBase.Blocks.CherryBlossom cherryblossom = new types.GameBase.Blocks.CherryBlossom("cherryblossom");
            types.GameBase.Blocks.Log log = new types.GameBase.Blocks.Log("log");
            types.GameBase.Blocks.LogTaiga logtaiga = new types.GameBase.Blocks.LogTaiga("logtaiga");
            types.GameBase.Blocks.LogTemperate logtemperate = new types.GameBase.Blocks.LogTemperate("logtemperate");
            types.GameBase.Blocks.Mint mint = new types.GameBase.Blocks.Mint("mint");
            types.GameBase.Blocks.Oven oven = new types.GameBase.Blocks.Oven("oven");
            types.GameBase.Blocks.OvenxMinus ovenxminus = new types.GameBase.Blocks.OvenxMinus("ovenx-");
            types.GameBase.Blocks.OvenxPlus ovenxplus = new types.GameBase.Blocks.OvenxPlus("ovenx+");
            types.GameBase.Blocks.OvenzMinus ovenzminus = new types.GameBase.Blocks.OvenzMinus("ovenz-");
            types.GameBase.Blocks.OvenzPlus ovenzplus = new types.GameBase.Blocks.OvenzPlus("ovenz+");
            types.GameBase.Blocks.OvenLit ovenlit = new types.GameBase.Blocks.OvenLit("ovenlit");
            types.GameBase.Blocks.OvenLitxMinus ovenLitxminus = new types.GameBase.Blocks.OvenLitxMinus("ovenlitx-");
            types.GameBase.Blocks.OvenLitxPlus ovenLitxplus = new types.GameBase.Blocks.OvenLitxPlus("ovenlitx+");
            types.GameBase.Blocks.OvenLitzMinus ovenLitzminus = new types.GameBase.Blocks.OvenLitzMinus("ovenlitz-");
            types.GameBase.Blocks.OvenLitzPlus ovenLitzplus = new types.GameBase.Blocks.OvenLitzPlus("ovenlitz+");
            types.GameBase.Blocks.Planks planks = new types.GameBase.Blocks.Planks("planks");
            types.GameBase.Blocks.PlasterBlock plasterblock = new types.GameBase.Blocks.PlasterBlock("plasterblock");
            types.GameBase.Blocks.Quiver quiver = new types.GameBase.Blocks.Quiver("quiver");
            types.GameBase.Blocks.QuiverxMinus quiverxminus = new types.GameBase.Blocks.QuiverxMinus("quiverx-");
            types.GameBase.Blocks.QuiverxPlus quiverxplus = new types.GameBase.Blocks.QuiverxPlus("quiverx+");
            types.GameBase.Blocks.QuiverzMinus quiverzminus = new types.GameBase.Blocks.QuiverzMinus("quiverz-");
            types.GameBase.Blocks.QuiverzPlus quiverzplus = new types.GameBase.Blocks.QuiverzPlus("quiverz+");
            types.GameBase.Blocks.RedPlanks redplanks = new types.GameBase.Blocks.RedPlanks("redplanks");
            types.GameBase.Blocks.Sand sand = new types.GameBase.Blocks.Sand("sand");
            types.GameBase.Blocks.Sappling sappling = new types.GameBase.Blocks.Sappling("sappling");
            types.GameBase.Blocks.Shop shop = new types.GameBase.Blocks.Shop("shop");
            types.GameBase.Blocks.Snow snow = new types.GameBase.Blocks.Snow("snow");
            types.GameBase.Blocks.StoneBlock stoneblock = new types.GameBase.Blocks.StoneBlock("stoneblock");
            types.GameBase.Blocks.StoneBricks stonebricks = new types.GameBase.Blocks.StoneBricks("stonebricks");
            types.GameBase.Blocks.Torch torch = new types.GameBase.Blocks.Torch("torch");
            types.GameBase.Blocks.TorchxMinus torchxMinus = new types.GameBase.Blocks.TorchxMinus("torchx-");
            types.GameBase.Blocks.TorchxPlus torchxPlus = new types.GameBase.Blocks.TorchxPlus("torchx+");
            types.GameBase.Blocks.TorchyPlus torchyPlus = new types.GameBase.Blocks.TorchyPlus("torchy+");
            types.GameBase.Blocks.TorchzMinus torchzMinus = new types.GameBase.Blocks.TorchzMinus("torchz-");
            types.GameBase.Blocks.TorchzPlus torchzPlus = new types.GameBase.Blocks.TorchzPlus("torchz+");
            types.GameBase.Blocks.Water water = new types.GameBase.Blocks.Water("water");
            types.GameBase.Blocks.WheatStage wheatstage = new types.GameBase.Blocks.WheatStage("wheatstage");
            types.GameBase.Blocks.WheatStageOne wheatstageone = new types.GameBase.Blocks.WheatStageOne("wheatstage1");
            types.GameBase.Blocks.WheatStageTwo wheatstagetwo = new types.GameBase.Blocks.WheatStageTwo("wheatstage2");
            types.GameBase.Blocks.WheatStageThree wheatstagethree = new types.GameBase.Blocks.WheatStageThree("wheatstage3");
            types.GameBase.Blocks.Workbench workbench = new types.GameBase.Blocks.Workbench("workbench");

            classes.Utilities.WriteLog("Finished Registering Basegame Blocks");


        }

        public static void registerItems()
        {
            // Tell the player what we're doing
            classes.Utilities.WriteLog("Starting To Register Basegame Items");

            //Base Game Items
            types.GameBase.Items.Arrow arrow = new types.GameBase.Items.Arrow("arrow");
            types.GameBase.Items.Axe axe = new types.GameBase.Items.Axe("axe");
            types.GameBase.Items.Berry berry = new types.GameBase.Items.Berry("berry");
            types.GameBase.Items.Bow bow = new types.GameBase.Items.Bow("bow");
            types.GameBase.Items.Bread bread = new types.GameBase.Items.Bread("bread");
            types.GameBase.Items.Clay clay = new types.GameBase.Items.Clay("clay");
            types.GameBase.Items.CoalOre coalore = new types.GameBase.Items.CoalOre("coalore");
            types.GameBase.Items.Flax flax = new types.GameBase.Items.Flax("flax");
            types.GameBase.Items.Flour flour = new types.GameBase.Items.Flour("flour");
            types.GameBase.Items.GoldCoin goldcoin = new types.GameBase.Items.GoldCoin("goldcoin");
            types.GameBase.Items.GoldIngot goldingot = new types.GameBase.Items.GoldIngot("goldingot");
            types.GameBase.Items.GoldOre goldore = new types.GameBase.Items.GoldOre("goldore");
            types.GameBase.Items.Gypsum gypsum = new types.GameBase.Items.Gypsum("gypsum");
            types.GameBase.Items.IronIngot ironingot = new types.GameBase.Items.IronIngot("ironingot");
            types.GameBase.Items.IronOre ironore = new types.GameBase.Items.IronOre("ironore");
            types.GameBase.Items.LinseedOil linseedoil = new types.GameBase.Items.LinseedOil("linseedoil");
            types.GameBase.Items.Pickaxe pickaxe = new types.GameBase.Items.Pickaxe("pickaxe");
            types.GameBase.Items.Straw straw = new types.GameBase.Items.Straw("straw");
            types.GameBase.Items.Wheat wheat = new types.GameBase.Items.Wheat("wheat");

            classes.Utilities.WriteLog("Finished Registering Basegame Items");
        }
    }
}
