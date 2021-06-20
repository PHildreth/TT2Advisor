namespace TT2Advisor.Equipment
{
    public class Sword : ISword
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public SwordDamageTypeEnum PrimaryDamageType { get; set; }
        public decimal PrimaryDamageAmount { get; set; }
        public int PrimaryDamageAmounteLevel { get; set; }
    }
}