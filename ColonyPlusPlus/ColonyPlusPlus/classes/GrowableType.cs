using Pipliz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.classes
{
    public class GrowableType : classes.Type
    {
        // base variables
        public float growthMultiplierMin = 0.9F; // 90%-110% growth needed to grow
        public float growthMultiplierMax = 1.1F;
        public float maxGrowth = 10F; // defaults to 10 hours

        // Extend the base class, passing type name
        public GrowableType(string name) : base(name)
        {
        }

        
        // Run on add to world (also runs when added by game - ie: when a crop grows to the next stage)
        public void OnAddAction(Vector3Int position, ushort newType, NetworkID causedBy)
        {
            ushort num;
            // check if the block below is fertile
            if (World.TryGetTypeAt(position.Add(0, -1, 0), out num) && ItemTypes.IsFertile(num))
            {
                CropManager.trackCrop(position, this);
            }
            else
            {
                // Tell the user you can't do this
                Pipliz.Chatting.Chat.Send(causedBy, string.Format("{0} can't grow here! It's not fertile!", ItemTypes.IndexLookup.GetName(newType)));

                // Get the air block, and replace the new crop with it
                ushort airBlockID = ItemTypes.IndexLookup.GetIndex("air");
                ServerManager.TrySetBlock(position, airBlockID, NetworkID.Invalid);
                

                // Give the user the block
                Stockpile s = Stockpile.GetStockPile(causedBy);

                // Give them an item back?
                s.Add(newType, 1);

                // Update it?
                s.SendUpdate();

            }
            
        }

        public void OnRemoveAction(Vector3Int position, ushort wasType, NetworkID causedBy)
        {
            CropManager.untrackCrop(position, this);
        }

        public void OnChangeAction(Vector3Int position, ushort wasType, ushort newType, NetworkID causedBy)
        {
            
        }
    }
}
