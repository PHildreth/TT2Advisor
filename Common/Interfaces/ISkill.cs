using System;
using System.Collections.Generic;
using System.Text;
using TT2Advisor.Common.Enums;

namespace TT2Advisor.Common.Interfaces
{
    public interface ISkill
    {
        string Name { get; }
        string FriendlyName { get; }
        int Tier { get; }
        int Level { get; set; }
        int SPCost { get; }
        //public DamageTypeEnum DamageType { get; }
        //public double DamageAmount { get; }

    }
}
