using System;
using System.Collections.Generic;
using System.Text;
using TT2Advisor.Common.Attributes;

namespace TT2Advisor.Common.Interfaces
{
    public interface ISkillTree
    {
        [KnightTree]
        int KnightsValor { get; }
        [KnightTree]
        int ChivalricOrder { get; set; }
        [KnightTree]
        int PetEvolution { get; set; }
        [KnightTree]
        int HeartofMidas { get; set; }
        [KnightTree]
        int CleavingStrike { get; set; }
        [KnightTree]
        int SummonInferno { get; set; }
        [KnightTree]
        int LightningBurst { get; set; }
        [KnightTree]
        int BarbaricFury { get; set; }
        [KnightTree]
        int VolcanicSupremacy { get; set; }
        [KnightTree]
        int FlashZip { get; set; }

        [WarlordTree]
        int MasterCommander { get; set; }
        [WarlordTree]
        int SpoilsofWar { get; set; }
        [WarlordTree]
        int HeroicMight { get; set; }
        [WarlordTree]
        int AerialAssault { get; set; }
        [WarlordTree]
        int TacticalInsight { get; set; }
        [WarlordTree]
        int SearingLight { get; set; }
        [WarlordTree]
        int CoordinatedOffensive { get; set; }
        [WarlordTree]
        int AstralAwakening { get; set; }
        [WarlordTree]
        int CommandSupremacy { get; set; }
        [WarlordTree]
        int AnchoringShot { get; set; }

        [SorcererTree]
        int LimitBreak { get; set; }
        [SorcererTree]
        int MidasUltimate { get; set; }
        [SorcererTree]
        int AngelicRadiance { get; set; }
        [SorcererTree]
        int PhantomVengeance { get; set; }
        [SorcererTree]
        int FairyCharm { get; set; }
        [SorcererTree]
        int ManaSiphon { get; set; }
        [SorcererTree]
        int EternalDarkness { get; set; }
        [SorcererTree]
        int ManniMana { get; set; }
        [SorcererTree]
        int LightningStrike { get; set; }
        [SorcererTree]
        int DimensionalShift { get; set; }

        [RogueTree]
        int MasterThief { get; set; }
        [RogueTree]
        int Ambush { get; set; }
        [RogueTree]
        int Assassinate { get; set; }
        [RogueTree]
        int SummonDagger { get; set; }
        [RogueTree]
        int StrokeOfLuck { get; set; }
        [RogueTree]
        int DaggerStorm { get; set; }
        [RogueTree]
        int Cloaking { get; set; }
        [RogueTree]
        int ForbiddenContract { get; set; }
        [RogueTree]
        int PoisonEdge { get; set; }
        [RogueTree]
        int DeadlyFocus { get; set; }
    }
}
