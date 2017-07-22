using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class StoneBlock : classes.Type
    {
        public StoneBlock(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("stoneblock",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;

            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.DestructionTime = 600;
            this.IsPlaceable = true;
            this.Register();
        }

        
    }
}
