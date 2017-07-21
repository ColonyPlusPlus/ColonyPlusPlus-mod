using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class BedEnd : classes.Type
    {
        public BedEnd(string name) : base(name)
        {
            this.ParentType = "bed";
            this.IsAutoRotatable = true;
            this.RotatablexPlus = "bedendx+";
            this.RotatablexMinus = "bedendx-";
            this.RotatablezPlus = "bedendz+";
            this.RotatablezMinus = "bedendz-";
            this.Register();
        }
    }

    class BedendxPlus : classes.Type
    {
        public BedendxPlus(string name) : base(name)
        {
            this.ParentType = "bedend";
            this.Mesh = "bedendx+.obj";
            this.Register();
        }
    }
    class BedendxMinus : classes.Type
    {
        public BedendxMinus(string name) : base(name)
        {
            this.ParentType = "bedend";
            this.Mesh = "bedendx-.obj";
            this.Register();
        }
    }
    class BedendzPlus : classes.Type
    {
        public BedendzPlus(string name) : base(name)
        {
            this.ParentType = "bedend";
            this.Mesh = "bedendz+.obj";
            this.Register();
        }
    }
    class BedendzMinus : classes.Type
    {
        public BedendzMinus(string name) : base(name)
        {
            this.ParentType = "bedend";
            this.Mesh = "bedendz-.obj";
            this.Register();
        }
    }
}
