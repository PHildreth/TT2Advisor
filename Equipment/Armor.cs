using TT2Advisor.Common.Enums;
using TT2Advisor.Common.Helpers;

namespace TT2Advisor.Equipment
{
    public class Armor : IArmor
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public ArmorGoldSourceTypeEnum PrimaryGoldSourceType { get; set; }
        public decimal PrimaryGoldSourceAmount { get; set; }
        public int PrimaryGoldSourceAmounteLevel { get; set; }

        public string PrimaryGoldSourceTypeFriendlyName => PrimaryGoldSourceType.GetDisplayName();
    }
}