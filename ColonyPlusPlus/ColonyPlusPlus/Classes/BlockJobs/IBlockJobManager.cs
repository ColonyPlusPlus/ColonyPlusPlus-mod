using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.BlockJobs
{
    public interface IBlockJobManager
    {
        void RegisterCallbackandLoad();
        void OnSave();
    }
}
