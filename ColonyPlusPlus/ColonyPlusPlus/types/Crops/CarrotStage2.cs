using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Crops
{
    class CarrotStage2 : Classes.GrowableType
    {
        public CarrotStage2(string name) : base(name)
        {
            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("carrotstage1",   1,  0.8f)
            };
            this.OnRemove = onRemoveNode;
            this.IsSolid = false;
            this.NeedsBase = true;
            this.IsPlaceable = true;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "grassDelete";
            this.MaxStackSize = 1200;
            this.NPCLimit = 0;
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage2";
            this.IsPlaceable = true;

            this.maxGrowth = 15f;


            TypeManager.registerCrop(this);
            CropManager.addCropStage(name, "carrotstage3");
            CropManager.CropTypes.Add("carrotstage2", this);

            this.Register();
        }
    }
}
