using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.JobBlocks
{
    class QuiverT3 : Classes.Type
    {
        public QuiverT3(string name) : base(name)
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

    class QuiverT3xPlus : Classes.Type
    {
        public QuiverT3xPlus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverx+";
            this.Register();
        }
    }
    class QuiverT3xMinus : Classes.Type
    {
        public QuiverT3xMinus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverx-";
            this.Register();
        }
    }
    class QuiverT3zPlus : Classes.Type
    {
        public QuiverT3zPlus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverz+";
            this.Register();
        }
    }
    class QuiverT3zMinus : Classes.Type
    {
        public QuiverT3zMinus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverz-";
            this.Register();
        }
    }
}
