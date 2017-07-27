using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class BedEnd : Classes.Type
    {
        public BedEnd(string name) : base(name)
        {
            this.ParentType = "bed";
            this.IsAutoRotatable = true;
            this.RotatableXPlus = "bedendx+";
            this.RotatableXMinus = "bedendx-";
            this.RotatableZPlus = "bedendz+";
            this.RotatableZMinus = "bedendz-";
            this.Register();
        }
    }

    class BedendxPlus : Classes.Type
    {
        public BedendxPlus(string name) : base(name)
        {
            this.ParentType = "bedend";
            this.SideAll = "bed";
            this.Mesh = "bedendx+";
            this.Register();
        }
    }
    class BedendxMinus : Classes.Type
    {
        public BedendxMinus(string name) : base(name)
        {
            this.ParentType = "bedend";
            this.SideAll = "bed";
            this.Mesh = "bedendx-";
            this.Register();
        }
    }
    class BedendzPlus : Classes.Type
    {
        public BedendzPlus(string name) : base(name)
        {
            this.ParentType = "bedend";
            this.SideAll = "bed";
            this.Mesh = "bedendz+";
            this.Register();
        }
    }
    class BedendzMinus : Classes.Type
    {
        public BedendzMinus(string name) : base(name)
        {
            this.ParentType = "bedend";
            this.SideAll = "bed";
            this.Mesh = "bedendz-";
            this.Register();
        }
    }
}
