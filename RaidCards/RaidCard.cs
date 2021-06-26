using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Common.Enums;
using TT2Advisor.Common.Helpers;
using TT2Advisor.Common.Interfaces;

namespace TT2Advisor.RaidCards
{
    public class RaidCard : IRaidCard
    {
        public RaidCard(IRaidCard raidCard)
        {
            Level = raidCard.Level;
            Cards = raidCard.Cards;
        }
        public RaidCardTypeEnum RaidCardType { get; internal set; }
        public int Level { get; private set; }
        public int Cards { get; private set; }
        public string FriendlyName => RaidCardType.GetDisplayName();
    }
}
