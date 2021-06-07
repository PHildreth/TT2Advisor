using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Common.Helpers;

namespace TT2Advisor.RaidCards
{
    public interface IRaidCard
    {
        static IRaidCard()
        {

        }

        public RaidCardTypeEnum RaidCardType { get; }
        public int Level { get; }
        public int Cards { get; }
        public static string FriendlyName { get; }
    }

    public class RaidCard : IRaidCard
    {
        public RaidCard(JToken raidCardToken)
        {
            Level = (int)raidCardToken.SelectToken("level");
            Cards = (int)raidCardToken.SelectToken("cards");
        }
        public RaidCardTypeEnum RaidCardType { get; internal set; }
        public int Level { get; private set; }
        public int Cards { get; private set; }
        public string FriendlyName => RaidCardType.GetDisplayName();
    }
}
