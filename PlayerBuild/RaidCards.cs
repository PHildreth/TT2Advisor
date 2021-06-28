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
            MoonBeam = new MoonBeam(raidCards.MoonBeam);
            Fragmentize = new Fragmentize(raidCards.Fragmentize);
            SkullBash = new SkullBash(raidCards.SkullBash);
            RazorWind = new RazorWind(raidCards.RazorWind);
            WhipofLightning = new WhipofLightning(raidCards.WhipofLightning);
            ClanshipBarrage = new ClanshipBarrage(raidCards.ClanshipBarrage);
            PurifyingBlast = new PurifyingBlast(raidCards.PurifyingBlast);
            PsychicChain = new PsychicChain(raidCards.PsychicChain);
            FlakShot = new FlakShot(raidCards.FlakShot);
            CosmicHaymaker = new CosmicHaymaker(raidCards.CosmicHaymaker);
            BlazingInferno = new BlazingInferno(raidCards.BlazingInferno);
            AcidDrench = new AcidDrench(raidCards.AcidDrench);
            DecayingStrike = new DecayingStrike(raidCards.DecayingStrike);
            FusionBomb = new FusionBomb(raidCards.FusionBomb);
            GrimShadow = new GrimShadow(raidCards.GrimShadow);
            ThrivingPlague = new ThrivingPlague(raidCards.ThrivingPlague);
            Radioactivity = new Radioactivity(raidCards.Radioactivity);
            RavenousSwarm = new RavenousSwarm(raidCards.RavenousSwarm);
            Maelstrom = new Maelstrom(raidCards.Maelstrom);
            CrushingInstinct = new CrushingInstinct(raidCards.CrushingInstinct);
            InsanityVoid = new InsanityVoid(raidCards.InsanityVoid);
            RancidGas = new RancidGas(raidCards.RancidGas);
            InspiringForce = new InspiringForce(raidCards.InspiringForce);
            SoulFire = new SoulFire(raidCards.SoulFire);
            VictoryMarch = new VictoryMarch(raidCards.VictoryMarch);
            PrismaticRift = new PrismaticRift(raidCards.PrismaticRift);
            AncestralFavor = new AncestralFavor(raidCards.AncestralFavor);
            GraspingVines = new GraspingVines(raidCards.GraspingVines);
            TotemofPower = new TotemofPower(raidCards.TotemofPower);
        }

        public MoonBeam MoonBeam { get; set; }
        public Fragmentize Fragmentize { get; set; }
        public SkullBash SkullBash { get; set; }
        public RazorWind RazorWind { get; set; }
        public WhipofLightning WhipofLightning { get; set; }
        public ClanshipBarrage ClanshipBarrage { get; set; }
        public PurifyingBlast PurifyingBlast { get; set; }
        public PsychicChain PsychicChain { get; set; }
        public FlakShot FlakShot { get; set; }
        public CosmicHaymaker CosmicHaymaker { get; set; }
        public BlazingInferno BlazingInferno { get; set; }
        public AcidDrench AcidDrench { get; set; }
        public DecayingStrike DecayingStrike { get; set; }
        public FusionBomb FusionBomb { get; set; }
        public GrimShadow GrimShadow { get; set; }
        public ThrivingPlague ThrivingPlague { get; set; }
        public Radioactivity Radioactivity { get; set; }
        public RavenousSwarm RavenousSwarm { get; set; }
        public Maelstrom Maelstrom { get; set; }
        public CrushingInstinct CrushingInstinct { get; set; }
        public InsanityVoid InsanityVoid { get; set; }
        public RancidGas RancidGas { get; set; }
        public InspiringForce InspiringForce { get; set; }
        public SoulFire SoulFire { get; set; }
        public VictoryMarch VictoryMarch { get; set; }
        public PrismaticRift PrismaticRift { get; set; }
        public AncestralFavor AncestralFavor { get; set; }
        public GraspingVines GraspingVines { get; set; }
        public TotemofPower TotemofPower { get; set; }
    }
}
