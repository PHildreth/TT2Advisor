namespace TT2Advisor.Equipment
{
    public interface IEquipmentSetItemType
    {
        DamageTypeEnum PrimaryDamageType { get; }
        string Name { get; }
    }
}