using ColonyPlusPlus.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Oven : ColonyAPI.Classes.Type
    {
        public Oven(string name) : base(name)
        {
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.SideAll = "stonebricks";
            this.SideXPlus = "ovenunlitfront";
            this.DestructionTime = 800;
            this.NPCLimit = 0;
            this.RotatableXPlus = "ovenx+";
            this.RotatableXMinus = "ovenx-";
            this.RotatableZPlus = "ovenz+";
            this.RotatableZMinus = "ovenz-";
            this.IsPlaceable = true;
            this.IsAutoRotatable = true;

            CustomDataItem[] customData = {
                new CustomDataItem("volume", 0.2f),
                new CustomDataItem("intensity", 2.0f),
                new CustomDataItem("range", 8.0f),
                new CustomDataItem("red", 195.0f),
                new CustomDataItem("green", 135.0f),
                new CustomDataItem("blue", 46.0f),

            };
            CustomDataHelper c = new CustomDataHelper(customData);
            this.CustomData = c.customDataNode;

            this.Register();
        }
    }
    class OvenxPlus : ColonyAPI.Classes.Type
    {
        public OvenxPlus(string name) : base(name)
        {
            this.ParentType = "oven";
            this.SideAll = "stonebricks";
            this.SideXPlus = "ovenunlitfront";
            this.Register();
        }
    }
    class OvenxMinus : ColonyAPI.Classes.Type
    {
        public OvenxMinus(string name) : base(name)
        {
            this.ParentType = "oven";
            this.SideAll = "stonebricks";
            this.SideXMinus = "ovenunlitfront";
            this.Register();
        }
    }
    class OvenzPlus : ColonyAPI.Classes.Type
    {
        public OvenzPlus(string name) : base(name)
        {
            this.ParentType = "oven";
            this.SideAll = "stonebricks";
            this.SideZPlus = "ovenunlitfront";
            this.Register();
        }
    }
    class OvenzMinus : ColonyAPI.Classes.Type
    {
        public OvenzMinus(string name) : base(name)
        {
            this.ParentType = "oven";
            this.SideAll = "stonebricks";
            this.SideZMinus = "ovenunlitfront";
            this.Register();
        }
    }
}
