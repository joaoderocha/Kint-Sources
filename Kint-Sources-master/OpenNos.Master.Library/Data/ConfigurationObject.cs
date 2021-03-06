﻿using System;

namespace OpenNos.Master.Library.Data
{
    [Serializable]
    public class ConfigurationObject
    {
        public string Act4IP { get; set; }

        public int Act4Port { get; set; }

        public int SessionLimit { get; set; }

        public bool SceneOnCreate { get; set; }

        public bool WorldInformation { get; set; }

        public int RateXP { get; set; }

        public  int HeroXpRate { get; set; }

        public int RatePrestigeXP { get; set; }

        public int RateGold { get; set; }

        public int RateGoldDrop { get; set; }

        public long MaxGold { get; set; }

        public int RateDrop { get; set; }

        public byte MaxLevel { get; set; }

        public byte MaxJobLevel { get; set; }

        public byte MaxHeroLevel { get; set; }

        public byte MaxPrestigeLevel { get; set; }

        public byte HeroicStartLevel { get; set; }

        public byte PrestigeStartLevel { get; set; }

        public byte MaxSPLevel { get; set; }

        public int RateFairyXP { get; set; }

        public byte MaxUpgrade { get; set; }

        public string MallBaseURL { get; set; }

        public string MallAPIKey { get; set; }

        public bool UseChatLogService { get; set; }

        public int PerfectionRate { get; set; }

        public int ReputRate { get; set; }

        public long MaxBankGold { get; set; }

        public bool LodTimes { get; set; }

        public byte MinLodLevel { get; set; }

        public int FamilyXpRate { get; set; }
    }
}
