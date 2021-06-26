using System;
using System.Collections.Generic;
using System.Text;
using TT2Advisor.Common.Interfaces;
using TT2Advisor.SkillTree.Enums;

namespace TT2Advisor.SkillTree.Warlord
{
    public class WarlordTree : ISkillTree
    {
        public SkillTreeTypeEnum SkillTreeType => SkillTreeTypeEnum.Warlord;

        public MasterCommander MasterCommander { get; set; }
        public SpoilsofWar SpoilsofWar { get; set; }
        //public HeroicMight HeroicMight { get; set; }
        //public AerialAssault AerialAssault { get; set; }
        //public TacticalInsight TacticalInsight { get; set; }
        //public SearingLight SearingLight { get; set; }
        //public CoordinatedOffensive CoordinatedOffensive { get; set; }
        //public AstralAwakening AstralAwakening { get; set; }
        //public CommandSupremacy CommandSupremacy { get; set; }
        //public AnchoringShot AnchoringShot { get; set; }
    }
}
