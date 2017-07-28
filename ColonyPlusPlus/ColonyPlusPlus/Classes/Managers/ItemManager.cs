using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Managers
{
    class ItemManager
    {
        /// <summary>
        /// Register all the Items
        /// </summary>
        public static void register()
        {
            

            // init Items

            // materials
            Types.Items.Cheese cheese                               = new Types.Items.Cheese("cheese");
            Types.Items.Egg egg                                     = new Types.Items.Egg("egg");
            Types.Items.Feather feather                             = new Types.Items.Feather("feather");
            Types.Items.Milk milk                                   = new Types.Items.Milk("milk");
            Types.Items.Salt salt                                   = new Types.Items.Salt("salt");
            Types.Items.Sugar sugar                                 = new Types.Items.Sugar("sugar");

            // recipe Items
            Types.Items.Butter butter                               = new Types.Items.Butter("butter");
            Types.Items.Cake cake                                   = new Types.Items.Cake("cake");
            Types.Items.Jam jam                                     = new Types.Items.Jam("jam");
            Types.Items.JamBread jamBread                           = new Types.Items.JamBread("jambread");
            Types.Items.Omlette omlette                             = new Types.Items.Omlette("omlette");
            Types.Items.BakedPotato bakedpotato                     = new Types.Items.BakedPotato("bakedpotato");

            // misc Items
            Types.Items.SugarcaneItem sugarcaneItem                 = new Types.Items.SugarcaneItem("sugarcaneitem");
        }
    }
}
