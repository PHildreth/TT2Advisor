using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Common;

namespace TT2Advisor.SkillTree
{
    public class Skill<T> where T : ISkill
    {
    }

    public interface ISkill
    {
        public static SkillTreeTypeEnum SkillTree { get; }
        public static SkillTypeEnum SkillType { get; }
        public static int Tier { get; }
        public static DamageTypeEnum PrimaryDamageType { get; }

    }
}
