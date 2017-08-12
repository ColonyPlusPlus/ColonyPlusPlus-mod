using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.Blocks
{
    class Sugarcane : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Sugarcane() : base(true)
        {

            this.TypeName = "sugarcane";
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("sugarcaneitem", 3, 0.5f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("sugarcaneitem", 2, 0.5f)
            };

            this.OnRemove = onRemoveNode;

            this.Mesh = "sugarcane";
            this.OnRemoveAudio = "grassDelete";
            this.IsBaseBlock = false;

            
        }
    }
}
