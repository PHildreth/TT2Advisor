using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.Equipment
{
    public interface IMythicEquipmentSet : IEquipmentSet
    {
        new static EquipmentSetClassEnum EquipmentSetClass => EquipmentSetClassEnum.Mythic;

        public string Bonus2 { get; }
        public string Bonus2Amount { get; }
        public string Bonus3 { get; }
        public string Bonus3Amount { get; }
    }
}
