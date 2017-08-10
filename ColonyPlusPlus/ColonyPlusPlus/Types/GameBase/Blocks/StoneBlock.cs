using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class StoneBlock : ColonyAPI.Classes.Type
    {
        public StoneBlock(string name) : base(name)
        {
            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("stoneblock",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;

            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.DestructionTime = 600;
            this.IsPlaceable = true;
            this.MaxStackSize = 100;
            this.Register();
        }

        
    }
}
