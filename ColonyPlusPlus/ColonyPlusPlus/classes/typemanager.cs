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
            types.WildBerryBush wildBerryBush = new types.WildBerryBush("wildberrybush");
            types.Sugarcane sugarcane = new types.Sugarcane("sugarcane");

            // materials
            types.Sugar sugar = new types.Sugar("sugar");
            types.Salt salt = new types.Salt("salt");
            types.Milk milk = new types.Milk("milk");
            types.Egg egg = new types.Egg("egg");
            types.Feather feather = new types.Feather("feather");

            // recipe items
            types.Cake cake = new types.Cake("cake");
            types.JamBread jamBread = new types.JamBread("jambread");

            // misc items
            types.SugarcaneItem sugarcaneItem= new types.SugarcaneItem("sugarcaneitem");

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
