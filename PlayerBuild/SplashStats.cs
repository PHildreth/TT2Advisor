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
