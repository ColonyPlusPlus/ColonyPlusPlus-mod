using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes;

namespace ColonyPlusPlus.Types.GameBase.Special
{
    class Banner : ColonyAPI.Classes.Type
    {
        public Banner(string name) : base(name)
        {
			this.OnPlaceAudio = "woodPlace";
			this.OnRemoveAudio = "woodDeleteLight";
			this.OnRemoveAmount = 0;
			this.IsSolid = false;
			this.NeedsBase = true;
            this.AllowCreative = true;
            this.Mesh = "banner";

			CustomDataItem[] customData = { new CustomDataItem("farShadows", true) };
			CustomDataHelper c = new CustomDataHelper(customData);
			this.CustomData = c.customDataNode;

            this.Register();

        }
    }
}
