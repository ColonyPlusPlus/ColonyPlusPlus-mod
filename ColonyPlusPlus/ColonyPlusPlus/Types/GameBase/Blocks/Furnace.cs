using ColonyPlusPlus.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Furnace : ColonyAPI.Classes.Type
    {
        public Furnace(string name) : base(name)
        {
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.IsAutoRotatable = true;
            this.IsPlaceable = true;
            this.SideAll = "furnaceside";
            this.SideYPlus = "furnacelittop";
            this.SideXPlus = "furnacelitfront";
            this.DestructionTime = 800;
            this.NPCLimit = 0;
            this.RotatableXPlus = "furnacex+";
            this.RotatableXMinus = "furnacex-";
            this.RotatableZPlus = "furnacez+";
            this.RotatableZMinus = "furnacez-";

            CustomDataItem[] customDataUp = {
                new CustomDataItem("volume", 0.3f),
                new CustomDataItem("intensity", 2.5f),
                new CustomDataItem("range", 8.0f),
                new CustomDataItem("red", 195.0f),
                new CustomDataItem("green", 135.0f),
                new CustomDataItem("blue", 46.0f),

            };
            CustomDataItem[] customDataSide = {
                new CustomDataItem("volume", 0.2f),
                new CustomDataItem("intensity", 1.0f),
                new CustomDataItem("range", 8.0f),
                new CustomDataItem("red", 195.0f),
                new CustomDataItem("green", 135.0f),
                new CustomDataItem("blue", 46.0f),

            };
            Pipliz.JSON.JSONNode tempCustomDataNode = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);
            CustomDataHelper cu = new CustomDataHelper(customDataUp);
            tempCustomDataNode.SetAs("up", cu.customDataNode);

            CustomDataHelper cs = new CustomDataHelper("side", customDataSide, cu.customDataNode);
            tempCustomDataNode.SetAs("side", cs.customDataNode);
            this.CustomData = tempCustomDataNode;

            this.Register();
        }
    }
    class FurnancexPlus : ColonyAPI.Classes.Type
    {
        public FurnancexPlus(string name) : base(name)
        {
            this.ParentType = "furnace";
            this.SideAll = "furnaceside";
            this.SideXPlus = "furnaceunlitfront";
            this.Register();
        }
    }
    class FurnancexMinus : ColonyAPI.Classes.Type
    {
        public FurnancexMinus(string name) : base(name)
        {
            this.ParentType = "furnace";
            this.SideAll = "furnaceside";
            this.SideXMinus = "furnaceunlitfront";
            this.Register();
        }
    }
    class FurnancezPlus : ColonyAPI.Classes.Type
    {
        public FurnancezPlus(string name) : base(name)
        {
            this.ParentType = "furnace";
            this.SideAll = "furnaceside";
            this.SideZPlus = "furnaceunlitfront";
            this.Register();
        }
    }
    class FurnancezMinus : ColonyAPI.Classes.Type
    {
        public FurnancezMinus(string name) : base(name)
        {
            this.ParentType = "furnace";
            this.SideAll = "furnaceside";
            this.SideZMinus = "furnaceunlitfront";
            this.Register();
        }
    }
}
