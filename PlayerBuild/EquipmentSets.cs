using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.PlayerBuild
{
    public class EquipmentSets : List<string>
    {
        public EquipmentSets(JToken jToken)
        {
            //SplashDamage = (int)splashStatsToken.SelectToken("['Splash Damage']");
        }
    }
}
