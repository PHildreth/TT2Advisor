using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Equipment;
using TT2Advisor.Equipment.EquipmentSets;
//using static TT2Advisor.Equipment.EquipmentSetsRepo;

namespace TT2Advisor.PlayerBuild
{
    public class EquipmentSets
    {
        public EquipmentSets(JToken equipmentSetsToken)
        {
            var tokens = equipmentSetsToken.SelectTokens("[*]");
            var convertedTokens = tokens.Select(t => t.ToString());
            //var eqSets = convertedTokens.Select(t => new EquipmentSet(t));
            //Owned = eqSets.ToList();

            if (convertedTokens.Contains("The Fallen Angel")) TheFallenAngel = new TheFallenAngel("The Fallen Angel");
        }

        //private List<EquipmentSet> Owned { get; set; }
        public TheFallenAngel TheFallenAngel { get; set; }
    }
}
