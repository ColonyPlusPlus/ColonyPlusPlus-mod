using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class TorchxPlus : classes.Type
    {
        public TorchxPlus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Register();
        }
    }
    class TorchxMinus : classes.Type
    {
        public TorchxMinus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Register();
        }
    }
    class TorchyPlus : classes.Type
    {
        public TorchyPlus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.NeedsBase = true;
            this.Register();
        }
    }
    class TorchzPlus : classes.Type
    {
        public TorchzPlus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Register();
        }
    }
    class TorchzMinus : classes.Type
    {
        public TorchzMinus(string name) : base(name)
        {
            this.ParentType = "torch";
            this.Register();
        }
    }
}
