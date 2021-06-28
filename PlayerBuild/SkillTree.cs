using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TT2Advisor.Common.Interfaces;
using TT2Advisor.SkillTree;
using TT2Advisor.SkillTree.Knight;
using TT2Advisor.SkillTree.Warlord;

namespace TT2Advisor.PlayerBuild
{
    public class SkillTree
    {
        //public SkillTree(JToken jToken)
        //{
        //    KnightTree = new KnightTree(jToken);
        //    //WarlordTree = new WarlordTree(jToken);
        //    //SorcererTree = new SorcererTree(jToken);
        //    //RogueTree = new RogueTree(jToken);
        //}

        public SkillTree(Import.SkillTree skillTree)
        {
            KnightsValor = new KnightsValor(skillTree.KnightsValor);
            ChivalricOrder = new ChivalricOrder(skillTree.ChivalricOrder);
            PetEvolution = new PetEvolution(skillTree.PetEvolution);
            HeartofMidas = new HeartofMidas(skillTree.HeartofMidas);
            CleavingStrike = new CleavingStrike(skillTree.CleavingStrike);
            SummonInferno = new SummonInferno(skillTree.SummonInferno);
            LightningBurst = new LightningBurst(skillTree.LightningBurst);
            BarbaricFury = new BarbaricFury(skillTree.BarbaricFury);
            VolcanicSupremacy = new VolcanicSupremacy(skillTree.VolcanicSupremacy);
            FlashZip = new FlashZip(skillTree.FlashZip);

            MasterCommander = new MasterCommander(skillTree.MasterCommander);
            SpoilsofWar = new SpoilsofWar(skillTree.SpoilsofWar);
            //HeroicMight = new HeroicMight(skillTree.HeroicMight);
            //AerialAssault = new AerialAssault(skillTree.AerialAssault);
            //TacticalInsight = new TacticalInsight(skillTree.TacticalInsight);
            //SearingLight = new SearingLight(skillTree.SearingLight);
            //CoordinatedOffensive = new CoordinatedOffensive(skillTree.CoordinatedOffensive);
            //AstralAwakening = new AstralAwakening(skillTree.AstralAwakening);
            //CommandSupremacy = new CommandSupremacy(skillTree.CommandSupremacy);
            //AnchoringShot = new AnchoringShot(skillTree.AnchoringShot);

            //LimitBreak = new LimitBreak(skillTree.LimitBreak);
            //MidasUltimate = new MidasUltimate(skillTree.MidasUltimate);
            //AngelicRadiance = new AngelicRadiance(skillTree.AngelicRadiance);
            //PhantomVengeance = new PhantomVengeance(skillTree.PhantomVengeance);
            //FairyCharm = new FairyCharm(skillTree.FairyCharm);
            //ManaSiphon = new ManaSiphon(skillTree.ManaSiphon);
            //EternalDarkness = new EternalDarkness(skillTree.EternalDarkness);
            //ManniMana = new ManniMana(skillTree.ManniMana);
            //LightningStrike = new LightningStrike(skillTree.LightningStrike);
            //DimensionalShift = new DimensionalShift(skillTree.DimensionalShift);
            //DivineSupremacey = new DivineSupremacey(skillTree.DivineSupremacey);
            //PhantomSupremacy = new PhantomSupremacy(skillTree.PhantomSupremacy);

            //MasterThief = new MasterThief(skillTree.MasterThief);
            //Ambush = new Ambush(skillTree.Ambush);
            //Assassinate = new Assassinate(skillTree.Assassinate);
            //SummonDagger = new SummonDagger(skillTree.SummonDagger);
            //StrokeOfLuck = new StrokeOfLuck(skillTree.StrokeOfLuck);
            //DaggerStorm = new DaggerStorm(skillTree.DaggerStorm);
            //Cloaking = new Cloaking(skillTree.Cloaking);
            //ForbiddenContract = new ForbiddenContract(skillTree.ForbiddenContract);
            //PoisonEdge = new PoisonEdge(skillTree.PoisonEdge);
            //DeadlyFocus = new DeadlyFocus(skillTree.DeadlyFocus);

        }

        public Skill KnightsValor { get; set; }
        public Skill ChivalricOrder { get; set; }
        public Skill PetEvolution { get; set; }
        public Skill HeartofMidas { get; set; }
        public Skill CleavingStrike { get; set; }
        public Skill SummonInferno { get; set; }
        public Skill LightningBurst { get; set; }
        public Skill BarbaricFury { get; set; }
        public Skill VolcanicSupremacy { get; set; }
        public Skill FlashZip { get; set; }

        public Skill MasterCommander { get; set; }
        public Skill SpoilsofWar { get; set; }
        public Skill HeroicMight { get; set; }
        public Skill AerialAssault { get; set; }
        public Skill TacticalInsight { get; set; }
        public Skill SearingLight { get; set; }
        public Skill CoordinatedOffensive { get; set; }
        public Skill AstralAwakening { get; set; }
        public Skill CommandSupremacy { get; set; }
        public Skill AnchoringShot { get; set; }

        public Skill LimitBreak { get; set; }
        public Skill MidasUltimate { get; set; }
        public Skill AngelicRadiance { get; set; }
        public Skill PhantomVengeance { get; set; }
        public Skill FairyCharm { get; set; }
        public Skill ManaSiphon { get; set; }
        public Skill EternalDarkness { get; set; }
        public Skill ManniMana { get; set; }
        public Skill LightningStrike { get; set; }
        public Skill DimensionalShift { get; set; }
        public Skill DivineSupremacy { get; set; }
        public Skill PhantomSupremacy { get; set; }

        public Skill MasterThief { get; set; }
        public Skill Ambush { get; set; }
        public Skill Assassinate { get; set; }
        public Skill SummonDagger { get; set; }
        public Skill StrokeOfLuck { get; set; }
        public Skill DaggerStorm { get; set; }
        public Skill Cloaking { get; set; }
        public Skill ForbiddenContract { get; set; }
        public Skill PoisonEdge { get; set; }
        public Skill DeadlyFocus { get; set; }
    }
}
