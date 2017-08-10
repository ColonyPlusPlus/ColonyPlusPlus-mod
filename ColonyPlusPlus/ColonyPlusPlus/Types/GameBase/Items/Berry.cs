using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class Berry : ColonyAPI.Classes.Type
    {
        public Berry(string name) : base(name)
        {
            this.NutritionalValue = 0.6f;
            this.MaxStackSize = 600;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
