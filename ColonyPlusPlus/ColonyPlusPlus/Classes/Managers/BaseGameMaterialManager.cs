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
            Material.createMaterial("grasstemperate", "grasstemperate", "neutral", "grassGeneric", "grassGeneric");
            Material.createMaterial("grasstundra", "grasstundra", "neutral", "grassGeneric", "grassGeneric");
            Material.createMaterial("grasstaiga", "grasstaiga", "neutral", "grassGeneric", "grassGeneric");
            Material.createMaterial("grasssavanna", "grasssavanna", "neutral", "grassGeneric", "grassGeneric");
            Material.createMaterial("grassrainforest", "grassrainforest", "neutral", "grassGeneric", "grassGeneric");
        }
    }
}
