using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TT2Advisor.Common.Interfaces;
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

        public ISkill KnightsValor { get; set; }
        public ISkill ChivalricOrder { get; set; }
        public ISkill PetEvolution { get; set; }
        public ISkill HeartofMidas { get; set; }
        public ISkill CleavingStrike { get; set; }
        public ISkill SummonInferno { get; set; }
        public ISkill LightningBurst { get; set; }
        public ISkill BarbaricFury { get; set; }
        public ISkill VolcanicSupremacy { get; set; }
        public ISkill FlashZip { get; set; }

        public ISkill MasterCommander { get; set; }
        public ISkill SpoilsofWar { get; set; }
        public ISkill HeroicMight { get; set; }
        public ISkill AerialAssault { get; set; }
        public ISkill TacticalInsight { get; set; }
        public ISkill SearingLight { get; set; }
        public ISkill CoordinatedOffensive { get; set; }
        public ISkill AstralAwakening { get; set; }
        public ISkill CommandSupremacy { get; set; }
        public ISkill AnchoringShot { get; set; }

        public ISkill LimitBreak { get; set; }
        public ISkill MidasUltimate { get; set; }
        public ISkill AngelicRadiance { get; set; }
        public ISkill PhantomVengeance { get; set; }
        public ISkill FairyCharm { get; set; }
        public ISkill ManaSiphon { get; set; }
        public ISkill EternalDarkness { get; set; }
        public ISkill ManniMana { get; set; }
        public ISkill LightningStrike { get; set; }
        public ISkill DimensionalShift { get; set; }
        public ISkill DivineSupremacy { get; set; }
        public ISkill PhantomSupremacy { get; set; }

        public ISkill MasterThief { get; set; }
        public ISkill Ambush { get; set; }
        public ISkill Assassinate { get; set; }
        public ISkill SummonDagger { get; set; }
        public ISkill StrokeOfLuck { get; set; }
        public ISkill DaggerStorm { get; set; }
        public ISkill Cloaking { get; set; }
        public ISkill ForbiddenContract { get; set; }
        public ISkill PoisonEdge { get; set; }
        public ISkill DeadlyFocus { get; set; }
    }
}
