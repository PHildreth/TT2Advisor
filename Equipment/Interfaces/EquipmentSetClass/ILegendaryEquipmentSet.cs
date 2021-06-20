using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.Equipment
{
    public interface ILegendaryEquipmentSet : IEquipmentSet
    {
        new static EquipmentSetClassEnum EquipmentSetClass => EquipmentSetClassEnum.Legendary;
        public string Bonus2 { get; set; }
    }
}
