using Pipliz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static NetworkID;

namespace ColonyPlusPlus.Classes.Data
{
    public class ChunkData
    {

        public Vector3Int location;
        private bool owned;
        private NetworkID playerID;
        public List<NetworkID> ownerHistory;
        private bool isSpawn;

        /// <summary>
        /// Instantiate a new chunk class
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="o"></param>
        /// <param name="p"></param>
        public ChunkData(Vector3Int loc, bool o, NetworkID p, List<NetworkID> history, bool spawn = false)
        {
            location = loc;
            owned = o;
            playerID = p;
            ownerHistory = history;
            isSpawn = spawn;
        }

        /// <summary>
        /// Set the owner of a chunk
        /// </summary>
        /// <param name="pID"></param>
        /// <param name="overwrite"></param>
        /// <returns></returns>
        public bool setOwner(NetworkID pID, bool overwrite = false)
        {
            if(owned == true)
            {
                if(overwrite == false)
                {
                    return false;
                } else
                {
                   
                    playerID = pID;
                    ownerHistory.Add(pID);
                    return true;
                }
            } else
            {
                owned = true;
                playerID = pID;
                ownerHistory.Add(pID);
                return true;
            }
        }

        /// <summary>
        /// Get the owner of the chunk
        /// </summary>
        /// <returns></returns>
        public NetworkID getOwner()
        {
            return playerID;
        }

        /// <summary>
        /// Is the chunk owned
        /// </summary>
        /// <returns></returns>
        public bool hasOwner()
        {
            return owned;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool removeOwner()
        {
            owned = false;
            playerID = new NetworkID();
            return true;
        }

        public bool getSpawn()
        {
            return isSpawn;
        }
    }
}
