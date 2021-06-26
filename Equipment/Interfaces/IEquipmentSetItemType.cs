using TT2Advisor.Common.Enums;

namespace TT2Advisor.Equipment
{
    public interface IEquipmentSetItemType
    {
        DamageTypeEnum PrimaryDamageType { get; }
        string Name { get; }
    }
}