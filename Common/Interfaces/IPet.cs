using System;
using System.Collections.Generic;
using System.Text;
using TT2Advisor.Common.Enums;

namespace TT2Advisor.Common.Interfaces
{
    public interface IPet
    {
        PetTypeEnum PetType { get; }
        static bool IsLegacy { get; }
        static int Level { get; set; }
        PetBonusTypeEnum ActiveBonusType { get; }
        static double ActiveBonusAmount { get; }
        PetBonusTypeEnum PassiveBonusType { get; }
        static double PassiveBonusAmount { get; }
    }
}
