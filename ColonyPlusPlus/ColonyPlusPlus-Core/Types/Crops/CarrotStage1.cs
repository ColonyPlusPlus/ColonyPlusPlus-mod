using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;

namespace ColonyPlusPlusCore.Types.Crops
{ 
    class CarrotStage1 : GrowableType
    {
        public CarrotStage1(string name) : base(name, true)
        {
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("carrotstage1",   1,  0.6f)
            };
            this.OnRemove = onRemoveNode;
            this.IsSolid = false;
            this.NeedsBase = true;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "grassDelete";
            this.MaxStackSize = 1200;
            this.Icon = "carrot";
            this.NPCLimit = 0;
            this.SideAll = "wheatwheat";
            this.Mesh = "carrotstage1";
            this.maxGrowth = 12f;
            this.NutritionalValue = 0.3F;

            

            TypeManager.registerCrop(this);
            CropManager.addCropStage(name, "carrotstage2");
            CropManager.CropTypes.Add("carrotstage1", this);

            this.Register();
        }

        public override void AddRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 2)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("carrotstage1", 1)
                });
        }
    }
}
