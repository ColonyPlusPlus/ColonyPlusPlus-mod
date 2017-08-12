using ColonyPlusPlusCore.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz;

namespace ColonyPlusPlusCore.Types.JobBlocks
{
    class Well : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Well() : base()
        {
            this.TypeName = "well";
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
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("stonebricks", 12),
                    ColonyAPI.Managers.RecipeManager.Item("planks", 6)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("well", 1),
                    ColonyAPI.Managers.RecipeManager.Item("welltop", 1)
                }, true, true);
        }

        /*public override void onAddAction(Vector3Int location, ushort type, Players.Player causedBy)
        {
            

            Classes.Utilities.WriteLog("Added well");
            Classes.Helpers.Chat.send(causedBy, "Added well");
            base.onAddAction(location, type, causedBy);
        }*/
    }
}
