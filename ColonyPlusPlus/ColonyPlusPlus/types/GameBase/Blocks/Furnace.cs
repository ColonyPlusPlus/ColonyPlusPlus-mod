using ColonyPlusPlus.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Furnace : classes.Type
    {
        public Furnace(string name) : base(name)
        {
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.IsAutoRotatable = true;
            this.SideAll = "furnaceside";
            this.SideYPlus = "furnacelittop";
            this.SideXPlus = "furnacelitfront";
            this.DestructionTime = 800;
            this.NPCLimit = 0;

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
}
