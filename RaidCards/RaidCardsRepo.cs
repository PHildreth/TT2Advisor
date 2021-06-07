using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.RaidCards
{
    public class RaidCardsRepo
    {
        public class MoonBeam : IRaidCard
        {
            public RaidCardTypeEnum RaidCardType => RaidCardTypeEnum.MoonBeam;
        }
    }
}
