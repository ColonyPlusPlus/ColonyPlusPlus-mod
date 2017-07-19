using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types
{
    class Sugarcane : classes.Type
    {
        public Sugarcane(string name) : base(name)
        {

            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("sugarcaneitem", 3, 0.5f),
                new classes.ItemHelper.OnRemove("sugarcaneitem", 2, 0.5f)
            };

            //this.OnRemove = onRemoveNode;
            //classes.Utilities.WriteLog(onRemoveNode.ToString());

            this.Register();
        }
    }
}
