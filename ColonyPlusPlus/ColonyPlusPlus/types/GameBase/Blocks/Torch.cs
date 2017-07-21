using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Torch : classes.Type
    {
        public Torch(string name) : base(name)
        {
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.MaxStackSize = 600;
            this.IsSolid = false;
            this.NPCLimit = 0;
            this.IsPlaceable = true;

            CustomDataItem[] customData = {
                new CustomDataItem("volume", 0.5f),
                new CustomDataItem("intensity", 13.5f),
                new CustomDataItem("range", 16.0f),
                new CustomDataItem("red", 195.0f),
                new CustomDataItem("green", 135.0f),
                new CustomDataItem("blue", 46.0f),

            };
            CustomDataHelper c = new CustomDataHelper(customData);
            this.CustomData = c.customDataNode;
            this.Register();
        }
    }
    class TorchxPlus : classes.Type
    {
        public TorchxPlus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Register();
        }
    }
    class TorchxMinus : classes.Type
    {
        public TorchxMinus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Register();
        }
    }
    class TorchyPlus : classes.Type
    {
        public TorchyPlus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.NeedsBase = true;
            this.Register();
        }
    }
    class TorchzPlus : classes.Type
    {
        public TorchzPlus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Register();
        }
    }
    class TorchzMinus : classes.Type
    {
        public TorchzMinus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Register();
        }
    }
}
