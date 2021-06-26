using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TT2Advisor.Import;

namespace TT2Advisor.PlayerBuild
{
    public class RaidStats
    {
        //public RaidStats(JToken raidStatsToken)
        //{
        //    RaidLevel = (int)raidStatsToken.SelectToken("['Raid Level']");
        //    RaidDamage = (int)raidStatsToken.SelectToken("['Raid Damage']");
        //    TotalRaidExperience = (int)raidStatsToken.SelectToken("['Total Raid Experience']");
        //    TotalRaidAttacks = (int)raidStatsToken.SelectToken("['Total Raid Attacks']");
        //    TotalRaidCardLevels = (int)raidStatsToken.SelectToken("['Total Raid Card Levels']");
        //    RaidCardsOwned = (int)raidStatsToken.SelectToken("['Raid Cards Owned']");
        //    LifetimeClanMorale = (int)raidStatsToken.SelectToken("['Lifetime Clan Morale']");
        //}

        public RaidStats(Import.RaidStats raidStats)
        {
            RaidLevel = raidStats.RaidLevel.ToInt();
            RaidDamage = raidStats.RaidDamage.ToInt();
            TotalRaidExperience = raidStats.TotalRaidExperience.ToInt();
            TotalRaidAttacks = raidStats.TotalRaidAttacks.ToInt();
            TotalRaidCardLevels = raidStats.TotalRaidCardLevels.ToInt();
            RaidCardsOwned = raidStats.RaidCardsOwned.ToInt();
            LifetimeClanMorale = raidStats.LifetimeClanMorale.ToInt();
        }

        public int RaidLevel { get; set; }
        public int RaidDamage { get; set; }
        public int TotalRaidExperience { get; set; }
        public int TotalRaidAttacks { get; set; }
        public int TotalRaidCardLevels { get; set; }
        public int RaidCardsOwned { get; set; }
        public int LifetimeClanMorale { get; set; }
    }
}
