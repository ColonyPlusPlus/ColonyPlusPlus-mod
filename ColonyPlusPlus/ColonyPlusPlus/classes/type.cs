using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColonyPlusPlus.classes
{
    class type
    {

        // The JSONNode that holds the data
        private Pipliz.JSON.JSONNode node = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

        
        // Private variables to keep track of this
        private string _OnPlaceAudio;
        private string _OnRemoveAudio;
        private string _ParentType;
        private string _SideAll;
        private string _SideXMinus;
        private string _SideXPlus;
        private string _SideYMinus;
        private string _SideYPlus;
        private string _SideZMinus;
        private string _SideZPlus;
        private string _TypeName;

        private int _NPCLimit;

        private bool _IsSolid;
        private bool _IsPlaceable;
        private bool _IsFertile;
        private bool _NeedsBase;
        private bool _IsAutoRotatable;
        private bool _IsDestructible;

        private long _DestructionTime;

        private float _FuelValue;
        private float _NutritionalValue;
        private ushort _MaxStackSize;


        // Constructor
        public type(string name)
        {
            this.TypeName = name;
        }

        // Getters & Setters
        public string OnPlaceAudio
        {
            get
            {
                return this._OnPlaceAudio;
            }
            set
            {
                this._OnPlaceAudio = value;
                this.node.SetAs("onPlaceAudio", value);
            }
        }

        public string OnRemoveAudio
        {
            get
            {
                return this._OnRemoveAudio;
            }
            set
            {
                this._OnRemoveAudio = value;
                this.node.SetAs("onRemoveAudio", value);
            }
        }

        public string ParentType
        {
            get
            {
                return this._ParentType;
            }
            set
            {
                this._ParentType = value;
                this.node.SetAs("parentType", value);
            }
        }

        public string SideAll
        {
            get
            {
                return this._SideAll;
            }
            set
            {
                this._SideAll = value;
                this.node.SetAs("sideall", value);
            }
        }

        public string SideXMinus
        {
            get
            {
                return this._SideXMinus;
            }
            set
            {
                this._SideXMinus = value;
                this.node.SetAs("sidex-", value);
            }
        }

        public string SideXPlus
        {
            get
            {
                return this._SideXPlus;
            }
            set
            {
                this._SideXPlus = value;
                this.node.SetAs("sidex+", value);
            }
        }

        public string SideYMinus
        {
            get
            {
                return this._SideYMinus;
            }
            set
            {
                this._SideYMinus = value;
                this.node.SetAs("sidey-", value);
            }
        }

        public string SideYPlus
        {
            get
            {
                return this._SideYPlus;
            }
            set
            {
                this._SideYPlus = value;
                this.node.SetAs("sidey+", value);
            }
        }

        public string SideZMinus
        {
            get
            {
                return this._SideZMinus;
            }
            set
            {
                this._SideZMinus = value;
                this.node.SetAs("sidez-", value);
            }
        }

        public string SideZPlus
        {
            get
            {
                return this._SideZPlus;
            }
            set
            {
                this._SideZPlus = value;
                this.node.SetAs("sidez+", value);
            }
        }

        public int NPCLimit
        {
            get
            {
                return this._NPCLimit;
            }
            set
            {
                this._NPCLimit = value;
                this.node.SetAs("npcLimit", value);
            }
        }

        public bool IsSolid
        {
            get
            {
                return this._IsSolid;
            }
            set
            {
                this._IsSolid = value;
                this.node.SetAs("isSolid", value);
            }
        }

        public bool IsPlaceable
        {
            get
            {
                return this._IsPlaceable;
            }
            set
            {
                this._IsPlaceable = value;
                this.node.SetAs("isPlaceable", value);
            }
        }

        public bool IsFertile
        {
            get
            {
                return this._IsFertile;
            }
            set
            {
                this._IsFertile = value;
                this.node.SetAs("isFertile", value);
            }
        }

        public bool NeedsBase
        {
            get
            {
                return this._NeedsBase;
            }
            set
            {
                this._NeedsBase = value;
                this.node.SetAs("needsBase", value);
            }
        }

        public bool IsAutoRotatable
        {
            get
            {
                return this._IsAutoRotatable;
            }
            set
            {
                this._IsAutoRotatable = value;
                this.node.SetAs("isAutoRotatable", value);
            }
        }

        public bool IsDestructible
        {
            get
            {
                return this._IsDestructible;
            }
            set
            {
                this._IsDestructible = value;
                this.node.SetAs("isDestructible", value);
            }
        }
                
        public long DestructionTime
        {
            get
            {
                return this._DestructionTime;
            }
            set
            {
                this._DestructionTime = value;
                this.node.SetAs("destructionTime", value);
            }
        }
        
        public float FuelValue
        {
            get
            {
                return this._FuelValue;
            }
            set
            {
                this._FuelValue = value;
                this.node.SetAs("fuelValue", value);
            }
        }
        
        public float NutritionalValue
        {
            get
            {
                return this._NutritionalValue;
            }
            set
            {
                this._NutritionalValue = value;
                this.node.SetAs("nutritionalValue", value);
            }
        }
        
        public ushort MaxStackSize
        {
            get
            {
                return this._MaxStackSize;
            }
            set
            {
                this._MaxStackSize = value;
                this.node.SetAs("maxStackSize", value);
            }
        }

        public string TypeName
        {
            get
            {
                return this._TypeName;
            }
            set
            {
                this._TypeName = value;
            }
        }

        // Overridable onRemove() function for events
        public virtual void onRemove()
        {

        }

        // Overridable onAdd() function for events
        public virtual void onAdd()
        {

        }

        // Add the block!
        public void Register()
        {
            ItemTypesServer.ItemActionBuilder builder = new ItemTypesServer.ItemActionBuilder();

            //.SetOnAdd(ExampleClassCodeManager.OnAdd)
            //    .SetOnRemove(ExampleClassCodeManager.OnRemove

            ItemTypesServer.RegisterType(this.TypeName, builder);
        }
    }
}
