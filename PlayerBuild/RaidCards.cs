using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.RaidCards;
using static TT2Advisor.RaidCards.RaidCardsRepo;

namespace TT2Advisor.PlayerBuild
{
    public class RaidCards
    {
        public RaidCards(JToken raidCardsToken)
        {
            MoonBeam = new RaidCard<MoonBeam>(raidCardsToken.SelectToken("['Moon Beam']"));
        }

        public RaidCard<MoonBeam> MoonBeam { get; set; }
    }
}
