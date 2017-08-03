using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPC;

namespace ColonyPlusPlus.Classes.BlockJobs.CraftingJob.Implementations
{
    public class ShopJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public override string NPCTypeKey { get { return "test.merchant"; } }
        public override float TimeBetweenJobs {  get { return 10f; } }
        public override List<global::Recipe> GetPossibleRecipes { get { return RecipeShopping.AllRecipes; } }
        public override int MaxRecipeCraftsPerHaul { get { return 1; } }
        public NPCTypeSettings GetNPCTypeDefinition()
        {
            NPCTypeSettings def = NPCTypeSettings.Default;
            def.keyName = NPCTypeKey;
            def.printName = "Merchant";
            def.maskColor1 = new UnityEngine.Color32(146, 31, 31, 255);
            def.type = NPCTypeID.GetNextID();
            def.inventoryCapacity = 1500f;
            return def;
        }
    }
}
