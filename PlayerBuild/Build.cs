using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TT2Advisor.Common.Interfaces;
using TT2Advisor.Import;

namespace TT2Advisor.PlayerBuild
{
    public class Build : IBuild
    {
        public Build(ImportBuild importBuild)
        {
            PlayerStats = new PlayerStats(importBuild.PlayerStats); // new PlayerStats(buildToken.SelectToken("playerStats"));
            RaidStats = new RaidStats(importBuild.RaidStats); // new RaidStats(buildToken.SelectToken("raidStats"));
            Artifacts = new Artifacts(importBuild.Artifacts); // new Artifacts(buildToken.SelectToken("artifacts"));
            SplashStats = new SplashStats(importBuild.SplashStats); // new SplashStats(buildToken.SelectToken("splashStats"));
            RaidCards = new RaidCards(importBuild.RaidCards); // new RaidCards(buildToken.SelectToken("raidCards"));
            EquipmentSets = new EquipmentSets(importBuild.EquipmentSets); // new EquipmentSets(buildToken.SelectToken("equipmentSets"));
            PassiveSkills = new PassiveSkills(importBuild.PassiveSkills); // new PassiveSkills(buildToken.SelectToken("passiveSkills"));
            PetLevels = new PetLevels(importBuild.PetLevels); // new PetLevels(buildToken.SelectToken("petLevels"));
            SkillTree = new SkillTree(importBuild.SkillTree); // new SkillTree(buildToken.SelectToken("skillTree"));
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
