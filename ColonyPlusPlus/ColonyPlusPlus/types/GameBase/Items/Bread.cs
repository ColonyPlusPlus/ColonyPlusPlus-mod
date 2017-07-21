using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class Bread : classes.Type
    {
        public Bread(string name) : base(name)
        {
            this.NutritionalValue = 3.0f;
            this.Register();
        }
    }
}
