using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.PlayerBuild
{
    public class PassiveSkills
    {
        public PassiveSkills(JToken passiveSkillsToken)
        {
            IntimidatingPresence = (int)passiveSkillsToken.SelectToken("['Intimidating Presence']");
        }

        private int IntimidatingPresence { get; set; }
        private int PowerSurge { get; set; }
        private int AntiTitanCannon { get; set; }
        private int MysticalImpact { get; set; }
        private int ArcaneBargain { get; set; }
        private int SilentMarch { get; set; }
        private int CloakAndDagger { get; set; }
    }
}
