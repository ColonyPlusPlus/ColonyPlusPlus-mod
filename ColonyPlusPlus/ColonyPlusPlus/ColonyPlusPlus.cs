using Pipliz;
using Pipliz.Chatting;
using Pipliz.JSON;
using Pipliz.Threading;


namespace ColonyPlusPlus
{
    [ModLoader.ModManager]
    public class ColonyPlusPlus
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAssemblyLoad)]
        public static void AfterAssemblyLoad()
        {
            Pipliz.Log.Write("Loaded ColonyPlusPlus v0.0.0");
            
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes)]
        public static void AfterAddingBaseTypes()
        {
            /*ItemTypesServer.AddTextureMapping("ExampleBlock1", new JSONNode(NodeType.Object)
                .SetAs("albedo", "grassTemperate")
                .SetAs("normal", "stoneblock")
                .SetAs("emissive", "ovenLitFront")
                .SetAs("height", "oreCoal")
            );

            ItemTypesServer.AddTextureMapping("ExampleBlock2", new JSONNode(NodeType.Object)
                .SetAs("albedo", "grindstone")
                .SetAs("normal", "berrybush")
                .SetAs("emissive", "torch")
                .SetAs("height", "snow")
            );*/

            // Register types
            classes.TypeManager.registerTypes();


        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesServer)]
        public static void AfterItemTypesServer()
        {

            classes.TypeManager.registerTrackedTypes();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad)]
        public static void AfterWorldLoad()
        {

            //Stockpile.AddToInitialPile()
        }
    }
}