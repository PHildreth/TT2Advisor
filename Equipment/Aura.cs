using TT2Advisor.Common.Enums;

namespace TT2Advisor.Equipment
{
    public class Aura : IAura
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public AuraDamageTypeEnum PrimaryDamageType { get; set; }
        public decimal PrimaryDamageAmount { get; set; }
        public int PrimaryDamageAmounteLevel { get; set; }
    }
}