using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
    class ItemHelper
    {
        public struct OnRemove
        {
            private string type;
            private int amount;
            private float chance;
            public OnRemove(string type, int amount, float chance)
            {
                this.type = type;
                this.amount = amount;
                this.chance = chance;
            }
            public string GetType()
            {
                return type;
            }
            public int GetAmount()
            {
                return amount;
            }
            public float GetChance()
            {
                return chance;
            }
        }
    }
}
