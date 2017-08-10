using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class Sugarcane : ColonyAPI.Classes.Type
    {
        public Sugarcane(string name) : base(name, true)
        {

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("sugarcaneitem", 3, 0.5f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("sugarcaneitem", 2, 0.5f)
            };

            this.OnRemove = onRemoveNode;

            this.Mesh = "sugarcane";
            this.OnRemoveAudio = "grassDelete";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
}
