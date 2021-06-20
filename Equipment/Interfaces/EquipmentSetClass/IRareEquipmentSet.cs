using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.Equipment
{
    public interface IRareEquipmentSet : IEquipmentSet
    {
        new static EquipmentSetClassEnum EquipmentSetClass => EquipmentSetClassEnum.Rare;
    }
}
