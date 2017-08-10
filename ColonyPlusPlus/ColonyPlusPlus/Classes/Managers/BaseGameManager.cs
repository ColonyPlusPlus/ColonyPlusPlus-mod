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

            //Base Game Special Items
            Types.GameBase.Special.Banner banner = new Types.GameBase.Special.Banner("banner");
            Types.GameBase.Special.BannerTool bannertool = new Types.GameBase.Special.BannerTool("bannertool");
            Types.GameBase.Special.CommandTool commandtool = new Types.GameBase.Special.CommandTool("commandtool");
            Types.GameBase.Special.ConstructionTool constructiontool = new Types.GameBase.Special.ConstructionTool("constructiontool");
            Types.GameBase.Special.LumberArea lumberarea = new Types.GameBase.Special.LumberArea("lumberarea");
            Types.GameBase.Special.MissingError missingerror = new Types.GameBase.Special.MissingError("missingerror");
            Types.GameBase.Special.ErrorNoFuel errornofuel = new Types.GameBase.Special.ErrorNoFuel("errornofuel");
            Types.GameBase.Special.ErrorNoPath errornopath = new Types.GameBase.Special.ErrorNoPath("errornopath");
            Types.GameBase.Special.ErrorIdle erroridle = new Types.GameBase.Special.ErrorIdle("erroridle");
            Types.GameBase.Special.SaveTool savetool = new Types.GameBase.Special.SaveTool("savetool");

            //Base Game Blocks!
            Types.GameBase.Blocks.Adobe adobe = new Types.GameBase.Blocks.Adobe("adobe");
            Types.GameBase.Blocks.Air air = new Types.GameBase.Blocks.Air("air");
            Types.GameBase.Blocks.Bed bed = new Types.GameBase.Blocks.Bed("bed");
            Types.GameBase.Blocks.BedxMinus bedxminus = new Types.GameBase.Blocks.BedxMinus("bedx-");
            Types.GameBase.Blocks.BedxPlus bedxplus = new Types.GameBase.Blocks.BedxPlus("bedx+");
            Types.GameBase.Blocks.BedzMinus bedzminus = new Types.GameBase.Blocks.BedzMinus("bedz-");
            Types.GameBase.Blocks.BedzPlus bedzplus = new Types.GameBase.Blocks.BedzPlus("bedz+");
            Types.GameBase.Blocks.BedEnd bedend = new Types.GameBase.Blocks.BedEnd("bedend");
            Types.GameBase.Blocks.BedendxMinus bedendxminus = new Types.GameBase.Blocks.BedendxMinus("bedendx-");
            Types.GameBase.Blocks.BedendxPlus bedendxplus = new Types.GameBase.Blocks.BedendxPlus("bedendx+");
            Types.GameBase.Blocks.BedendzMinus bedendzminus = new Types.GameBase.Blocks.BedendzMinus("bedendz-");
            Types.GameBase.Blocks.BedendzPlus bedendzplus = new Types.GameBase.Blocks.BedendzPlus("bedendz+");
            Types.GameBase.Blocks.BerryBush berrybush = new Types.GameBase.Blocks.BerryBush("berrybush");
            Types.GameBase.Blocks.BlackPlanks blackplanks = new Types.GameBase.Blocks.BlackPlanks("blackplanks");
            Types.GameBase.Blocks.Bricks bricks = new Types.GameBase.Blocks.Bricks("bricks");
            Types.GameBase.Blocks.CherrySapling cherrysapling = new Types.GameBase.Blocks.CherrySapling("cherrysapling");
            Types.GameBase.Blocks.CoatedPlanks coatedplanks = new Types.GameBase.Blocks.CoatedPlanks("coatedplanks");
            Types.GameBase.Blocks.Crate crate = new Types.GameBase.Blocks.Crate("crate");
            Types.GameBase.Blocks.Dirt dirt = new Types.GameBase.Blocks.Dirt("dirt");
            Types.GameBase.Blocks.FlaxStage flaxstage = new Types.GameBase.Blocks.FlaxStage("flaxstage");
            Types.GameBase.Blocks.FlaxStageOne flaxstageone = new Types.GameBase.Blocks.FlaxStageOne("flaxstage1");
            Types.GameBase.Blocks.FlaxStageTwo flaxstagetwo = new Types.GameBase.Blocks.FlaxStageTwo("flaxstage2");
            Types.GameBase.Blocks.Furnace furnace = new Types.GameBase.Blocks.Furnace("furnace");
            Types.GameBase.Blocks.FurnancexMinus furnacexminus = new Types.GameBase.Blocks.FurnancexMinus("furnacex-");
            Types.GameBase.Blocks.FurnancexPlus furnacexplus = new Types.GameBase.Blocks.FurnancexPlus("furnacex+");
            Types.GameBase.Blocks.FurnancezMinus furnacezminus = new Types.GameBase.Blocks.FurnancezMinus("furnacez-");
            Types.GameBase.Blocks.FurnancezPlus furnacezplus = new Types.GameBase.Blocks.FurnancezPlus("furnacez+");
            Types.GameBase.Blocks.FurnaceLit furnacelit = new Types.GameBase.Blocks.FurnaceLit("furnacelit");
            Types.GameBase.Blocks.FurnancelitxMinus furnacelitxminus = new Types.GameBase.Blocks.FurnancelitxMinus("furnacelitx-");
            Types.GameBase.Blocks.FurnancelitxPlus furnacelitxplus = new Types.GameBase.Blocks.FurnancelitxPlus("furnacelitx+");
            Types.GameBase.Blocks.FurnancelitzMinus furnacelitzminus = new Types.GameBase.Blocks.FurnancelitzMinus("furnacelitz-");
            Types.GameBase.Blocks.FurnancelitzPlus furnacelitzplus = new Types.GameBase.Blocks.FurnancelitzPlus("furnacelitz+");
            Types.GameBase.Blocks.Grass grass = new Types.GameBase.Blocks.Grass("grass");
            Types.GameBase.Blocks.GrassRainforest grassrainforest = new Types.GameBase.Blocks.GrassRainforest("grassrainforest");
            Types.GameBase.Blocks.GrassSavanna grasssavanna = new Types.GameBase.Blocks.GrassSavanna("grasssavanna");
            Types.GameBase.Blocks.GrassTaiga grasstaiga = new Types.GameBase.Blocks.GrassTaiga("grasstaiga");
            Types.GameBase.Blocks.GrassTemperate grasstemperate = new Types.GameBase.Blocks.GrassTemperate("grasstemperate");
            Types.GameBase.Blocks.GrassTundra grasstundra = new Types.GameBase.Blocks.GrassTundra("grasstundra");
            Types.GameBase.Blocks.Grindstone grindstone = new Types.GameBase.Blocks.Grindstone("grindstone");
            Types.GameBase.Blocks.InfiniteClay infiniteclay = new Types.GameBase.Blocks.InfiniteClay("infiniteclay");
            Types.GameBase.Blocks.infiniteCoal infinitecoal = new Types.GameBase.Blocks.infiniteCoal("infinitecoal");
            Types.GameBase.Blocks.InfiniteGold infinitegold = new Types.GameBase.Blocks.InfiniteGold("infinitegold");
            Types.GameBase.Blocks.InfiniteGypsum infinitegypsum = new Types.GameBase.Blocks.InfiniteGypsum("infinitegypsum");
            Types.GameBase.Blocks.InfiniteIron infiniteiron = new Types.GameBase.Blocks.InfiniteIron("infiniteiron");
            Types.GameBase.Blocks.InfiniteStone infinitestone = new Types.GameBase.Blocks.InfiniteStone("infinitestone");
            Types.GameBase.Blocks.Leaves leaves = new Types.GameBase.Blocks.Leaves("leaves");
            Types.GameBase.Blocks.LeavesTaiga leavestaiga = new Types.GameBase.Blocks.LeavesTaiga("leavestaiga");
            Types.GameBase.Blocks.LeavesTemperate leavestemperate = new Types.GameBase.Blocks.LeavesTemperate("leavestemperate");
            Types.GameBase.Blocks.CherryBlossom cherryblossom = new Types.GameBase.Blocks.CherryBlossom("cherryblossom");
            Types.GameBase.Blocks.Log log = new Types.GameBase.Blocks.Log("log");
            Types.GameBase.Blocks.LogTaiga logtaiga = new Types.GameBase.Blocks.LogTaiga("logtaiga");
            Types.GameBase.Blocks.LogTemperate logtemperate = new Types.GameBase.Blocks.LogTemperate("logtemperate");
            Types.GameBase.Blocks.Mint mint = new Types.GameBase.Blocks.Mint("mint");
            Types.GameBase.Blocks.Oven oven = new Types.GameBase.Blocks.Oven("oven");
            Types.GameBase.Blocks.OvenxMinus ovenxminus = new Types.GameBase.Blocks.OvenxMinus("ovenx-");
            Types.GameBase.Blocks.OvenxPlus ovenxplus = new Types.GameBase.Blocks.OvenxPlus("ovenx+");
            Types.GameBase.Blocks.OvenzMinus ovenzminus = new Types.GameBase.Blocks.OvenzMinus("ovenz-");
            Types.GameBase.Blocks.OvenzPlus ovenzplus = new Types.GameBase.Blocks.OvenzPlus("ovenz+");
            Types.GameBase.Blocks.OvenLit ovenlit = new Types.GameBase.Blocks.OvenLit("ovenlit");
            Types.GameBase.Blocks.OvenLitxMinus ovenLitxminus = new Types.GameBase.Blocks.OvenLitxMinus("ovenlitx-");
            Types.GameBase.Blocks.OvenLitxPlus ovenLitxplus = new Types.GameBase.Blocks.OvenLitxPlus("ovenlitx+");
            Types.GameBase.Blocks.OvenLitzMinus ovenLitzminus = new Types.GameBase.Blocks.OvenLitzMinus("ovenlitz-");
            Types.GameBase.Blocks.OvenLitzPlus ovenLitzplus = new Types.GameBase.Blocks.OvenLitzPlus("ovenlitz+");
            Types.GameBase.Blocks.Planks planks = new Types.GameBase.Blocks.Planks("planks");
            Types.GameBase.Blocks.PlasterBlock plasterblock = new Types.GameBase.Blocks.PlasterBlock("plasterblock");
            Types.GameBase.Blocks.Quiver quiver = new Types.GameBase.Blocks.Quiver("quiver");
            Types.GameBase.Blocks.QuiverxMinus quiverxminus = new Types.GameBase.Blocks.QuiverxMinus("quiverx-");
            Types.GameBase.Blocks.QuiverxPlus quiverxplus = new Types.GameBase.Blocks.QuiverxPlus("quiverx+");
            Types.GameBase.Blocks.QuiverzMinus quiverzminus = new Types.GameBase.Blocks.QuiverzMinus("quiverz-");
            Types.GameBase.Blocks.QuiverzPlus quiverzplus = new Types.GameBase.Blocks.QuiverzPlus("quiverz+");
            Types.GameBase.Blocks.RedPlanks redplanks = new Types.GameBase.Blocks.RedPlanks("redplanks");
            Types.GameBase.Blocks.Sand sand = new Types.GameBase.Blocks.Sand("sand");
            Types.GameBase.Blocks.Sappling sappling = new Types.GameBase.Blocks.Sappling("sappling");
            Types.GameBase.Blocks.Shop shop = new Types.GameBase.Blocks.Shop("shop");
            Types.GameBase.Blocks.Snow snow = new Types.GameBase.Blocks.Snow("snow");
            Types.GameBase.Blocks.StoneBlock stoneblock = new Types.GameBase.Blocks.StoneBlock("stoneblock");
            Types.GameBase.Blocks.StoneBricks stonebricks = new Types.GameBase.Blocks.StoneBricks("stonebricks");
            Types.GameBase.Blocks.TailorShop tailorshop = new Types.GameBase.Blocks.TailorShop("tailorshop");
            Types.GameBase.Blocks.Torch torch = new Types.GameBase.Blocks.Torch("torch");
            Types.GameBase.Blocks.TorchxMinus torchxMinus = new Types.GameBase.Blocks.TorchxMinus("torchx-");
            Types.GameBase.Blocks.TorchxPlus torchxPlus = new Types.GameBase.Blocks.TorchxPlus("torchx+");
            Types.GameBase.Blocks.TorchyPlus torchyPlus = new Types.GameBase.Blocks.TorchyPlus("torchy+");
            Types.GameBase.Blocks.TorchzMinus torchzMinus = new Types.GameBase.Blocks.TorchzMinus("torchz-");
            Types.GameBase.Blocks.TorchzPlus torchzPlus = new Types.GameBase.Blocks.TorchzPlus("torchz+");
            Types.GameBase.Blocks.Water water = new Types.GameBase.Blocks.Water("water");
            Types.GameBase.Blocks.WheatStage wheatstage = new Types.GameBase.Blocks.WheatStage("wheatstage");
            Types.GameBase.Blocks.WheatStageOne wheatstageone = new Types.GameBase.Blocks.WheatStageOne("wheatstage1");
            Types.GameBase.Blocks.WheatStageTwo wheatstagetwo = new Types.GameBase.Blocks.WheatStageTwo("wheatstage2");
            Types.GameBase.Blocks.WheatStageThree wheatstagethree = new Types.GameBase.Blocks.WheatStageThree("wheatstage3");
            Types.GameBase.Blocks.Workbench workbench = new Types.GameBase.Blocks.Workbench("workbench");
            Types.GameBase.Blocks.TechnologistTable technologisttable = new Types.GameBase.Blocks.TechnologistTable("technologisttable");
            Types.GameBase.Blocks.Carpet carpet = new Types.GameBase.Blocks.Carpet("carpet");
            Types.GameBase.Blocks.CarpetYellow carpetred = new Types.GameBase.Blocks.CarpetYellow("carpetred");
            Types.GameBase.Blocks.CarpetRed carpetyellow = new Types.GameBase.Blocks.CarpetRed("carpetyellow");
            Types.GameBase.Blocks.CarpetBlue carpetblue = new Types.GameBase.Blocks.CarpetBlue("carpetblue");

            Classes.Utilities.WriteLog("Finished Registering Basegame Blocks");


        }

        public static void registerItems()
        {
            // Tell the player what we're doing
            Classes.Utilities.WriteLog("Starting To Register Basegame Items");

            //Base Game Items
            Types.GameBase.Items.Arrow arrow = new Types.GameBase.Items.Arrow("arrow");
            Types.GameBase.Items.Axe axe = new Types.GameBase.Items.Axe("axe");
            Types.GameBase.Items.Berry berry = new Types.GameBase.Items.Berry("berry");
            Types.GameBase.Items.Bow bow = new Types.GameBase.Items.Bow("bow");
            Types.GameBase.Items.Bread bread = new Types.GameBase.Items.Bread("bread");
            Types.GameBase.Items.Clay clay = new Types.GameBase.Items.Clay("clay");
            Types.GameBase.Items.CoalOre coalore = new Types.GameBase.Items.CoalOre("coalore");
            Types.GameBase.Items.Clothing clothing = new Types.GameBase.Items.Clothing("clothing");
            Types.GameBase.Items.Flax flax = new Types.GameBase.Items.Flax("flax");
            Types.GameBase.Items.Flour flour = new Types.GameBase.Items.Flour("flour");
            Types.GameBase.Items.GoldCoin goldcoin = new Types.GameBase.Items.GoldCoin("goldcoin");
            Types.GameBase.Items.GoldIngot goldingot = new Types.GameBase.Items.GoldIngot("goldingot");
            Types.GameBase.Items.GoldOre goldore = new Types.GameBase.Items.GoldOre("goldore");
            Types.GameBase.Items.Gypsum gypsum = new Types.GameBase.Items.Gypsum("gypsum");
            Types.GameBase.Items.IronIngot ironingot = new Types.GameBase.Items.IronIngot("ironingot");
            Types.GameBase.Items.IronOre ironore = new Types.GameBase.Items.IronOre("ironore");
            Types.GameBase.Items.Linen linen = new Types.GameBase.Items.Linen("linen");
            Types.GameBase.Items.LinenBag linenbag = new Types.GameBase.Items.LinenBag("linenbag");
            //Types.GameBase.Items.LinenBag sciencebag = new Types.GameBase.Items.LinenBag("sciencebag");
            Types.GameBase.Items.LinseedOil linseedoil = new Types.GameBase.Items.LinseedOil("linseedoil");
            Types.GameBase.Items.Pickaxe pickaxe = new Types.GameBase.Items.Pickaxe("pickaxe");
            Types.GameBase.Items.ScienceBagBasic sbb = new Types.GameBase.Items.ScienceBagBasic("sciencebagbasic");
            Types.GameBase.Items.ScienceBagLife sbl = new Types.GameBase.Items.ScienceBagLife("sciencebaglife");
            Types.GameBase.Items.Straw straw = new Types.GameBase.Items.Straw("straw");
            Types.GameBase.Items.Wheat wheat = new Types.GameBase.Items.Wheat("wheat");

            Classes.Utilities.WriteLog("Finished Registering Basegame Items");
        }
    }
}
