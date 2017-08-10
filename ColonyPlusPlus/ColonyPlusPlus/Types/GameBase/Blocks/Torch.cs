using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Torch : ColonyAPI.Classes.Type
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
    class TorchxPlus : ColonyAPI.Classes.Type
    {
        public TorchxPlus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Mesh = "torchx+";
            this.SideAll = "torch";
            this.Register();
        }
    }
    class TorchxMinus : ColonyAPI.Classes.Type
    {
        public TorchxMinus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Mesh = "torchx-";
            this.SideAll = "torch";
            this.Register();
        }
    }
    class TorchyPlus : ColonyAPI.Classes.Type
    {
        public TorchyPlus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.NeedsBase = true;
            this.Mesh = "torchy+";
            this.SideAll = "torch";
            this.Register();
        }
    }
    class TorchzPlus : ColonyAPI.Classes.Type
    {
        public TorchzPlus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Mesh = "torchz+";
            this.SideAll = "torch";
            this.Register();
        }
    }
    class TorchzMinus : ColonyAPI.Classes.Type
    {
        public TorchzMinus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Mesh = "torchz-";
            this.SideAll = "torch";
            this.Register();
        }
    }
}
