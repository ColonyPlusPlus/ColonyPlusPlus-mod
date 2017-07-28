using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz;

namespace ColonyPlusPlus.Classes.Data
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

        public CropData(Vector3Int loc, GrowableType cl, float growth, double time)
        {
            this.location = loc;
            this.classInstance = cl;
            this.growthAccumulated = growth;
            this.lastUpdateTimecycleHours = time;
        }

    }
}
