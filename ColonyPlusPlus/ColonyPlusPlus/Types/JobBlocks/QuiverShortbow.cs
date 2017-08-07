using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.JobBlocks
{
    class QuiverShortbow : Classes.Type
    {
        public QuiverShortbow(string name) : base(name)
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

    class QuiverShortbowxPlus : Classes.Type
    {
        public QuiverShortbowxPlus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverx+";
            this.Register();
        }
    }
    class QuiverShortbowxMinus : Classes.Type
    {
        public QuiverShortbowxMinus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverx-";
            this.Register();
        }
    }
    class QuiverShortbowzPlus : Classes.Type
    {
        public QuiverShortbowzPlus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverz+";
            this.Register();
        }
    }
    class QuiverShortbowzMinus : Classes.Type
    {
        public QuiverShortbowzMinus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverz-";
            this.Register();
        }
    }
}
