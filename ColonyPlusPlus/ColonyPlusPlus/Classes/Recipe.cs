using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes
{
    public class Recipe
    {

        // Private lists of requirements and results and other needed privates
        private List<InventoryItem> requirements;
        private List<InventoryItem> results;
        private float fuelCost;
        private bool npcCraftable;
        private bool playerCraftable;
        private string type;

        // Constructor to assign these on initialisation
        public Recipe(string type, List<InventoryItem> requirements, List<InventoryItem> results, float fuelCost = 0.0f, bool npcCraftable = true, bool playerCraftable = false)
        {
            this.Type = type;
            this.Requirements = requirements;
            this.Results = results;
            this.FuelCost = fuelCost;
            this.NPCCraftable = npcCraftable;
            this.PlayerCraftable = playerCraftable;
        }

        // Getters and Setters
        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public List<InventoryItem> Requirements
        {
            get
            {
                return this.requirements;
            }
            set
            {
                this.requirements = value;
            }
        }

        public List<InventoryItem> Results
        {
            get
            {
                return this.results;
            }
            set
            {
                this.results = value;
            }
        }

        public float FuelCost
        {
            get
            {
                return this.fuelCost;
            }
            set
            {
                this.fuelCost = value;
            }
        }

        public bool NPCCraftable
        {
            get
            {
                return this.npcCraftable;
            }
            set
            {
                this.npcCraftable = value;
            }
        }

        public bool PlayerCraftable
        {
            get
            {
                return this.playerCraftable;
            }
            set
            {
                this.playerCraftable = value;
            }
        }

    }
}
