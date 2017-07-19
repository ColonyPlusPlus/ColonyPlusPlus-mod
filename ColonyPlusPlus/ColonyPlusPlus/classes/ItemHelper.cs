using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
    public class ItemHelper
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
            public string Type
            {
                get
                {
                    return this.type;
                }
            }
            public int Amount
            {
                get
                {
                    return this.amount;
                }
            }
            public float Chance
            {
                get
                {
                    return this.chance;
                }
            }
        }
    }
}
