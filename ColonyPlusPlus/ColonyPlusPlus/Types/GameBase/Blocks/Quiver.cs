using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Quiver : ColonyAPI.Classes.Type
    {
        public Quiver(string name) : base(name)
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

    class QuiverxPlus : ColonyAPI.Classes.Type
    {
        public QuiverxPlus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverx+";
            this.Register();
        }
    }
    class QuiverxMinus : ColonyAPI.Classes.Type
    {
        public QuiverxMinus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverx-";
            this.Register();
        }
    }
    class QuiverzPlus : ColonyAPI.Classes.Type
    {
        public QuiverzPlus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverz+";
            this.Register();
        }
    }
    class QuiverzMinus : ColonyAPI.Classes.Type
    {
        public QuiverzMinus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.SideAll = "quiverarrow";
            this.Mesh = "quiverz-";
            this.Register();
        }
    }
}
