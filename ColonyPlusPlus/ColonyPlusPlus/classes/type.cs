using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
    public class Type
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
        private string _RotatableXMinus;
        private string _RotatableXPlus;
        private string _RotatableZMinus;
        private string _RotatableZPlus;
        private string _TypeName;
        private string _Icon;
        private string _Mesh;

        private int _NPCLimit;
		private int _OnRemoveAmount;

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

		private Pipliz.JSON.JSONNode _CustomData = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

        // Array of OnRemove structs
        private ItemHelper.OnRemove[] _OnRemove;


        // Constructor
        public Type(string name)
        {
            this.TypeName = name;

            // set default sideall
            this._SideAll = "SELF";
            this.node.SetAs("sideall", "SELF");

            // set defualt icon
            this._Icon = name + ".png";
            this.node.SetAs("icon", this._Icon);

            // set default isplacable 
            this._IsPlaceable = false;
            this.node.SetAs("isPlaceable", false);

            // Register the callback to add recipes
            this.AddRecipeCallback();
        }

        // Constructor with no arguments
        // Don't pass a name to this, we will set it later
        public Type()
        {
            // set default sideall
            this._SideAll = "SELF";
            this.node.SetAs("sideall", "SELF");

            // set defualt icon
            this._Icon = name + ".png";
            this.node.SetAs("icon", this._Icon);

            // set default isplacable 
            this._IsPlaceable = false;
            this.node.SetAs("isPlaceable", false);

            // Register the callback to add recipes
            this.AddRecipeCallback();
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

        public string RotatableXMinus
        {
            get
            {
                return this._RotatableXMinus;
            }
            set
            {
                this._RotatableXMinus = value;
                this.node.SetAs("rotatablex-", value);
            }
        }

        public string RotatableXPlus
        {
            get
            {
                return this._RotatableXPlus;
            }
            set
            {
                this._RotatableXPlus = value;
                this.node.SetAs("rotatablex+", value);
            }
        }

        public string RotatableZMinus
        {
            get
            {
                return this._RotatableZMinus;
            }
            set
            {
                this._RotatableZMinus = value;
                this.node.SetAs("rotatablez-", value);
            }
        }

        public string RotatableZPlus
        {
            get
            {
                return this._RotatableZPlus;
            }
            set
            {
                this._RotatableZPlus = value;
                this.node.SetAs("rotatablez+", value);
            }
        }

        public string Icon
        {
            get
            {
                return this._Icon;
            }
            set
            {
                this._Icon = value + ".png";
                this.node.SetAs("icon", value + ".png");
            }
        }

        public string Mesh
        {
            get
            {
                return this._Mesh;
            }
            set
            {
                this._Mesh = value + ".obj";
                this.node.SetAs("mesh", value + ".obj");
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

		public int OnRemoveAmount
		{
			get
			{
				return this._OnRemoveAmount;
			}
			set
			{
				this._OnRemoveAmount = value;
				this.node.SetAs("onRemoveAmount", value);
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
                this.node.SetAs("isRotatable", value);
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

		public JSONNode CustomData
		{
			get
			{
				return this._CustomData;
			} 
			set 
			{
				this._CustomData = value;
				this.node.SetAs("customData", value);
			}
		}

        public ItemHelper.OnRemove[] OnRemove
        {
            get
            {
                return this._OnRemove;
            } 
            set
            {
                this._OnRemove = value;

                // make the on remove node node
                JSONNode orn = new JSONNode(NodeType.Array);

                // iterate over the list of onRemove structs, and add them to nodes, which are added to the node list
                for (int i = 0; i < value.Length; i++)
                {
                    orn.AddToArray(new JSONNode(NodeType.Object).SetAs("type", value[i].Type).SetAs("amount", value[i].Amount).SetAs("chance", value[i].Chance));
                }

                this.node.SetAs("onRemove", orn);
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

        // Overridable onChange() function for events
        public virtual void onChange()
        {

        }

        // base Add Recipes function
        public virtual void AddRecipes()
        {

        }

		// create a callback to the RecipeManager to have it attempt to generate recipes
        public void AddRecipeCallback()
        {
            classes.Managers.RecipeManager.TypesThatHaveRecipes.Add(this);
        }

        // Add the block!
        public void Register()
        {

            // NOT YET IMPLEMENTED
            //ItemTypesServer.ItemActionBuilder builder = new ItemTypesServer.ItemActionBuilder().SetOnAdd(classes.typecodemanager.OnAdd).SetOnRemove(classes.typecodemanager.OnRemove);
            //.SetOnAdd(ExampleClassCodeManager.OnAdd)
            //    .SetOnRemove(ExampleClassCodeManager.OnRemove


            // Add the item
            ItemTypes.AddRawType(this.TypeName, this.node);

            // Tell the user it was added
            Utilities.WriteLog("Added Type: " + this.TypeName);

            
        }
    }
}
