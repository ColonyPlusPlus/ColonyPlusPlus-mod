using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Crops
{
    class LettuceStage3 : Classes.Type
    {
        public LettuceStage3(string name) : base(name)
        {
            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("lettucestage1",   1,  1.0f),
                new Classes.ItemHelper.OnRemove("lettucestage1",   2,  0.4f),
                new Classes.ItemHelper.OnRemove("lettucestage1",   2,  0.4f),
                new Classes.ItemHelper.OnRemove("lettucestage1",   2,  0.4f)
            };

            this.OnRemove = onRemoveNode;
            this.IsSolid = false;
            this.NeedsBase = true;
            this.AllowCreative = false;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "grassDelete";
            this.MaxStackSize = 1200;
            this.NPCLimit = 0;
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage3";
            this.NutritionalValue = 0.2f;

            

            this.Register();
        }
    }
}
