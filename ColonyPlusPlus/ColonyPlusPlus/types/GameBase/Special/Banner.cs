using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes;

namespace ColonyPlusPlus.types.GameBase.Special
{
    class Banner : classes.Type
    {
        public Banner(string name) : base(name)
        {
			this.OnPlaceAudio = "woodPlace";
			this.OnRemoveAudio = "woodDeleteLight";
			this.OnRemoveAmount = 0;
			this.IsSolid = false;
			this.NeedsBase = true;

			CustomDataItem[] customData = { new CustomDataItem("farShadows", true) };
			CustomDataHelper c = new CustomDataHelper(customData);
			this.CustomData = c.customDataNode;

            this.Register();

        }
    }
}
