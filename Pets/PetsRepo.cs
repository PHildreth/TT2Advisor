using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.Pets
{
    public class PetsRepo
    {
        public class Nova : IPet
        {
            public PetTypeEnum PetType => PetTypeEnum.Nova;

            public PetBonusTypeEnum ActiveBonusType => PetBonusTypeEnum.AllDamage;

            public PetBonusTypeEnum PassiveBonusType => PetBonusTypeEnum.AllDamage;
        }
    }
}
