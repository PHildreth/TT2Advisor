using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Pets;
using static TT2Advisor.Pets.PetsRepo;

namespace TT2Advisor.PlayerBuild
{
    public class PetLevels
    {
        public PetLevels(JToken petLevelsToken)
        {
            Nova = new Pet<Nova>(petLevelsToken.SelectToken("Nova"));
        }

        public Pet<Nova> Nova { get; set; }
    }
}
