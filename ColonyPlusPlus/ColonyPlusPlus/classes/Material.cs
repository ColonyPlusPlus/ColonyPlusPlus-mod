using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes
{
    public static class Material
    {

        /// <summary>
        /// Pretty self explanatory
        /// </summary>
        /// <param name="identifier">The name of the material (eg: "testmaterial")</param>
        /// <param name="albedo"></param>
        /// <param name="emissive"></param>
        /// <param name="height"></param>
        /// <param name="normal"></param>
        public static void createMaterial(string identifier, string albedo, string emissive, string height, string normal)
        {
            // Register it with the ItemTypesServer
            ItemTypesServer.AddTextureMapping(identifier, new JSONNode(NodeType.Object)
                .SetAs("albedo", albedo)
                .SetAs("emissive", emissive)
                .SetAs("height", height)
                .SetAs("normal", normal)
            );
        }
    }
}
