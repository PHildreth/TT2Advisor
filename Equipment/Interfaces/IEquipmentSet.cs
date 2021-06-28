namespace TT2Advisor.Equipment
{
    public interface IEquipmentSet
    {
        public string Name { get; }
        public string FriendlyName { get; }
        public bool Owned { get; set; }

        static EquipmentSetClassEnum EquipmentSetClass { get; set; }

        Sword Sword { get; }
        Helmet Helmet { get; }
        Armor Armor { get; }
        Aura Aura { get; }
        Slash Slash { get; }

        public string Bonus1 { get; }
        public string Bonus1Amount { get; }
    }
}