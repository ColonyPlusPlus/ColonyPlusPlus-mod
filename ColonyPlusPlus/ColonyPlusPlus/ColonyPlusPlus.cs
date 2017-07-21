using Pipliz;
using Pipliz.Chatting;
using Pipliz.JSON;
using Pipliz.Threading;
using ColonyPlusPlus;
using static Players;

namespace ColonyPlusPlus
{
    [ModLoader.ModManager]
    public class ColonyPlusPlus
    {
        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup)]
        public static void AfterStartup()
        {
            Pipliz.Log.Write("Loaded ColonyPlusPlus v0.0.14");
            
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerConnected)]
        public static void OnPlaterConnected(Player p)
        {
            Chat.Send(p.ID, "Welcome to ColonyPlusPlus, the first mod for Colony Survival to implement the new Modding API. If you have any questions please see our Steam Forum thread or the GitHub repository.");
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes)]
        public static void AfterAddingBaseTypes()
        {
            
            // Register Materials
            classes.Managers.MaterialManager.initialiseMaterials();

            // Register types
            classes.Managers.BlockManager.register();
            classes.Managers.ItemManager.register();
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
            classes.Managers.RecipeManager.AddBaseRecipes();
            classes.Managers.RecipeManager.BuildRecipeList();
            classes.Managers.RecipeManager.ProcessRecipes();
        }
    }
}