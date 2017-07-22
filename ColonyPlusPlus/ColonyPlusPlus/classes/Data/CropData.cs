using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz;

namespace ColonyPlusPlus.classes.Data
{
    public class CropData
    {

        // Hold the location of the crop, as well as the type of item it is, and the
        public Vector3Int location;
        public GrowableType classInstance;
        public float growthAccumulated;
        public double lastUpdateTimecycleHours;

        public CropData(Vector3Int loc, GrowableType cl)
        {
            this.location = loc;
            this.classInstance = cl;
            this.growthAccumulated = 0F;
            this.lastUpdateTimecycleHours = 0.0;
        }

    }
}
