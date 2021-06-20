using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.Equipment
{
    public class EquipmentSetItem : IEquipmentSetItem
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public DamageTypeEnum PrimaryDamageType { get; set; }
        public decimal PrimaryDamageAmount { get; set; }
        public int PrimaryDamageAmounteLevel { get; set; }
    }
}
