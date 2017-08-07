using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.JobBlocks
{
    class QuiverT5 : Classes.Type
    {
        public QuiverT5(string name) : base(name)
        {
            this.NPCLimit = 0;
            this.SideAll = "quiverarrow";
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.MaxStackSize = 400;
            this.IsAutoRotatable = true;
            this.NeedsBase = true;
            this.IsSolid = false;
            this.IsPlaceable = true;
            this.RotatableXPlus = "quiverx+";
            this.RotatableXMinus = "quiverx-";
            this.RotatableZPlus = "quiverz+";
            this.RotatableZMinus = "quiverz-";
            this.Register();
        }
    }

    class QuiverT5xPlus : Classes.Type
    {
        public QuiverT5xPlus(string name) : base(name)
        {
            this.ParentType = "quivert5";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverx+";
            this.Register();
        }
    }
    class QuiverT5xMinus : Classes.Type
    {
        public QuiverT5xMinus(string name) : base(name)
        {
            this.ParentType = "quivert5";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverx-";
            this.Register();
        }
    }
    class QuiverT5zPlus : Classes.Type
    {
        public QuiverT5zPlus(string name) : base(name)
        {
            this.ParentType = "quivert5";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverz+";
            this.Register();
        }
    }
    class QuiverT5zMinus : Classes.Type
    {
        public QuiverT5zMinus(string name) : base(name)
        {
            this.ParentType = "quivert5";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverz-";
            this.Register();
        }
    }
}
