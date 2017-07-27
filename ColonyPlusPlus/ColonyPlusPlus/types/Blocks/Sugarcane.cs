using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class Sugarcane : Classes.Type
    {
        public Sugarcane(string name) : base(name)
        {

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("sugarcaneitem", 3, 0.5f),
                new Classes.ItemHelper.OnRemove("sugarcaneitem", 2, 0.5f)
            };

            this.OnRemove = onRemoveNode;

            this.Mesh = "sugarcane";
            this.OnRemoveAudio = "grassDelete";

            this.Register();
        }
    }
}
