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
            ColonyAPI.Managers.MaterialManager.createMaterial("grasstemperate", "grassTemperate", "neutral", "grassGeneric", "grassGeneric");
            ColonyAPI.Managers.MaterialManager.createMaterial("grasstundra", "grassTundra", "neutral", "grassGeneric", "grassGeneric");
            ColonyAPI.Managers.MaterialManager.createMaterial("grasstaiga", "grassTaiga", "neutral", "grassGeneric", "grassGeneric");
            ColonyAPI.Managers.MaterialManager.createMaterial("grasssavanna", "grassSavanna", "neutral", "grassGeneric", "grassGeneric");
            ColonyAPI.Managers.MaterialManager.createMaterial("grassrainforest", "grassRainforest", "neutral", "grassGeneric", "grassGeneric");
            ColonyAPI.Managers.MaterialManager.createMaterial("sand", "sand", "neutral", "sand", "sand");
            ColonyAPI.Managers.MaterialManager.createMaterial("snow", "snow", "neutral", "snow", "snow");
            ColonyAPI.Managers.MaterialManager.createMaterial("dirt", "dirt", "neutral", "dirt", "dirt");
            ColonyAPI.Managers.MaterialManager.createMaterial("stoneblock", "stoneblock", "neutral", "stoneblock", "stoneblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("planks", "planks", "neutral", "planks", "planks");
            ColonyAPI.Managers.MaterialManager.createMaterial("blackplanks", "blackplanks", "neutral", "planks", "planks");
            ColonyAPI.Managers.MaterialManager.createMaterial("redplanks", "redplanks", "neutral", "planks", "planks");
            ColonyAPI.Managers.MaterialManager.createMaterial("coatedplanks", "coatedplanks", "neutral", "coatedplanks", "planks");
            ColonyAPI.Managers.MaterialManager.createMaterial("adobe", "adobe", "neutral", "adobe", "adobe");
            ColonyAPI.Managers.MaterialManager.createMaterial("logtemperate", "logTemperate", "neutral", "log", "log");
            ColonyAPI.Managers.MaterialManager.createMaterial("logtaiga", "logTaiga", "neutral", "log", "log");
            ColonyAPI.Managers.MaterialManager.createMaterial("cherryblossom", "cherryBlossom", "neutral", "cherryBlossom", "cherryBlossom");
            ColonyAPI.Managers.MaterialManager.createMaterial("leavestemperate", "leavesTemperate", "neutral", "leavesTemperate", "leavesTemperate");
            ColonyAPI.Managers.MaterialManager.createMaterial("leavestaiga", "leavesTaiga", "neutral", "leavesTaiga", "leavesTaiga");
            ColonyAPI.Managers.MaterialManager.createMaterial("crate", "crate", "neutral", "crate", "crate");
            ColonyAPI.Managers.MaterialManager.createMaterial("stonebricks", "stoneBricks", "neutral", "stoneBricks", "stoneBricks");
            ColonyAPI.Managers.MaterialManager.createMaterial("workbenchtop", "workbenchTop", "neutral", "workbenchTop", "workbenchTop");
            ColonyAPI.Managers.MaterialManager.createMaterial("plasterblock", "plasterblock", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("furnaceside", "furnaceSide", "neutral", "furnaceSide", "furnaceSide");
            ColonyAPI.Managers.MaterialManager.createMaterial("furnaceunlittop", "furnaceUnlitTop", "neutral", "furnaceUnlitTop", "furnaceUnlitTop");
            ColonyAPI.Managers.MaterialManager.createMaterial("furnaceunlitfront", "furnaceUnlitFront", "neutral", "furnaceFront", "furnaceFront");
            ColonyAPI.Managers.MaterialManager.createMaterial("ovenunlitfront", "ovenUnlit", "neutral", "ovenFront", "ovenFront");
            ColonyAPI.Managers.MaterialManager.createMaterial("ovenlitfront", "ovenLit", "ovenLitFront", "ovenFront", "ovenFront");
            ColonyAPI.Managers.MaterialManager.createMaterial("infiniteiron", "oreIron", "neutral", "oreIron", "oreIron");
            ColonyAPI.Managers.MaterialManager.createMaterial("infiniteclay", "oreClay", "neutral", "oreClay", "oreClay");
            ColonyAPI.Managers.MaterialManager.createMaterial("infinitegypsum", "oreGypsum", "neutral", "oreGypsum", "oreGypsum");
            ColonyAPI.Managers.MaterialManager.createMaterial("infinitecoal", "oreCoal", "neutral", "oreCoal", "oreCoal");
            ColonyAPI.Managers.MaterialManager.createMaterial("infinitegold", "oreGold", "neutral", "oreGold", "oreGold");
            ColonyAPI.Managers.MaterialManager.createMaterial("infinitestone", "oreStone", "neutral", "stoneblock", "stoneblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("lumberarea", "lumberArea", "neutral", "grassGeneric", "grassGeneric");
            ColonyAPI.Managers.MaterialManager.createMaterial("straw", "straw", "neutral", "straw", "straw");
            ColonyAPI.Managers.MaterialManager.createMaterial("furnacelittop", "furnaceLitTop", "furnaceLitTop", "furnaceUnlitTop", "furnaceLitTop");
            ColonyAPI.Managers.MaterialManager.createMaterial("furnacelitfront", "furnaceLitFront", "furnaceLitFront", "furnaceFront", "furnaceFront");
            ColonyAPI.Managers.MaterialManager.createMaterial("banner", "banner", "neutral", "neutral", "neutral");
            ColonyAPI.Managers.MaterialManager.createMaterial("bed", "bed", "neutral", "bed", "neutral");
            ColonyAPI.Managers.MaterialManager.createMaterial("quiverarrow", "quiverArrow", "neutral", "neutral", "neutral");
            ColonyAPI.Managers.MaterialManager.createMaterial("sappling", "sappling", "neutral", "neutral", "neutral");
            ColonyAPI.Managers.MaterialManager.createMaterial("torch", "torch", "torch", "torch", "neutral");
            ColonyAPI.Managers.MaterialManager.createMaterial("wheatwheat", "wheat", "neutral", "neutral", "neutral");
            ColonyAPI.Managers.MaterialManager.createMaterial("shop", "shop", "neutral", "shop", "shop");
            ColonyAPI.Managers.MaterialManager.createMaterial("flax", "flax", "neutral", "neutral", "neutral");
            ColonyAPI.Managers.MaterialManager.createMaterial("mint", "mint", "neutral", "mint", "mint");
            ColonyAPI.Managers.MaterialManager.createMaterial("bricks", "bricks", "neutral", "bricks", "bricks");
            ColonyAPI.Managers.MaterialManager.createMaterial("clay", "clay", "neutral", "clay", "clay");
            ColonyAPI.Managers.MaterialManager.createMaterial("grindstone", "grindstone", "neutral", "grindstone", "grindstone");
            ColonyAPI.Managers.MaterialManager.createMaterial("berrybush", "berrybush", "neutral", "berrybush", "berrybush");
            ColonyAPI.Managers.MaterialManager.createMaterial("error", "error", "neutral", "neutral", "neutral");
            ColonyAPI.Managers.MaterialManager.createMaterial("technologisttable", "technologisttable", "neutral", "neutral", "technologisttable");
        }
    }
}
