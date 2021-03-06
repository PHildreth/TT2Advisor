using TT2Advisor.Common.Enums;
using TT2Advisor.Common.Helpers;

namespace TT2Advisor.Equipment
{
    public interface IAura : IEquipmentSetItem
    {
        public AuraDamageTypeEnum PrimaryDamageType { get; set; }
        public decimal PrimaryDamageAmount { get; set; }
        public int PrimaryDamageAmounteLevel { get; set; }
        public string PrimaryDamageTypeFriendlyName => PrimaryDamageType.GetDisplayName();
    }
}