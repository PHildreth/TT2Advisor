using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TT2Advisor.Common.Enums;
using TT2Advisor.Common.Helpers;
using TT2Advisor.Common.Interfaces;

namespace TT2Advisor.RaidCards
{
    public class RaidCardsRepo
    {
        public class MoonBeam : RaidCard
        {
            public MoonBeam(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.MoonBeam;
            }
        }
        public class Fragmentize : RaidCard
        {
            public Fragmentize(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.Fragmentize;
            }
        }

        public class SkullBash : RaidCard
        {
            public SkullBash(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.SkullBash;
            }
        }

        public class RazorWind : RaidCard
        {
            public RazorWind(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.RazorWind;
            }
        }

        public class WhipofLightning : RaidCard
        {
            public WhipofLightning(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.WhipofLightning;
            }
        }

        public class ClanshipBarrage : RaidCard
        {
            public ClanshipBarrage(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.ClanshipBarrage;
            }
        }

        public class PurifyingBlast : RaidCard
        {
            public PurifyingBlast(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.PurifyingBlast;
            }
        }

        public class PsychicChain : RaidCard
        {
            public PsychicChain(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.PsychicChain;
            }
        }

        public class FlakShot : RaidCard
        {
            public FlakShot(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.FlakShot;
            }
        }

        public class CosmicHaymaker : RaidCard
        {
            public CosmicHaymaker(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.CosmicHaymaker;
            }
        }

        public class BlazingInferno : RaidCard
        {
            public BlazingInferno(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.BlazingInferno;
            }
        }

        public class AcidDrench : RaidCard
        {
            public AcidDrench(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.AcidDrench;
            }
        }

        public class DecayingStrike : RaidCard
        {
            public DecayingStrike(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.DecayingStrike;
            }
        }

        public class FusionBomb : RaidCard
        {
            public FusionBomb(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.FusionBomb;
            }
        }

        public class GrimShadow : RaidCard
        {
            public GrimShadow(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.GrimShadow;
            }
        }

        public class ThrivingPlague : RaidCard
        {
            public ThrivingPlague(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.ThrivingPlague;
            }
        }

        public class Radioactivity : RaidCard
        {
            public Radioactivity(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.Radioactivity;
            }
        }

        public class RavenousSwarm : RaidCard
        {
            public RavenousSwarm(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.RavenousSwarm;
            }
        }

        public class Maelstrom : RaidCard
        {
            public Maelstrom(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.Maelstrom;
            }
        }

        public class CrushingInstinct : RaidCard
        {
            public CrushingInstinct(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.CrushingInstinct;
            }
        }

        public class InsanityVoid : RaidCard
        {
            public InsanityVoid(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.InsanityVoid;
            }
        }

        public class RancidGas : RaidCard
        {
            public RancidGas(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.RancidGas;
            }
        }

        public class InspiringForce : RaidCard
        {
            public InspiringForce(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.InspiringForce;
            }
        }

        public class SoulFire : RaidCard
        {
            public SoulFire(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.SoulFire;
            }
        }

        public class VictoryMarch : RaidCard
        {
            public VictoryMarch(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.VictoryMarch;
            }
        }

        public class PrismaticRift : RaidCard
        {
            public PrismaticRift(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.PrismaticRift;
            }
        }

        public class AncestralFavor : RaidCard
        {
            public AncestralFavor(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.AncestralFavor;
            }
        }

        public class GraspingVines : RaidCard
        {
            public GraspingVines(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.GraspingVines;
            }
        }

        public class TotemofPower : RaidCard
        {
            public TotemofPower(IRaidCard importRaidCard) : base(importRaidCard)
            {
                RaidCardType = RaidCardTypeEnum.TotemofPower;
            }
        }
    }
}
