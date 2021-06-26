using System;
using TT2Advisor.Import;

namespace TT2Advisor.PlayerBuild
{
    public class PlayerStats
    {
        //public PlayerStats(JToken playerStatsToken)
        //{
        //    MaxPrestigeStage = (int)playerStatsToken.SelectToken("['Max Prestige Stage']");
        //    ArtifactsCollected = (int)playerStatsToken.SelectToken("['Artifacts Collected']");
        //    CraftingPower = (int)playerStatsToken.SelectToken("['Crafting Power']");
        //    TotalPetLevels = (int)playerStatsToken.SelectToken("['Total Pet Levels']");
        //    SkillPointsOwned = (int)playerStatsToken.SelectToken("['Skill Points Owned']");
        //    HeroWeaponUpgrades = (int)playerStatsToken.SelectToken("['Hero Weapon Upgrades']");
        //    HeroScrollUpgrades = (int)playerStatsToken.SelectToken("['Hero Scroll Upgrades']");
        //    TournamentsJoined = (int)playerStatsToken.SelectToken("['Tournaments Joined']");
        //    UndisputedWins = (int)playerStatsToken.SelectToken("['Undisputed Wins']");
        //    TournamentPoints = (int)playerStatsToken.SelectToken("['Tournament Points']");
        //    LifetimeRelics = (double)playerStatsToken.SelectToken("['Lifetime Relics']");
        //}

        public PlayerStats(Import.PlayerStats playerStats)
        {
            MaxPrestigeStage = playerStats.MaxPrestigeStage.ToInt(); // (int)playerStatsToken.SelectToken("['Max Prestige Stage']".GetInt();
            ArtifactsCollected = playerStats.ArtifactsCollected.ToInt(); // (int)playerStatsToken.SelectToken("['Artifacts Collected']".GetInt();
            CraftingPower = playerStats.CraftingPower.ToInt(); // (int)playerStatsToken.SelectToken("['Crafting Power']".GetInt();
            TotalPetLevels = playerStats.TotalPetLevels.ToInt(); // (int)playerStatsToken.SelectToken("['Total Pet Levels']".GetInt();
            SkillPointsOwned = playerStats.SkillPointsOwned.ToInt(); // (int)playerStatsToken.SelectToken("['Skill Points Owned']".GetInt();
            HeroWeaponUpgrades = playerStats.HeroWeaponUpgrades.ToInt(); // (int)playerStatsToken.SelectToken("['Hero Weapon Upgrades']".GetInt();
            HeroScrollUpgrades = playerStats.HeroScrollUpgrades.ToInt(); // (int)playerStatsToken.SelectToken("['Hero Scroll Upgrades']".GetInt();
            TournamentsJoined = playerStats.TournamentsJoined.ToInt(); // (int)playerStatsToken.SelectToken("['Tournaments Joined']".GetInt();
            UndisputedWins = playerStats.UndisputedWins.ToInt(); // (int)playerStatsToken.SelectToken("['Undisputed Wins']".GetInt();
            TournamentPoints = playerStats.TournamentPoints.ToInt(); // (int)playerStatsToken.SelectToken("['Tournament Points']".GetInt();
            LifetimeRelics = playerStats.LifetimeRelics.ToDouble(); // (double)playerStatsToken.SelectToken("['Lifetime Relics']");
        }

        public int MaxPrestigeStage { get; set; }
        public int ArtifactsCollected { get; set; }
        public int CraftingPower { get; set; }
        public int TotalPetLevels { get; set; }
        public int SkillPointsOwned { get; set; }
        public int HeroWeaponUpgrades { get; set; }
        public int HeroScrollUpgrades { get; set; }
        public int TournamentsJoined { get; set; }
        public int UndisputedWins { get; set; }
        public int TournamentPoints { get; set; }
        public double LifetimeRelics { get; set; }
    }
}
