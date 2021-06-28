using System;
using System.Collections.Generic;
using System.Text;
using TT2Advisor.Common.Interfaces;

namespace TT2Advisor.SkillTree
{
    public class Skill : ISkill
    {
        public string Name { get; }

        public string FriendlyName { get; }

        public int Tier { get; }

        public int Level { get; set; }

        public int SPCost { get; }
    }
}
