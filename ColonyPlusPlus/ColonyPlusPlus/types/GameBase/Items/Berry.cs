using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class Berry : classes.Type
    {
        public Berry(string name) : base(name)
        {
            this.NutritionalValue = 0.6f;
            this.MaxStackSize = 600;
            this.Register();
        }
    }
}
