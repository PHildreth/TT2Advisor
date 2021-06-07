using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Common;

namespace TT2Advisor.SkillTree
{
    public class SkillsRepo
    {
        public class KnightsValor : ISkill
        {
            public SkillTreeTypeEnum SkillTree => SkillTreeTypeEnum.Knight;
            public SkillTypeEnum SkillType => SkillTypeEnum.KnightsValor;
            public int Tier => 1;
            public DamageTypeEnum PrimaryDamageType => DamageTypeEnum.TapDamage;
        }
        public class Chivalricrder : ISkill
        {
            public SkillTreeTypeEnum SkillTree => SkillTreeTypeEnum.Knight;
            public SkillTypeEnum SkillType => SkillTypeEnum.ChivalricOrder;
            public int Tier => 1;
            public DamageTypeEnum PrimaryDamageType => DamageTypeEnum.TapDamageFromHeres;
        }
    }
}
