using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TT2Advisor.Common.Interfaces;
using TT2Advisor.SkillTree;

namespace TT2Advisor.PlayerBuild
{
    public class SkillTree
    {
        public SkillTree(Import.SkillTree skillTree)
        {
            // Knight Tree
            KnightsValor = new KnightsValor(skillTree.KnightsValor);
            ChivalricOrder = new ChivalricOrder(skillTree.ChivalricOrder);
            AngelicRadiance = new AngelicRadiance(skillTree.AngelicRadiance);
            MidasUltimate = new MidasUltimate(skillTree.MidasUltimate);
            CleavingStrike = new CleavingStrike(skillTree.CleavingStrike);
            Rejuvenation = new Rejuvenation(skillTree.Rejuvenation);
            WillOfMidas = new WillOfMidas(skillTree.WillOfMidas);
            BarbaricFury = new BarbaricFury(skillTree.BarbaricFury);
            DivineWrath = new DivineWrath(skillTree.DivineWrath);
            FairyCharm = new FairyCharm(skillTree.FairyCharm);

            // Summoner Tree
            PetEvolution = new PetEvolution(skillTree.PetEvolution);
            SummonInferno = new SummonInferno(skillTree.SummonInferno);
            HeartofMidas = new HeartofMidas(skillTree.HeartofMidas);
            CompanionWarfare = new CompanionWarfare(skillTree.CompanionWarfare);
            EmberArts = new EmberArts(skillTree.EmberArts);
            LightningBurst = new LightningBurst(skillTree.LightningBurst);
            SummoningCircle = new SummoningCircle(skillTree.SummoningCircle);
            VolcanicEruption = new VolcanicEruption(skillTree.VolcanicEruption);
            FlashZip = new FlashZip(skillTree.FlashZip);
            BurningPassion = new BurningPassion(skillTree.BurningPassion);

            // Warlord Tree
            MasterCommander = new MasterCommander(skillTree.MasterCommander);
            SpoilsofWar = new SpoilsofWar(skillTree.SpoilsofWar);
            HeroicMight = new HeroicMight(skillTree.HeroicMight);
            AerialAssault = new AerialAssault(skillTree.AerialAssault);
            TacticalInsight = new TacticalInsight(skillTree.TacticalInsight);
            SearingLight = new SearingLight(skillTree.SearingLight);
            CoordinatedOffensive = new CoordinatedOffensive(skillTree.CoordinatedOffensive);
            AstralAwakening = new AstralAwakening(skillTree.AstralAwakening);
            CommandSupremacy = new CommandSupremacy(skillTree.CommandSupremacy);
            AnchoringShot = new AnchoringShot(skillTree.AnchoringShot);

            // Sorcerer Tree
            PhantomVengeance = new PhantomVengeance(skillTree.PhantomVengeance);
            LimitBreak = new LimitBreak(skillTree.LimitBreak);
            EternalDarkness = new EternalDarkness(skillTree.EternalDarkness);
            ManaSiphon = new ManaSiphon(skillTree.ManaSiphon);
            ManniMana = new ManniMana(skillTree.ManniMana);
            DimensionalShift = new DimensionalShift(skillTree.DimensionalShift);
            LightningStrike = new LightningStrike(skillTree.LightningStrike);
            ForbiddenContract = new ForbiddenContract(skillTree.ForbiddenContract);

            // Rogue Tree
            MasterThief = new MasterThief(skillTree.MasterThief);
            Assassinate = new Assassinate(skillTree.Assassinate);
            SummonDagger = new SummonDagger(skillTree.SummonDagger);
            Ambush = new Ambush(skillTree.Ambush);
            StrokeOfLuck = new StrokeOfLuck(skillTree.StrokeOfLuck);
            PoisonEdge = new PoisonEdge(skillTree.PoisonEdge);
            Cloaking = new Cloaking(skillTree.Cloaking);
            DaggerStorm = new DaggerStorm(skillTree.DaggerStorm);
            DeadlyFocus = new DeadlyFocus(skillTree.DeadlyFocus);

        }

        // Knight Tree
        public KnightsValor KnightsValor { get; set; }
        public ChivalricOrder ChivalricOrder { get; set; }
        public AngelicRadiance AngelicRadiance { get; set; }
        public MidasUltimate MidasUltimate { get; set; }
        public CleavingStrike CleavingStrike { get; set; }
        public Rejuvenation Rejuvenation { get; set; }
        public WillOfMidas WillOfMidas { get; set; }
        public BarbaricFury BarbaricFury { get; set; }
        public DivineWrath DivineWrath { get; set; }
        public FairyCharm FairyCharm { get; set; }

        // Summoner Tree
        public PetEvolution PetEvolution { get; set; }
        public SummonInferno SummonInferno { get; set; }
        public HeartofMidas HeartofMidas { get; set; }
        public CompanionWarfare CompanionWarfare { get; set; }
        public EmberArts EmberArts { get; set; }
        public LightningBurst LightningBurst { get; set; }
        public SummoningCircle SummoningCircle { get; set; }
        public VolcanicEruption VolcanicEruption { get; set; }
        public FlashZip FlashZip { get; set; }
        public BurningPassion BurningPassion { get; set; }
        
        // Warlord Tree
        public MasterCommander MasterCommander { get; set; }
        public SpoilsofWar SpoilsofWar { get; set; }
        public HeroicMight HeroicMight { get; set; }
        public AerialAssault AerialAssault { get; set; }
        public TacticalInsight TacticalInsight { get; set; }
        public SearingLight SearingLight { get; set; }
        public CoordinatedOffensive CoordinatedOffensive { get; set; }
        public AstralAwakening AstralAwakening { get; set; }
        public CommandSupremacy CommandSupremacy { get; set; }
        public AnchoringShot AnchoringShot { get; set; }

        // Sorcerer Tree
        public PhantomVengeance PhantomVengeance { get; set; }
        public LimitBreak LimitBreak { get; set; }
        public EternalDarkness EternalDarkness { get; set; }
        public ManaSiphon ManaSiphon { get; set; }
        public ManniMana ManniMana { get; set; }
        public DimensionalShift DimensionalShift { get; set; }
        public LightningStrike LightningStrike { get; set; }
        public ForbiddenContract ForbiddenContract { get; set; }

        // Rogue Tree
        public MasterThief MasterThief { get; set; }
        public Ambush Ambush { get; set; }
        public Assassinate Assassinate { get; set; }
        public SummonDagger SummonDagger { get; set; }
        public StrokeOfLuck StrokeOfLuck { get; set; }
        public DaggerStorm DaggerStorm { get; set; }
        public Cloaking Cloaking { get; set; }
        public PoisonEdge PoisonEdge { get; set; }
        public DeadlyFocus DeadlyFocus { get; set; }

    }
}
