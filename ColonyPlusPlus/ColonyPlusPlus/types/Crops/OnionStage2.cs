using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.Crops
{
    class OnionStage2 : classes.GrowableType
    {
        public OnionStage2(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("onionstage1",   1,  0.8f)
            };
            this.OnRemove = onRemoveNode;
            this.IsSolid = false;
            this.NeedsBase = true;
            this.IsPlaceable = true;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "grassDelete";
            this.MaxStackSize = 1200;
            this.Icon = "potato";
            this.NPCLimit = 0;
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage1";
            this.maxGrowth = 12f;



            TypeManager.registerCrop(this);
            CropManager.addCropStage(name, "onionstage3");
            CropManager.CropTypes.Add("onionstage2", this);

            this.Register();
        }

        
    }
}
