using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes;

namespace ColonyPlusPlus.classes
{
    public static class TypeManager
    {
        public static void registerTypes()
        {
            Utilities.WriteLog("Starting To Add Types");

            // init items

            // blocks
            types.blocks.WildBerryBush wildBerryBush    = new types.blocks.WildBerryBush("wildberrybush");
            types.blocks.Sugarcane sugarcane            = new types.blocks.Sugarcane("sugarcane");
            types.blocks.VegetablePatch vegetablepatch  = new types.blocks.VegetablePatch("vegetablepatch");

            // materials
            types.items.Carrot carrot                   = new types.items.Carrot("carrot");
            types.items.Egg egg                         = new types.items.Egg("egg");
            types.items.Feather feather                 = new types.items.Feather("feather");
            types.items.Lettuce lettuce                 = new types.items.Lettuce("lettuce");
            types.items.Milk milk                       = new types.items.Milk("milk");
            types.items.Onion onion                     = new types.items.Onion("onion");
            types.items.Potato potato                   = new types.items.Potato("potato");
            types.items.Salt salt                       = new types.items.Salt("salt");
            types.items.Sugar sugar                     = new types.items.Sugar("sugar");

            // recipe items
            types.items.Butter butter                   = new types.items.Butter("butter");
            types.items.Cake cake                       = new types.items.Cake("cake");
            types.items.Jam jam                         = new types.items.Jam("jam");
            types.items.JamBread jamBread               = new types.items.JamBread("jambread");
            types.items.Omlette omlette                 = new types.items.Omlette("omlette");

            // misc items
            types.items.SugarcaneItem sugarcaneItem     = new types..itemsSugarcaneItem("sugarcaneitem");

        }

        public static void registerTrackedTypes()
        {
            /*
             *  ItemTypesServer.RegisterType("ExampleBlock1",
                new ItemTypesServer.ItemActionBuilder()
                .SetOnAdd(ExampleClassCodeManager.OnAdd)
                .SetOnRemove(ExampleClassCodeManager.OnRemove)
                .SetOnChange(ExampleClassCodeManager.OnChange)
                .SetChangeTypes("ExampleBlock1", "ExampleBlock2")
            );

            ItemTypesServer.RegisterParent("ExampleBlock2", "ExampleBlock1"); 
            */
        }
    }
}
