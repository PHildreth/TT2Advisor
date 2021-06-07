using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.PlayerBuild
{
    public class SplashStats
    {
        public SplashStats(JToken splashStatsToken)
        {
            SplashDamage = (double)splashStatsToken.SelectToken("['Splash Damage']");
            BaseMaxSplashCount = (int)splashStatsToken.SelectToken("['Base Max Splash Count']");
            AllSplashSkip = (decimal)splashStatsToken.SelectToken("['All Splash Skip']");
            HeavenlyStrikeSplashCount = (int)splashStatsToken.SelectToken("['Heavenly Strike Splash Count']");
            LightningBurstSplashCount = (int)splashStatsToken.SelectToken("['Lightning Burst Splash Count']");
            ClanShipSplashCount = (int)splashStatsToken.SelectToken("['Clan Ship Splash Count']");
            DaggerSplashCount = (int)splashStatsToken.SelectToken("['Dagger Splash Count']");
            HeavenlyStrikeSplashSkip = (decimal)splashStatsToken.SelectToken("['Heavenly Strike Splash Skip']");
            PetSplashSkip = (decimal)splashStatsToken.SelectToken("['Pet Splash Skip']");
            ClanShipSplashSkip = (decimal)splashStatsToken.SelectToken("['Clan Ship Splash Skip']");
            ShadowCloneSplashSkip = (decimal)splashStatsToken.SelectToken("['Shadow Clone Splash Skip']");
            DaggerSplashSkip = (decimal)splashStatsToken.SelectToken("['Dagger Splash Skip']");
        }

        public double SplashDamage { get; set; }
        public int BaseMaxSplashCount { get; set; }
        public decimal AllSplashSkip { get; set; }
        public int HeavenlyStrikeSplashCount { get; set; }
        public int LightningBurstSplashCount { get; set; }
        public int ClanShipSplashCount { get; set; }
        public int DaggerSplashCount { get; set; }
        public decimal HeavenlyStrikeSplashSkip { get; set; }
        public decimal PetSplashSkip { get; set; }
        public decimal ClanShipSplashSkip { get; set; }
        public decimal ShadowCloneSplashSkip { get; set; }
        public decimal DaggerSplashSkip { get; set; }
    }
}
