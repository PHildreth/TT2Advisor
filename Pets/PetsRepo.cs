using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Common.Enums;
using TT2Advisor.Common.Interfaces;

namespace TT2Advisor.Pets
{
    public class PetsRepo
    {
        public class Nova : IPet
        {
            public Nova(int level)
            {
                Level = level;
            }

            public int Level { get; }

            public PetTypeEnum PetType => PetTypeEnum.Nova;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }
    }
}
