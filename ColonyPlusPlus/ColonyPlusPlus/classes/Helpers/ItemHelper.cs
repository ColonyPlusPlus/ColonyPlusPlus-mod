using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
    public class ItemHelper
    {
        /// <summary>
        /// Struct for holding Type OnRemove objects
        /// </summary>
        public struct OnRemove
        {
            // holds the type ("planks", "temperateLog")
            private string type;

            // the number of items to give on remove
            private int amount;

            // The chance rating (0.0F-1.0F = 0%-100%)
            private float chance;

            // Constructor
            public OnRemove(string type, int amount, float chance)
            {
                this.type = type;
                this.amount = amount;
                this.chance = chance;
            }

            // Getters and setters
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
