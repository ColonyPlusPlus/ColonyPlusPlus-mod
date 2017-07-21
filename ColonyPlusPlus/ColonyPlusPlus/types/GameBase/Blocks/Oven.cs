using ColonyPlusPlus.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Oven : classes.Type
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
    class OvenxPlus : classes.Type
    {
        public OvenxPlus(string name) : base(name)
        {
            this.ParentType = "oven";
            this.SideXPlus = "ovenunlitfront";
            this.Register();
        }
    }
    class OvenxMinus : classes.Type
    {
        public OvenxMinus(string name) : base(name)
        {
            this.ParentType = "oven";
            this.SideXMinus = "ovenunlitfront";
            this.Register();
        }
    }
    class OvenzPlus : classes.Type
    {
        public OvenzPlus(string name) : base(name)
        {
            this.ParentType = "oven";
            this.SideZPlus = "ovenunlitfront";
            this.Register();
        }
    }
    class OvenzMinus : classes.Type
    {
        public OvenzMinus(string name) : base(name)
        {
            this.ParentType = "oven";
            this.SideZMinus = "ovenunlitfront";
            this.Register();
        }
    }
}
