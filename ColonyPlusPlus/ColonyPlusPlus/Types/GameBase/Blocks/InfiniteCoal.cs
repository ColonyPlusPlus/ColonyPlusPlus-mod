using ColonyPlusPlus.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class infiniteCoal : Classes.Type
    {
        public infiniteCoal(string name) : base(name)
        {
            this.OnRemoveAudio = "stoneDelete";
            this.DestructionTime = 1250;
            this.IsDestructible = false;

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("coalore",   1,  1.0f),
            };
            this.OnRemove = onRemoveNode;

            CustomDataItem[] customData = {
                new CustomDataItem("minerIsMineable", true),
                new CustomDataItem("minerMiningTime", 8.0f)

            };
            CustomDataHelper c = new CustomDataHelper(customData);
            this.CustomData = c.customDataNode;

            this.Register();
        }
    }
}
