using System.ComponentModel.DataAnnotations;

namespace TT2Advisor.Equipment
{
    public enum DamageTypeEnum
    {
        [Display(Name = "Not Set")] NotSet = 0,

        [Display(Name = "All Damage")] AllDamage,
        [Display(Name = "All Hero Damage")] AllHeroDamage,
        [Display(Name = "Critical Damage")] CriticalDamage,
        [Display(Name = "Tap Damage")] TapDamage,


        [Display(Name = "Mage Hero Damage")] MageHeroDamage,
        [Display(Name = "Ranger Hero Damage")] RangerHeroDamage,
        [Display(Name = "Sword Attack Damage")] SwordAttackDamage,
        [Display(Name = "Warrior Hero Damage")] WarriorHeroDamage,

        [Display(Name = "Helmet Primary Boost")] HelmetPrimaryBoost,
        [Display(Name = "Slash Primary Boost")] SlashPrimaryBoost,
        [Display(Name = "Sword Primary Boost")] SwordPrimaryBoost,

        [Display(Name = "Clan Ship Damage")] ClanShipDamage,
        [Display(Name = "Dagger Damage")] DaggerDamage,
        [Display(Name = "Heavenly Strike Damage")] HeavenlyStrikeDamage,
        [Display(Name = "Pet Damage")] PetDamage,
        [Display(Name = "Shadow Clone Damage")] ShadowCloneDamage,
    }

    public enum SwordDamageTypeEnum
    {
        AllDamage = DamageTypeEnum.AllDamage,
        AllHeroDamage = DamageTypeEnum.AllHeroDamage,
        CriticalDamage = DamageTypeEnum.CriticalDamage,
        TapDamage = DamageTypeEnum.TapDamage,
    }

    public enum HelmetDamageTypeEnum
    {
        MageHeroDamage = DamageTypeEnum.MageHeroDamage,
        RangerHeroDamage = DamageTypeEnum.RangerHeroDamage,
        SwordAttackDamage = DamageTypeEnum.SwordAttackDamage,
        WarriorHeroDamage = DamageTypeEnum.WarriorHeroDamage,
    }

    public enum AuraDamageTypeEnum
    {
        HelmetPrimaryBoost = DamageTypeEnum.HelmetPrimaryBoost,
        SlashPrimaryBoost = DamageTypeEnum.SlashPrimaryBoost,
        SwordPrimaryBoost = DamageTypeEnum.SwordPrimaryBoost,
    }

    public enum SlashDamageTypeEnum
    {
        ClanShipDamage = DamageTypeEnum.ClanShipDamage,
        DaggerDamage = DamageTypeEnum.DaggerDamage,
        HeavenlyStrikeDamage = DamageTypeEnum.HeavenlyStrikeDamage,
        PetDamage = DamageTypeEnum.PetDamage,
        ShadowCloneDamage = DamageTypeEnum.ShadowCloneDamage,
    }
}