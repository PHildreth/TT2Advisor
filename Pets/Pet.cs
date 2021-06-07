using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.Pets
{
    public class Pet<T> where T : IPet
    {
        public Pet(JToken petToken)
        {
            IPet.Level = (int)petToken.SelectToken("");
        }
    }

    public interface IPet
    {
        public void IPet(int level) => Level = level;

        public PetTypeEnum PetType { get; }
        public static bool IsLegacy { get; }
        public static int Level { get; set;  }
        public PetBonusTypeEnum ActiveBonusType { get; }
        public static double ActiveBonusAmount { get; }
        public PetBonusTypeEnum PassiveBonusType { get; }
        public static double PassiveBonusAmount { get; }
    }
}
