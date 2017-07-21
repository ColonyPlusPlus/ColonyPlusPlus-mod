using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.blocks
{
    class Sugarcane : classes.Type
    {
        public Sugarcane(string name) : base(name)
        {

            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("sugarcaneitem", 3, 0.5f),
                new classes.ItemHelper.OnRemove("sugarcaneitem", 2, 0.5f)
            };

            this.OnRemove = onRemoveNode;

            this.Mesh = "sugarcane";
            this.OnRemoveAudio = "grassDelete";

            this.Register();
        }
    }
}
