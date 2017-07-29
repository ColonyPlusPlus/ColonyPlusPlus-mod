using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class Wheat : Classes.Type
    {
        public Wheat(string name) : base(name)
        {
            this.NutritionalValue = 0.2f;
            this.MaxStackSize = 600;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
