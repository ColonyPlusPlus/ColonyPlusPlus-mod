using Pipliz;
using Pipliz.Chatting;
using Pipliz.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
    public static class TypeCodeManager
    {

        /// <summary>
        /// NOT YET IMPLEMENTED
        /// </summary>
        /// <param name="position"></param>
        /// <param name="newType"></param>
        /// <param name="causedBy"></param>
        public static void OnAdd(Vector3Int position, ushort newType, NetworkID causedBy)
        {
            Chat.Send(causedBy, string.Format("You placed block {0} at {1}", ItemTypes.IndexLookup.GetName(newType), position));
            ThreadManager.InvokeOnMainThread(delegate ()
            {
                ServerManager.TrySetBlock(position, ItemTypes.IndexLookup.GetIndex("ExampleBlock2"), causedBy, false);
            }, 5.0);
        }

        public static void OnRemove(Vector3Int position, ushort wasType, NetworkID causedBy)
        {
            Chat.Send(causedBy, string.Format("You removed block {0} at {1}", ItemTypes.IndexLookup.GetName(wasType), position));
        }

        public static void OnChange(Vector3Int position, ushort wasType, ushort newType, NetworkID causedBy)
        {
            Chat.SendToAll(string.Format("Block type {0} changed to {1} at {2}",
                ItemTypes.IndexLookup.GetName(wasType),
                ItemTypes.IndexLookup.GetName(newType),
                position)
            );
        }
    }
}
