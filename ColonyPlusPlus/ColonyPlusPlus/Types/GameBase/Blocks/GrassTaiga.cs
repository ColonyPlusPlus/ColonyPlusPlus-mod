using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class GrassTaiga : ColonyAPI.Classes.Type
    {
        public GrassTaiga(string name) : base(name)
        {
            this.ParentType = "grass";
            this.IsPlaceable = true;

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("grasstaiga",   1,  1.0f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("wheatstage1",   1,  0.1f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("sappling",     1,  0.03f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
