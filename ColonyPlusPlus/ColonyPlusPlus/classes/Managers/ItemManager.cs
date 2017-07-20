using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes.Managers
{
    class ItemManager
    {
        /// <summary>
        /// Register all the items
        /// </summary>
        public static void register()
        {
            // Tell the player what we're doing
            classes.Utilities.WriteLog("Starting To Register Items");
            
            // init items

            // materials
            types.items.Carrot carrot                               = new types.items.Carrot("carrot");
            types.items.Cheese cheese                               = new types.items.Cheese("cheese");
            types.items.Egg egg                                     = new types.items.Egg("egg");
            types.items.Feather feather                             = new types.items.Feather("feather");
            types.items.Lettuce lettuce                             = new types.items.Lettuce("lettuce");
            types.items.Milk milk                                   = new types.items.Milk("milk");
            types.items.Onion onion                                 = new types.items.Onion("onion");
            types.items.Potato potato                               = new types.items.Potato("potato");
            types.items.Salt salt                                   = new types.items.Salt("salt");
            types.items.Sugar sugar                                 = new types.items.Sugar("sugar");

            // recipe items
            types.items.Butter butter                               = new types.items.Butter("butter");
            types.items.Cake cake                                   = new types.items.Cake("cake");
            types.items.Jam jam                                     = new types.items.Jam("jam");
            types.items.JamBread jamBread                           = new types.items.JamBread("jambread");
            types.items.Omlette omlette                             = new types.items.Omlette("omlette");
            types.items.BakedPotato bakedpotato                     = new types.items.BakedPotato("bakedpotato");

            // misc items
            types.items.SugarcaneItem sugarcaneItem                 = new types.items.SugarcaneItem("sugarcaneitem");
        }
    }
}
