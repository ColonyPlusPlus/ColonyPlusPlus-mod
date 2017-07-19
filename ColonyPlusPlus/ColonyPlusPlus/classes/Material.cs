using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
    public class Material
    {
        public Material(string identifier, string albedo, string emissive, string height, string normal)
        {
            ItemTypesServer.AddTextureMapping(identifier, new JSONNode(NodeType.Object)
                .SetAs("albedo", albedo)
                .SetAs("emissive", emissive)
                .SetAs("height", height)
                .SetAs("normal", normal)
            );
        }
    }
}
