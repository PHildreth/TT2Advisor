using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Common.Interfaces;
using TT2Advisor.RaidCards;
using static TT2Advisor.RaidCards.RaidCardsRepo;

namespace TT2Advisor.PlayerBuild
{
    public class RaidCards
    {
        //public RaidCards(JToken raidCardsToken)
        //{
        //    MoonBeam = new MoonBeam(raidCardsToken.SelectToken("['Moon Beam']"));
        //    RazorWind = new RazorWind(raidCardsToken.SelectToken("['Razor Wind']"));
        //}

        public RaidCards(Import.RaidCards raidCards)
        {
            MoonBeam = raidCards.MoonBeam;
            Fragmentize = raidCards.Fragmentize;
            SkullBash = raidCards.SkullBash;
            RazorWind = raidCards.RazorWind;
            WhipofLightning = raidCards.WhipofLightning;
            ClanshipBarrage = raidCards.ClanshipBarrage;
            PurifyingBlast = raidCards.PurifyingBlast;
            PsychicChain = raidCards.PsychicChain;
            FlakShot = raidCards.FlakShot;
            CosmicHaymaker = raidCards.CosmicHaymaker;
            BlazingInferno = raidCards.BlazingInferno;
            AcidDrench = raidCards.AcidDrench;
            DecayingStrike = raidCards.DecayingStrike;
            FusionBomb = raidCards.FusionBomb;
            GrimShadow = raidCards.GrimShadow;
            ThrivingPlague = raidCards.ThrivingPlague;
            Radioactivity = raidCards.Radioactivity;
            RavenousSwarm = raidCards.RavenousSwarm;
            Maelstrom = raidCards.Maelstrom;
            CrushingInstinct = raidCards.CrushingInstinct;
            InsanityVoid = raidCards.InsanityVoid;
            RancidGas = raidCards.RancidGas;
            InspiringForce = raidCards.InspiringForce;
            SoulFire = raidCards.SoulFire;
            VictoryMarch = raidCards.VictoryMarch;
            PrismaticRift = raidCards.PrismaticRift;
            AncestralFavor = raidCards.AncestralFavor;
            GraspingVines = raidCards.GraspingVines;
            TotemofPower = raidCards.TotemofPower;

        }

        public IRaidCard MoonBeam { get; set; }
        public IRaidCard Fragmentize { get; set; }
        public IRaidCard SkullBash { get; set; }
        public IRaidCard RazorWind { get; set; }
        public IRaidCard WhipofLightning { get; set; }
        public IRaidCard ClanshipBarrage { get; set; }
        public IRaidCard PurifyingBlast { get; set; }
        public IRaidCard PsychicChain { get; set; }
        public IRaidCard FlakShot { get; set; }
        public IRaidCard CosmicHaymaker { get; set; }
        public IRaidCard BlazingInferno { get; set; }
        public IRaidCard AcidDrench { get; set; }
        public IRaidCard DecayingStrike { get; set; }
        public IRaidCard FusionBomb { get; set; }
        public IRaidCard GrimShadow { get; set; }
        public IRaidCard ThrivingPlague { get; set; }
        public IRaidCard Radioactivity { get; set; }
        public IRaidCard RavenousSwarm { get; set; }
        public IRaidCard Maelstrom { get; set; }
        public IRaidCard CrushingInstinct { get; set; }
        public IRaidCard InsanityVoid { get; set; }
        public IRaidCard RancidGas { get; set; }
        public IRaidCard InspiringForce { get; set; }
        public IRaidCard SoulFire { get; set; }
        public IRaidCard VictoryMarch { get; set; }
        public IRaidCard PrismaticRift { get; set; }
        public IRaidCard AncestralFavor { get; set; }
        public IRaidCard GraspingVines { get; set; }
        public IRaidCard TotemofPower { get; set; }
    }
}
