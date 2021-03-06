using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.Equipment
{
    public class EquipmentSet : IEquipmentSet
    {
        public string Name { get; set; }

        public string FriendlyName { get; }

        public bool Owned { get; set; }


        public ISword Sword { get; }

        public IHelmet Helmet { get; }

        public IArmor Armor { get; }

        public IAura Aura { get; }

        public ISlash Slash { get; }


        public string Bonus1 { get; }

        public string Bonus1Amount { get; }
    }
}
