using TT2Advisor.Common.Helpers;

namespace TT2Advisor.Equipment
{
    public interface IArmor : IEquipmentSetItem
    {
        public ArmorGoldSourceTypeEnum PrimaryGoldSourceType { get; set; }
        public decimal PrimaryGoldSourceAmount { get; set; }
        public int PrimaryGoldSourceAmounteLevel { get; set; }
        public string PrimaryGoldSourceTypeFriendlyName => PrimaryGoldSourceType.GetDisplayName();
    }
}