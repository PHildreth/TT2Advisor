using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Import;

namespace TT2Advisor.PlayerBuild
{
    public class PassiveSkills
    {
        //public PassiveSkills(JToken passiveSkillsToken)
        //{
        //    IntimidatingPresence = (int)passiveSkillsToken.SelectToken("['Intimidating Presence']");
        //    PowerSurge = (int)passiveSkillsToken.SelectToken("['Power Surge']");
        //    AntiTitanCannon = (int)passiveSkillsToken.SelectToken("['Anti-Titan Cannon']");
        //    MysticalImpact = (int)passiveSkillsToken.SelectToken("['Mystical Impact']");
        //    ArcaneBargain = (int)passiveSkillsToken.SelectToken("['Arcane Bargain']");
        //    SilentMarch = (int)passiveSkillsToken.SelectToken("['Silent Marth']");
        //    CloakAndDagger = (int)passiveSkillsToken.SelectToken("['Cloak And Dagger']");
        //}

        public PassiveSkills(Import.PassiveSkills passiveSkills)
        {
            IntimidatingPresence = passiveSkills.IntimidatingPresence;
            PowerSurge = passiveSkills.PowerSurge;
            AntiTitanCannon = passiveSkills.AntiTitanCannon;
            MysticalImpact = passiveSkills.MysticalImpact;
            ArcaneBargain = passiveSkills.ArcaneBargain;
            SilentMarch = passiveSkills.SilentMarch;
            CloakAndDagger = passiveSkills.CloakAndDagger;
        }

        public int IntimidatingPresence { get; set; }
        public int PowerSurge { get; set; }
        public int AntiTitanCannon { get; set; }
        public int MysticalImpact { get; set; }
        public int ArcaneBargain { get; set; }
        public int SilentMarch { get; set; }
        public int CloakAndDagger { get; set; }
    }
}
