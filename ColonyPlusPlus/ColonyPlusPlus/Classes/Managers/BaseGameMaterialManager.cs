using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Managers
{
    class BaseGameMaterialManager
    {
        public static void initialiseMaterials()
        {
            Material.createMaterial("grasstemperate", "grassTemperate", "neutral", "grassGeneric", "grassGeneric");
            Material.createMaterial("grasstundra", "grassTundra", "neutral", "grassGeneric", "grassGeneric");
            Material.createMaterial("grasstaiga", "grassTaiga", "neutral", "grassGeneric", "grassGeneric");
            Material.createMaterial("grasssavanna", "grassSavanna", "neutral", "grassGeneric", "grassGeneric");
            Material.createMaterial("grassrainforest", "grassRainforest", "neutral", "grassGeneric", "grassGeneric");
            Material.createMaterial("sand", "sand", "neutral", "sand", "sand");
            Material.createMaterial("snow", "snow", "neutral", "snow", "snow");
            Material.createMaterial("dirt", "dirt", "neutral", "dirt", "dirt");
            Material.createMaterial("stoneblock", "stoneblock", "neutral", "stoneblock", "stoneblock");
            Material.createMaterial("planks", "planks", "neutral", "planks", "planks");
            Material.createMaterial("blackplanks", "blackplanks", "neutral", "planks", "planks");
            Material.createMaterial("redplanks", "redplanks", "neutral", "planks", "planks");
            Material.createMaterial("coatedplanks", "coatedplanks", "neutral", "coatedplanks", "planks");
            Material.createMaterial("adobe", "adobe", "neutral", "adobe", "adobe");
            Material.createMaterial("logtemperate", "logTemperate", "neutral", "log", "log");
            Material.createMaterial("logtaiga", "logTaiga", "neutral", "log", "log");
            Material.createMaterial("cherryblossom", "cherryBlossom", "neutral", "cherryBlossom", "cherryBlossom");
            Material.createMaterial("leavestemperate", "leavesTemperate", "neutral", "leavesTemperate", "leavesTemperate");
            Material.createMaterial("leavestaiga", "leavesTaiga", "neutral", "leavesTaiga", "leavesTaiga");
            Material.createMaterial("crate", "crate", "neutral", "crate", "crate");
            Material.createMaterial("stonebricks", "stoneBricks", "neutral", "stoneBricks", "stoneBricks");
            Material.createMaterial("workbenchtop", "workbenchTop", "neutral", "workbenchTop", "workbenchTop");
            Material.createMaterial("plasterblock", "plasterblock", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("furnaceside", "furnaceSide", "neutral", "furnaceSide", "furnaceSide");
            Material.createMaterial("furnaceunlittop", "furnaceUnlitTop", "neutral", "furnaceUnlitTop", "furnaceUnlitTop");
            Material.createMaterial("furnaceunlitfront", "furnaceUnlitFront", "neutral", "furnaceFront", "furnaceFront");
            Material.createMaterial("ovenunlitfront", "ovenUnlit", "neutral", "ovenFront", "ovenFront");
            Material.createMaterial("ovenlitfront", "ovenLit", "ovenLitFront", "ovenFront", "ovenFront");
            Material.createMaterial("infiniteiron", "oreIron", "neutral", "oreIron", "oreIron");
            Material.createMaterial("infiniteclay", "oreClay", "neutral", "oreClay", "oreClay");
            Material.createMaterial("infinitegypsum", "oreGypsum", "neutral", "oreGypsum", "oreGypsum");
            Material.createMaterial("infinitecoal", "oreCoal", "neutral", "oreCoal", "oreCoal");
            Material.createMaterial("infinitegold", "oreGold", "neutral", "oreGold", "oreGold");
            Material.createMaterial("infinitestone", "oreStone", "neutral", "stoneblock", "stoneblock");
            Material.createMaterial("lumberarea", "lumberArea", "neutral", "grassGeneric", "grassGeneric");
            Material.createMaterial("straw", "straw", "neutral", "straw", "straw");
            Material.createMaterial("furnacelittop", "furnaceLitTop", "furnaceLitTop", "furnaceUnlitTop", "furnaceLitTop");
            Material.createMaterial("furnacelitfront", "furnaceLitFront", "furnaceLitFront", "furnaceFront", "furnaceFront");
            Material.createMaterial("banner", "banner", "neutral", "neutral", "neutral");
            Material.createMaterial("bed", "bed", "neutral", "bed", "neutral");
            Material.createMaterial("quiverarrow", "quiverarrow", "neutral", "neutral", "neutral");
            Material.createMaterial("sappling", "sappling", "neutral", "neutral", "neutral");
            Material.createMaterial("torch", "torch", "torch", "torch", "neutral");
            Material.createMaterial("wheatwheat", "wheat", "neutral", "neutral", "neutral");
            Material.createMaterial("shop", "shop", "neutral", "shop", "shop");
            Material.createMaterial("flax", "flax", "neutral", "neutral", "neutral");
            Material.createMaterial("mint", "mint", "neutral", "mint", "mint");
            Material.createMaterial("bricks", "bricks", "neutral", "bricks", "bricks");
            Material.createMaterial("clay", "clay", "neutral", "clay", "clay");
            Material.createMaterial("grindstone", "grindstone", "neutral", "grindstone", "grindstone");
            Material.createMaterial("berrybush", "berrybush", "neutral", "berrybush", "berrybush");
            Material.createMaterial("error", "error", "neutral", "neutral", "neutral");
        }
    }
}
