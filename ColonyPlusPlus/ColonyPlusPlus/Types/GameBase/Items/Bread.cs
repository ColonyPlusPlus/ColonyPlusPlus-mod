using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class Bread : ColonyAPI.Classes.Type
    {
        public Bread(string name) : base(name)
        {
            this.NutritionalValue = 3.0f;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
