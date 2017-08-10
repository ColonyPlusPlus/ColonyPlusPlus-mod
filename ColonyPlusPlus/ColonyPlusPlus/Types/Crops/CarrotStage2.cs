using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Crops
{
    class CarrotStage2 : Classes.GrowableType
    {
        public CarrotStage2(string name) : base(name, true)
        {
            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("carrotstage1",   1,  0.8f)
            };
            this.OnRemove = onRemoveNode;
            this.IsSolid = false;
            this.NeedsBase = true;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "grassDelete";
            this.MaxStackSize = 1200;
            this.NPCLimit = 0;
            this.SideAll = "wheatwheat";
            this.Mesh = "carrotstage2";
            this.AllowCreative = false;
            this.IsBaseBlock = false;

            this.maxGrowth = 12f;


            TypeManager.registerCrop(this);
            CropManager.addCropStage(name, "carrotstage3");
            CropManager.CropTypes.Add("carrotstage2", this);

            this.Register();
        }
    }
}
