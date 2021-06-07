using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.PlayerBuild
{
    public class Build
    {
        public Build(JToken buildToken)
        {
            PlayerStats = new PlayerStats(buildToken.SelectToken("playerStats"));
            RaidStats = new RaidStats(buildToken.SelectToken("raidStats"));
            Artifacts = new Artifacts(buildToken.SelectToken("artifacts"));
            SplashStats = new SplashStats(buildToken.SelectToken("splashStats"));
            RaidCards = new RaidCards(buildToken.SelectToken("raidCards"));
            EquipmentSets = new EquipmentSets(buildToken.SelectToken("equipmentSets"));
            PassiveSkills = new PassiveSkills(buildToken.SelectToken("passiveSkills"));
            PetLevels = new PetLevels(buildToken.SelectToken("petLevels"));
            SkillTree = new SkillTree(buildToken.SelectToken("skillTree"));
        }

        public PlayerStats PlayerStats { get; set; }
        public RaidStats RaidStats { get; set; }
        public Artifacts Artifacts { get; set; }
        public SplashStats SplashStats { get; set; }
        public RaidCards RaidCards { get; set; }
        public EquipmentSets EquipmentSets { get; set; }
        public PassiveSkills PassiveSkills { get; set; }
        public PetLevels PetLevels { get; set; }
        public SkillTree SkillTree { get; set; }
    }
}
