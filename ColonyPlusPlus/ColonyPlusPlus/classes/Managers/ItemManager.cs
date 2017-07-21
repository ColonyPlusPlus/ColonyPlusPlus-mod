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
            //Base Game Items
            types.GameBase.Items.Arrow arrow                        = new types.GameBase.Items.Arrow("arrow");
            types.GameBase.Items.Axe axe                            = new types.GameBase.Items.Axe("axe");
            types.GameBase.Items.Berry berry                        = new types.GameBase.Items.Berry("berry");
            types.GameBase.Items.Bow bow                            = new types.GameBase.Items.Bow("bow");
            types.GameBase.Items.Bread bread                        = new types.GameBase.Items.Bread("bread");
            types.GameBase.Items.Clay clay                          = new types.GameBase.Items.Clay("clay");
            types.GameBase.Items.CoalOre coalore                    = new types.GameBase.Items.CoalOre("coalore");
            types.GameBase.Items.Flax flax                          = new types.GameBase.Items.Flax("flax");
            types.GameBase.Items.Flour flour                        = new types.GameBase.Items.Flour("flour");
            types.GameBase.Items.GoldCoin goldcoin                  = new types.GameBase.Items.GoldCoin("goldcoin");
            types.GameBase.Items.GoldIngot goldingot                = new types.GameBase.Items.GoldIngot("goldingot");
            types.GameBase.Items.GoldOre goldore                    = new types.GameBase.Items.GoldOre("goldore");
            types.GameBase.Items.Gypsum gypsum                      = new types.GameBase.Items.Gypsum("gypsum");
            types.GameBase.Items.IronIngot ironingot                = new types.GameBase.Items.IronIngot("ironingot");
            types.GameBase.Items.IronOre ironore                    = new types.GameBase.Items.IronOre("ironore");
            types.GameBase.Items.LinseedOil linseedoil              = new types.GameBase.Items.LinseedOil("linseedoil");
            types.GameBase.Items.Pickaxe pickaxe                    = new types.GameBase.Items.Pickaxe("pickaxe");
            types.GameBase.Items.Straw straw                        = new types.GameBase.Items.Straw("straw");
            types.GameBase.Items.Wheat wheat                        = new types.GameBase.Items.Wheat("wheat");


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
