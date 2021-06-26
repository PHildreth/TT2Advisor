using TT2Advisor.Common.Enums;

namespace TT2Advisor.Equipment
{
    public class Helmet : IHelmet
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public HelmetDamageTypeEnum PrimaryDamageType { get; set; }
        public decimal PrimaryDamageAmount { get; set; }
        public int PrimaryDamageAmounteLevel { get; set; }
    }
}