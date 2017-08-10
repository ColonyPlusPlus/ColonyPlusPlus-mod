using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Bed : ColonyAPI.Classes.Type
    {
        public Bed(string name) : base(name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.IsAutoRotatable = true;
            this.IsSolid = false;
            this.NeedsBase = true;
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.RotatableXPlus = "bedx+";
            this.RotatableXMinus = "bedx-";
            this.RotatableZPlus = "bedz+";
            this.RotatableZMinus = "bedz-";
            this.Register();
        }
    }

    class BedxPlus : ColonyAPI.Classes.Type
    {
        public BedxPlus(string name) : base(name)
        {
            this.ParentType = "bed";
            this.SideAll = "bed";
            this.Mesh = "bedx+";
            this.Register();
        }
    }
    class BedxMinus : ColonyAPI.Classes.Type
    {
        public BedxMinus(string name) : base(name)
        {
            this.ParentType = "bed";
            this.SideAll = "bed";
            this.Mesh = "bedx-";
            this.Register();
        }
    }
    class BedzPlus : ColonyAPI.Classes.Type
    {
        public BedzPlus(string name) : base(name)
        {
            this.ParentType = "bed";
            this.SideAll = "bed";
            this.Mesh = "bedz+";
            this.Register();
        }
    }
    class BedzMinus : ColonyAPI.Classes.Type
    {
        public BedzMinus(string name) : base(name)
        {
            this.ParentType = "bed";
            this.SideAll = "bed";
            this.Mesh = "bedz-";
            this.Register();
        }
    }
}
