using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes;

namespace ColonyPlusPlus.classes.Managers
{
    public static class TypeManager
    {

        public static List<GrowableType> GrowableTypesTracker = new List<GrowableType>();

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

        // Register the crop in the growable types list.
        public static void registerCrop(GrowableType classInstance)
        {
            GrowableTypesTracker.Add(classInstance);
        }
    }
}
