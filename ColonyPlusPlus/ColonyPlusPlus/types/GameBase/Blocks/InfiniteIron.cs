using ColonyPlusPlus.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class InfiniteIron : classes.Type
    {
        public InfiniteIron(string name) : base(name)
        {
            this.OnRemoveAudio = "stoneDelete";
            this.DestructionTime = 1250;
            this.IsDestructible = false;

            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("ironore",   1,  1.0f),
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
