using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.SkillTree
{
    public class SkillTree<T> where T : ISkillTree
    {
    }

    public interface ISkillTree
    {
        public SkillTreeTypeEnum SkillTreeType { get; }
    }
}
