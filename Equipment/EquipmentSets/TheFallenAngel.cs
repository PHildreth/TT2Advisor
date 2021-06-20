using System;
using System.Collections.Generic;
using System.Text;

namespace TT2Advisor.Equipment.EquipmentSets
{
    public class TheFallenAngel : IMythicEquipmentSet
    {
        public TheFallenAngel(string name)
        {
            Name = name;
            Owned = true;

            Sword = new Sword()
            {
                Name = "Night Angel's Kiss",
                PrimaryDamageType = SwordDamageTypeEnum.CriticalDamage,
            };

            Helmet = new Helmet()
            {

                Name = "Dusk Watcher",
                PrimaryDamageType = HelmetDamageTypeEnum.MageHeroDamage,
            };

            Armor = new Armor()
            {
                Name = "Impure Defense",
                PrimaryGoldSourceType = ArmorGoldSourceTypeEnum.ChestersonGold,
            };

            Aura = new Aura()
            {
                Name = "Wings of the Phantasm",
                PrimaryDamageType = AuraDamageTypeEnum.SlashPrimaryBoost,
            };

            Slash = new Slash()
            {
                Name = "Devouring Secrets",
                PrimaryDamageType = SlashDamageTypeEnum.HeavenlyStrikeDamage,
            };
        }
        public string Name { get; set; }
        public string FriendlyName => "The Fallen Angel";
        public bool Owned { get; set; }

        public ISword Sword { get; set; }
        public IHelmet Helmet { get; set; }
        public IArmor Armor { get; set; }
        public IAura Aura { get; set; }
        public ISlash Slash { get; set; }

        public string Bonus1 => "+5 Spells Level Cap";
        public string Bonus1Amount => "5"; // Unit
        public string Bonus2 => "Damage Per Activated Spell";
        public string Bonus2Amount => "125.4"; // Multiplier
        public string Bonus3 => "Prestige Relics";
        public string Bonus3Amount => "2080"; // Percent
    }
}
