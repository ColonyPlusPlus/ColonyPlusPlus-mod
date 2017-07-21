using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Quiver : classes.Type
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

    class QuiverxPlus : classes.Type
    {
        public QuiverxPlus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.Mesh = "quiverx+";
            this.Register();
        }
    }
    class QuiverxMinus : classes.Type
    {
        public QuiverxMinus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.Mesh = "quiverx-";
            this.Register();
        }
    }
    class QuiverzPlus : classes.Type
    {
        public QuiverzPlus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.Mesh = "quiverz+";
            this.Register();
        }
    }
    class QuiverzMinus : classes.Type
    {
        public QuiverzMinus(string name) : base(name)
        {
            this.ParentType = "quiver";
            this.Mesh = "quiverz-";
            this.Register();
        }
    }
}
