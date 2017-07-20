using Pipliz;
using Pipliz.Chatting;
using Pipliz.JSON;
using Pipliz.Threading;
using ColonyPlusPlus;

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
            
            // Register Materials
            classes.MaterialManager.initialiseMaterials();

            // Register types
            classes.Managers.BlockManager.registerTypes();
            classes.Managers.ItemManager.registerTypes();
            classes.TypeManager.registerTypes();


        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesServer)]
        public static void AfterItemTypesServer()
        {
            // Register Tracked Block Types (Wheat?)
            classes.TypeManager.registerTrackedTypes();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad)]
        public static void AfterWorldLoad()
        {

            //Stockpile.AddToInitialPile()
        }
    }
}