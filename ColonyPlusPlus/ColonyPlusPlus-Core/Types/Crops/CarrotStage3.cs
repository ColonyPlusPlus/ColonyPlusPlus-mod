using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Crops
{
    class CarrotStage3 : ColonyAPI.Classes.Type
    {
        public CarrotStage3(string name) : base(name, true)
        {
            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("carrotstage1",   1,  1.0f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("carrotstage1",   2,  0.4f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("carrotstage1",   2,  0.4f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("carrotstage1",   2,  0.4f)
            };

            this.OnRemove = onRemoveNode;
            this.IsSolid = false;
            this.NeedsBase = true;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "grassDelete";
            this.MaxStackSize = 1200;
            this.NPCLimit = 0;
            this.SideAll = "wheatwheat";
            this.Mesh = "carrotstage3";
            this.AllowCreative = false;
            this.IsBaseBlock = false;



            this.Register();
        }
    }
}
