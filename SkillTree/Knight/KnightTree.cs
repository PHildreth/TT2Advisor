using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json.Linq;
using TT2Advisor.SkillTree.Enums;
using TT2Advisor.Common.Interfaces;

namespace TT2Advisor.SkillTree.Knight
{
    public class KnightTree : ISkillTree
    {
        //public KnightTree(JToken knightTreeToken) { }

        public KnightTree(ISkillTree tree)
        {
            KnightsValor = new KnightsValor(tree.KnightsValor);
        }

        public SkillTreeTypeEnum SkillTreeType => SkillTreeTypeEnum.Knight;

        public KnightsValor KnightsValor { get; set; }
        public ChivalricOrder ChivalricOrder { get; set; }
        public PetEvolution PetEvolution { get; set; }
        public HeartofMidas HeartofMidas { get; set; }
        public CleavingStrike CleavingStrike { get; set; }
        public SummonInferno SummonInferno { get; set; }
        public LightningBurst LightningBurst { get; set; }
        public BarbaricFury BarbaricFury { get; set; }
        public VolcanicSupremacy VolcanicSupremacy { get; set; }
        public FlashZip FlashZip { get; set; }
        public int MasterCommander { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SpoilsofWar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HeroicMight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AerialAssault { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int TacticalInsight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SearingLight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CoordinatedOffensive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AstralAwakening { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CommandSupremacy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AnchoringShot { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int LimitBreak { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MidasUltimate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AngelicRadiance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PhantomVengeance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int FairyCharm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ManaSiphon { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int EternalDarkness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ManniMana { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int LightningStrike { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DimensionalShift { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MasterThief { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Ambush { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Assassinate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SummonDagger { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int StrokeOfLuck { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DaggerStorm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cloaking { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ForbiddenContract { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PoisonEdge { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DeadlyFocus { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        int ISkillTree.KnightsValor => throw new NotImplementedException();
        int ISkillTree.ChivalricOrder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ISkillTree.PetEvolution { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ISkillTree.HeartofMidas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ISkillTree.CleavingStrike { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ISkillTree.SummonInferno { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ISkillTree.LightningBurst { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ISkillTree.BarbaricFury { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ISkillTree.VolcanicSupremacy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int ISkillTree.FlashZip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
