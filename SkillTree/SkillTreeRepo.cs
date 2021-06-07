using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static TT2Advisor.SkillTree.SkillsRepo;

namespace TT2Advisor.SkillTree
{
    public class SkillTreeRepo
    {
        public class KnightTree : ISkillTree
        {
            public SkillTreeTypeEnum SkillTreeType => SkillTreeTypeEnum.Knight;
            public Skill<KnightsValor> KnightsValor { get; set; }
            public Skill<Chivalricrder> ChivalricOrder { get; set; }
            //public Skill<PetEvolution> PetEvolution { get; set; }
            //public Skill<HeartfMidas> HeartofMidas { get; set; }
            //public Skill<CleavingStrike> CleavingStrike { get; set; }
            //public Skill<SummonInferno> SummonInferno { get; set; }
            //public Skill<LightningBurst> LightningBurst { get; set; }
            //public Skill<BarbaricFury> BarbaricFury { get; set; }
            //public Skill<VolcanicSupremacy> VolcanicSupremacy { get; set; }
            //public Skill<FlashZip> FlashZip { get; set; }
        }
        public class WarlordTree
        {
            public SkillTreeTypeEnum SkillTreeType => SkillTreeTypeEnum.Warlord;
            //"Master Commander": 15,
            //"Spoils of War": 14,
            //"Heroic Might": 15,
            //"Aerial Assault": 14,
            //"Tactical Insight": 15,
            //"Searing Light": 15,
            //"Coordinated Offensive": 16,
            //"Astral Awakening": 0,
            //"Command Supremacy": 15,
            //"Anchoring Shot": 15,
        }
        public class SorcererTree
        {
            public SkillTreeTypeEnum SkillTreeType => SkillTreeTypeEnum.Sorcerer;
            //"Limit Break": 2,
            //"Midas Ultimate": 13,
            //"Angelic Radiance": 0,
            //"Phantom Vengeance": 1,
            //"Fairy Charm": 10,
            //"Mana Siphon": 0,
            //"Eternal Darkness": 1,
            //"Manni Mana": 0,
            //"Lightning Strike": 0,
            //"Dimensional Shift": 9,
        }
        public class RogueTree
        {
            public SkillTreeTypeEnum SkillTreeType => SkillTreeTypeEnum.Rogue;
            //"Master Thief": 11,
            //"Ambush": 1,
            //"Assassinate": 3,
            //"Summon Dagger": 1,
            //"Stroke Of Luck": 1,
            //"Dagger Storm": 1,
            //"Cloaking": 1,
            //"Forbidden Contract": 0,
            //"Poison Edge": 19,
            //"Deadly Focus": 15
        }
    }
}
