using TT2Advisor.Common.Enums;
using TT2Advisor.Common.Helpers;

namespace TT2Advisor.Equipment
{
    public interface ISword : IEquipmentSetItem
    {
        SwordDamageTypeEnum PrimaryDamageType { get; set; }
        decimal PrimaryDamageAmount { get; set; }
        int PrimaryDamageAmounteLevel { get; set; }
        string PrimaryDamageTypeFriendlyName { get; }
    }
}