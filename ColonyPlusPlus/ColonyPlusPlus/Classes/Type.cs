using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes
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
        private bool _AllowCreative;
        private bool _AllowPlayerCraft;
        private bool _IsBaseBlock;

        private bool _HasAddAction;
        private bool _HasRemoveAction;
        private bool _HasChangeAction;

        private long _DestructionTime;

        private float _FuelValue;
        private float _NutritionalValue;
        private ushort _MaxStackSize;

		private Pipliz.JSON.JSONNode _CustomData = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

        // Array of OnRemove structs
        private ItemHelper.OnRemove[] _OnRemove;


        // Constructor
        public Type(string name, bool newtype = false)
        {
            this.TypeName = name;

            // disable creative on blocks
            this.AllowCreative = false;
            this.AllowPlayerCraft = false;
            this.IsBaseBlock = true;
            

            // save to JSON if this is a new item that's been added
            this.node.SetAs("newtype", newtype);

            // set default sideall
            if (Material.ValidateMat(name))
            {
                this._SideAll = "SELF";
                this.node.SetAs("sideall", "SELF");
            }

            // set defualt icon
            if(Utilities.ValidateIcon(name))
            {
                this._Icon = name + ".png";
            } else {
                this._Icon = "missing.png";
            }

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

        public string Sides
        {
            set
            {
                this.SideXMinus = value;
                this.SideXPlus = value;
                this.SideZMinus = value;
                this.SideZPlus = value;
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
                this._AllowCreative = true;
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

        public bool AllowCreative
        {
            get
            {
                return this._AllowCreative;
            }
            set
            {
                this._AllowCreative = value;
            }
        }

        public bool AllowPlayerCraft
        {
            get
            {
                return this._AllowPlayerCraft;
            }
            set
            {
                this._AllowPlayerCraft = value;
            }
        }

        public bool IsBaseBlock
        {
            get
            {
                return this._IsBaseBlock;
            }
            set
            {
                this._IsBaseBlock = value;
                this.node.SetAs("isBaseBlock", value);
            }
        }

        public bool HasAddAction
        {
            get
            {
                return this._HasAddAction;
            }
            set
            {
                this._HasAddAction = value;
            }
        }

        public bool HasRemoveAction
        {
            get
            {
                return this._HasRemoveAction;
            }
            set
            {
                this._HasRemoveAction = value;
            }
        }

        public bool HasChangeAction
        {
            get
            {
                return this._HasChangeAction;
            }
            set
            {
                this._HasChangeAction = value;
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
        public virtual void onRemoveAction(Pipliz.Vector3Int location, ushort type, Players.Player causedBy)
        {

        }

        // Overridable onAdd() function for events
        public virtual void onAddAction(Pipliz.Vector3Int location, ushort type, Players.Player causedBy)
        {
            //Utilities.WriteLog("Called virtual onAdd");
        }

        // Overridable onChange() function for events
        public virtual void onChangeAction(Pipliz.Vector3Int location, ushort fromtype, ushort totype, Players.Player causedBy)
        {

        }

        public void RegisterActionCallback()
        {
           // Utilities.WriteLog("Registering actions for:" + this.TypeName);
            if (this._HasAddAction)
            {
                Utilities.WriteLog(this.TypeName + " has action Add");
                ItemTypesServer.RegisterOnAdd(this.TypeName, this.onAddAction);
            }

            if (this._HasChangeAction)
            {
                Utilities.WriteLog(this.TypeName + " has action change");
                ItemTypesServer.RegisterOnChange(this.TypeName, this.onChangeAction);
            }

            if (this._HasRemoveAction)
            {
                Utilities.WriteLog(this.TypeName + " has action remove");
                ItemTypesServer.RegisterOnRemove(this.TypeName, this.onRemoveAction);
            }
        }

        // base Add Recipes function
        public virtual void AddRecipes()
        {

        }

		// create a callback to the RecipeManager to have it attempt to generate recipes
        public void AddRecipeCallback()
        {
            Classes.Managers.RecipeManager.TypesThatHaveRecipes.Add(this);
        }


        // Add the block!
        public void Register()
        {
            //Utilities.WriteLog(this.TypeName);
            


            // Add the item
            ItemTypes.AddRawType(this.TypeName, this.node);

            // register with our tracker, just in case we need to get these later!
            Classes.Managers.TypeManager.AddedTypes.Add(this.TypeName);
            Classes.Managers.TypeManager.registerActionableTypeCallback(this);

            if(this._AllowCreative)
            {
                Classes.Managers.TypeManager.CreativeAddedTypes.Add(this.TypeName);
            }

            // Tell the user it was added
            //Utilities.WriteLog("Added Type: " + this.TypeName, Helpers.Chat.ChatColour.green, Helpers.Chat.ChatStyle.italic);
             
            
        }
    }
}
