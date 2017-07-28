using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class TypeManager
    {

        public static List<GrowableType> GrowableTypesTracker = new List<GrowableType>();

        public static List<string> AddedTypes = new List<string>();
        public static List<string> CreativeAddedTypes = new List<string>();

        // using a prebuilt list of croptypes
        public static void registerTrackedTypes()
        {
            // loop through each growable type
            foreach(GrowableType gt in GrowableTypesTracker)
            {
                // register each crop with our custom crop actions
                ItemTypesServer.RegisterType(gt.TypeName, new ItemTypesServer.ItemActionBuilder().SetOnAdd(gt.OnAddAction).SetOnRemove(gt.OnRemoveAction).SetOnChange(gt.OnChangeAction));
            }
        }

        // Register the crop in the growable Types list.
        public static void registerCrop(GrowableType classInstance)
        {
            GrowableTypesTracker.Add(classInstance);
        }
    }
}
