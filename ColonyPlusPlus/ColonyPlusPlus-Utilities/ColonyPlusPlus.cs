using static Players;
using System;

namespace ColonyPlusPlusUtilities
{
    [ModLoader.ModManager]
    public class ColonyPlusPlus
    {
        private static long nextMillisecondUpdate = 0;
        private static long nextMillisecondUpdateLong = 0;
        public static long nextMillisecondUpdateRotator = 0;
        private static long millisecondDelta = 500;
        public static long millisecondDeltaRotator = 0;

        private static bool ColonyLimitEnabled = false;
        private static int ColonyLimit = 0;
        private static int plyID = 0;
        public static Version modVersion = new Version(0, 2, 0);


        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "colonyplusplus.AfterStartup")]
        [ModLoader.ModCallbackProvidesFor("colonyapi.AfterStartup")]
        public static void AfterStartup()
        {
            Pipliz.Log.Write("<b><color=yellow>Loaded ColonyPlusPlus v" + modVersion.ToString() + "</color></b>");
            ColonyAPI.Managers.VersionManager.runVersionCheck("ColonyPlusPlusUtilities", modVersion);

            // Initialise configuration
            Managers.RotatingMessageManager.initialise();
            Managers.BanManager.initialise();
            

            ColonyLimitEnabled = ColonyAPI.Managers.ConfigManager.getConfigBoolean("colony.enabled");
            if(ColonyLimitEnabled)
            {
                ColonyLimit = ColonyAPI.Managers.ConfigManager.getConfigInt("colony.limit");
            }

            // Initialize chat commands
            Managers.ChatCommandManager.Initialize();

           
            
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerConnectedLate, "colonyplusplus.OnPlayerConnectedLate")]
        public static void OnPlayerConnectedLate(Player p)
        {
            if (p.ID.steamID.m_SteamID == 0)
            {
                ColonyAPI.Helpers.Chat.sendSilent(p, ColonyAPI.Managers.VersionManager.SinglePlayerrunVersionCheck(modVersion), ColonyAPI.Helpers.Chat.ChatColour.red);
            }
            else
            {
                ColonyAPI.Helpers.Chat.sendSilent(p, ColonyAPI.Managers.ConfigManager.getConfigString("motd.message"));
                ColonyAPI.Helpers.Chat.sendSilent(p, "The server is using ColonyPlusPlus v" + modVersion.ToString());
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes, "colonyplusplus.AfterAddingBaseTypes")]
        public static void AfterAddingBaseTypes()
        {
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesServer, "colonyplusplus.AfterItemTypesServer" )]
        public static void AfterItemTypesServer()
        {

            // Register our chat parser
            ChatCommands.CommandManager.RegisterCommand(new Managers.ChatManager());

            // Register Master Command
            ChatCommands.CommandManager.RegisterCommand(new Managers.MasterChatCommandManager());
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad, "colonyplusplus.AfterWorldLoad")]
        public static void AfterWorldLoad()
        {
            Managers.WorldManager.LoadJSON();
            Managers.WorldManager.SetupSpawn();

            //Classes.BlockJobs.BlockJobManagerTracker.AfterWorldLoad();
        }

        // things to do every tick (or itnerval)
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnUpdate, "colonyplusplus.OnUpdate")]
        public static void OnUpdate()
        {
            if(Pipliz.Time.MillisecondsSinceStart > nextMillisecondUpdate)
            {
                if(ColonyLimitEnabled)
                {
                    if (plyID >= Players.CountConnected)
                    {
                        plyID = 0;
                    }
                    if(Players.CountConnected != 0)
                    {
                        Colony col = Colony.Get(Players.GetConnectedByIndex(plyID));
                        if (col.FollowerCount > ColonyLimit)
                        {
                            col.TakeMonsterHit(10000000, 1000000);
                        }
                        plyID++;
                    }
                }
                
                // Do player update stuff
                Managers.PlayerManager.notifyNewChunkEntrances();

                // set the next update time!
                nextMillisecondUpdate = Pipliz.Time.MillisecondsSinceStart + millisecondDelta;
            }

            // run the rotator
            Managers.RotatingMessageManager.doRun();

        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnQuitEarly, "colonyplusplus.OnQuitEarly")]
        public static void OnQuitEarly()
        {
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnQuit, "colonyplusplus.OnQuit")]
        public static void OnQuit()
        {
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterDefiningNPCTypes, "colonyplusplus.AfterDefiningNPCTypes")]
        public static void AfterDefiningNPCTypes()
        {
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, "colonyplusplus.AfterItemTypesDefined")]
        public static void AfterItemTypesDefined()
        {
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnTryChangeBlockUser, "colonyplusplus.OnTryChangeBlockUser")]
        public static bool OnTryChangeBlockUser(ModLoader.OnTryChangeBlockUserData d)
        {

            if (d.requestedBy.ID.steamID.m_SteamID == 0)
            {
                return true;
            }
            bool allowed = Managers.WorldManager.AllowPlaceBlock(d);

            //Chat.Send(Players.GetPlayer(d.requestedBy.ID), "Block place allowed: " + allowed);
            return allowed;
        }
    }
}