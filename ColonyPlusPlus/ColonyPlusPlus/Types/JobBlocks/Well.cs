using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz;
using ColonyPlusPlus.Classes.Helpers;

namespace ColonyPlusPlus.Types.JobBlocks
{
    class Well : Classes.Type
    {
        public Well(string name) : base(name)
        {
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.SideAll = "stonebricks";
            this.SideYPlus = "welltop";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.AllowPlayerCraft = true;
            this.HasAddAction = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("stonebricks", 12),
                    RecipeManager.Item("planks", 6)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("well", 1)
                },
                0.0f, true, true);
        }

        /*public override void onAddAction(Vector3Int location, ushort type, Players.Player causedBy)
        {
            

            Classes.Utilities.WriteLog("Added well");
            Classes.Helpers.Chat.send(causedBy, "Added well");
            base.onAddAction(location, type, causedBy);
        }*/
    }
}
