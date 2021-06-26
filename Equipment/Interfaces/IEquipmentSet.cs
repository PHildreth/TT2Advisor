namespace TT2Advisor.Equipment
{
    public interface IEquipmentSet
    {
        public string Name { get; }
        public string FriendlyName { get; }
        public bool Owned { get; set; }

        static EquipmentSetClassEnum EquipmentSetClass { get; set; }

        public ISword Sword { get; }
        public IHelmet Helmet { get; }
        public IArmor Armor { get; }
        public IAura Aura { get; }
        public ISlash Slash { get; }

        public string Bonus1 { get; }
        public string Bonus1Amount { get; }
    }
}