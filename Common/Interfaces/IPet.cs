using System;
using System.Collections.Generic;
using System.Text;
using TT2Advisor.Common.Enums;

namespace TT2Advisor.Common.Interfaces
{
    public interface IPet
    {
        public PetTypeEnum PetType { get; }
        public static bool IsLegacy { get; }
        public static int Level { get; set; }
        public PetBonusTypeEnum ActiveBonusType { get; }
        public static double ActiveBonusAmount { get; }
        public PetBonusTypeEnum PassiveBonusType { get; }
        public static double PassiveBonusAmount { get; }
    }
}
