namespace TT2Advisor.Equipment
{
    public class Slash : ISlash
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public SlashDamageTypeEnum PrimaryDamageType { get; set; }
        public decimal PrimaryDamageAmount { get; set; }
        public int PrimaryDamageAmounteLevel { get; set; }
    }
}