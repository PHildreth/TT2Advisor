using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.RaidCards
{
    public class RaidCard<T> where T : IRaidCard
    {
        public RaidCard(JToken raidCardToken)
        {
            IRaidCard.Level = (int)raidCardToken.SelectToken("level");
            IRaidCard.Cards = (int)raidCardToken.SelectToken("cards");
        }
    }

    public interface IRaidCard
    {
        public RaidCardTypeEnum RaidCardType { get; }
        public static int Level { get; set; }
        public static int Cards { get; set; }
    }
}
