using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.Crops
{
    class PotatoStage1 : classes.GrowableType
    {
        public PotatoStage1(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("potatostage1",   1,  0.6f)
            };
            this.OnRemove = onRemoveNode;
            this.IsSolid = false;
            this.NeedsBase = true;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "grassDelete";
            this.MaxStackSize = 1200;
            this.Icon = "potato";
            this.NPCLimit = 0;
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage1";
            this.maxGrowth = 12f;
            this.NutritionalValue = 0.3F;



            TypeManager.registerCrop(this);
            CropManager.addCropStage(name, "potatostage2");
            CropManager.CropTypes.Add("potatostage1", this);

            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("potatostage1", 1)
                },
                0.0f);
        }
    }
}
