using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using TT2Advisor.Common.Helpers;
using TT2Advisor.Common.Interfaces;

namespace TT2Advisor.Import
{
    public class ImportBuild
    {
        [JsonProperty("playerStats")]
        public PlayerStats PlayerStats { get; set; }

        [JsonProperty("raidStats")]
        public RaidStats RaidStats { get; set; }

        [JsonProperty("artifacts")]
        public Artifacts Artifacts { get; set; }

        [JsonProperty("splashStats")]
        public SplashStats SplashStats { get; set; }

        [JsonProperty("raidCards")]
        public RaidCards RaidCards { get; set; }

        [JsonProperty("equipmentSets")]
        public string[] EquipmentSets { get; set; }

        [JsonProperty("passiveSkills")]
        public PassiveSkills PassiveSkills { get; set; }

        [JsonProperty("petLevels")]
        public PetLevels PetLevels { get; set; }

        [JsonProperty("skillTree")]
        public SkillTree SkillTree { get; set; }
    }

    public class PlayerStats
    {
        [JsonProperty("Max Prestige Stage")]
        public string MaxPrestigeStage { get; set; }
        [JsonProperty("Artifacts Collected")]
        public string ArtifactsCollected { get; set; }
        [JsonProperty("Crafting Power")]
        public string CraftingPower { get; set; }
        [JsonProperty("Total Pet Levels")]
        public string TotalPetLevels { get; set; }
        [JsonProperty("Skill Points Owned")]
        public string SkillPointsOwned { get; set; }
        [JsonProperty("Hero Weapon Upgrades")]
        public string HeroWeaponUpgrades { get; set; }
        [JsonProperty("Hero Scroll Upgrades")]
        public string HeroScrollUpgrades { get; set; }
        [JsonProperty("Tournaments Joined")]
        public string TournamentsJoined { get; set; }
        [JsonProperty("Undisputed Wins")]
        public string UndisputedWins { get; set; }
        [JsonProperty("Tournament Points")]
        public string TournamentPoints { get; set; }
        [JsonProperty("Lifetime Relics")]
        public string LifetimeRelics { get; set; }
    }

    public class RaidStats
    {
        [JsonProperty("Raid Level")]
        public string RaidLevel { get; set; }
        [JsonProperty("Raid Damage")]
        public string RaidDamage { get; set; }
        [JsonProperty("Total Raid Experience")]
        public string TotalRaidExperience { get; set; }
        [JsonProperty("Total Raid Attacks")]
        public string TotalRaidAttacks { get; set; }
        [JsonProperty("Total Raid Card Levels")]
        public string TotalRaidCardLevels { get; set; }
        [JsonProperty("Raid Cards Owned")]
        public string RaidCardsOwned { get; set; }
        [JsonProperty("Lifetime Clan Morale")]
        public string LifetimeClanMorale { get; set; }
    }

    public class Artifacts
    {
        [JsonProperty("Book of Shadows")]
        public BookOfShadows BookofShadows { get; set; }

        [JsonProperty("Charged Card")]
        public ChargedCard ChargedCard { get; set; }

        [JsonProperty("Stone of the Valrunes")]
        public StoneOfTheValrunes StoneoftheValrunes { get; set; }

        [JsonProperty("Chest of Contentment")]
        public ChestOfContentment ChestofContentment { get; set; }

        [JsonProperty("Heroic Shield")]
        public HeroicShield HeroicShield { get; set; }

        [JsonProperty("Book of Prophecy")]
        public BookOfProphecy BookofProphecy { get; set; }

        [JsonProperty("Khrysos Bowl")]
        public KhrysosBowl KhrysosBowl { get; set; }

        [JsonProperty("Zakynthos Coin")]
        public ZakynthosCoin ZakynthosCoin { get; set; }

        [JsonProperty("Great Fay Medallion")]
        public GreatFayMedallion GreatFayMedallion { get; set; }

        [JsonProperty("Neko Sculpture")]
        public NekoSculpture NekoSculpture { get; set; }

        [JsonProperty("Coins of Ebizu")]
        public CoinsOfEbizu CoinsofEbizu { get; set; }

        [JsonProperty("The Bronzed Compass")]
        public TheBronzedCompass TheBronzedCompass { get; set; }

        [JsonProperty("Evergrowing Stack")]
        public EvergrowingStack EvergrowingStack { get; set; }

        [JsonProperty("Flute of the Soloist")]
        public FluteOfTheSoloist FluteoftheSoloist { get; set; }

        [JsonProperty("Heavenly Sword")]
        public HeavenlySword HeavenlySword { get; set; }

        [JsonProperty("Divine Retribution")]
        public DivineRetribution DivineRetribution { get; set; }

        [JsonProperty("Drunken Hammer")]
        public DrunkenHammer DrunkenHammer { get; set; }

        [JsonProperty("Samosek Sword")]
        public SamosekSword SamosekSword { get; set; }

        [JsonProperty("The Retaliator")]
        public TheRetaliator TheRetaliator { get; set; }

        [JsonProperty("Stryfe's Peace")]
        public StryfesPeace StryfesPeace { get; set; }

        [JsonProperty("Hero's Blade")]
        public HerosBlade HerosBlade { get; set; }

        [JsonProperty("The Sword of Storms")]
        public TheSwordOfStorms TheSwordofStorms { get; set; }

        [JsonProperty("Furies Bow")]
        public FuriesBow FuriesBow { get; set; }

        [JsonProperty("Charm of the Ancient")]
        public CharmOfTheAncient CharmoftheAncient { get; set; }

        [JsonProperty("Tiny Titan Tree")]
        public TinyTitanTree TinyTitanTree { get; set; }

        [JsonProperty("Helm of Hermes")]
        public HelmOfHermes HelmofHermes { get; set; }

        [JsonProperty("Fruit of Eden")]
        public FruitOfEden FruitofEden { get; set; }

        [JsonProperty("Influential Elixir")]
        public InfluentialElixir InfluentialElixir { get; set; }

        [JsonProperty("Shimmering Oil")]
        public ShimmeringOil ShimmeringOil { get; set; }

        [JsonProperty("O'Ryan's Charm")]
        public OryansCharm ORyansCharm { get; set; }

        [JsonProperty("Heart of Storms")]
        public HeartOfStorms HeartofStorms { get; set; }

        [JsonProperty("Apollo Orb")]
        public ApolloOrb ApolloOrb { get; set; }

        [JsonProperty("Sticky Fruit")]
        public StickyFruit StickyFruit { get; set; }

        [JsonProperty("Hades Orb")]
        public HadesOrb HadesOrb { get; set; }

        [JsonProperty("Earrings of Portara")]
        public EarringsOfPortara EarringsofPortara { get; set; }

        [JsonProperty("Avian Feather")]
        public AvianFeather AvianFeather { get; set; }

        [JsonProperty("Corrupted Rune Heart")]
        public CorruptedRuneHeart CorruptedRuneHeart { get; set; }

        [JsonProperty("Durendal Sword")]
        public DurendalSword DurendalSword { get; set; }

        [JsonProperty("Helheim Skull")]
        public HelheimSkull HelheimSkull { get; set; }

        [JsonProperty("Oath's Burden")]
        public OathsBurden OathsBurden { get; set; }

        [JsonProperty("Crown of the Constellation")]
        public CrownOfTheConstellation CrownoftheConstellation { get; set; }

        [JsonProperty("Titania's Sceptre")]
        public TitaniasSceptre TitaniasSceptre { get; set; }

        [JsonProperty("Fagin's Grip")]
        public FaginsGrip FaginsGrip { get; set; }

        [JsonProperty("Ring of Calisto")]
        public RingOfCalisto RingofCalisto { get; set; }

        [JsonProperty("Blade of Damocles")]
        public BladeOfDamocles BladeofDamocles { get; set; }

        [JsonProperty("Helmet of Madness")]
        public HelmetOfMadness HelmetofMadness { get; set; }

        [JsonProperty("Titanium Plating")]
        public TitaniumPlating TitaniumPlating { get; set; }

        [JsonProperty("Moonlight Bracelet")]
        public MoonlightBracelet MoonlightBracelet { get; set; }

        [JsonProperty("Amethyst Staff")]
        public AmethystStaff AmethystStaff { get; set; }

        [JsonProperty("Sword of the Royals")]
        public SwordOfTheRoyals SwordoftheRoyals { get; set; }

        [JsonProperty("Spearit's Vigil")]
        public SpearitsVigil SpearitsVigil { get; set; }

        [JsonProperty("The Cobalt Plate")]
        public TheCobaltPlate TheCobaltPlate { get; set; }

        [JsonProperty("Sigils of Judgement")]
        public SigilsOfJudgement SigilsofJudgement { get; set; }

        [JsonProperty("Foliage of the Keeper")]
        public FoliageOfTheKeeper FoliageoftheKeeper { get; set; }

        [JsonProperty("Invader's Gjallarhorn")]
        public InvadersGjallarhorn InvadersGjallarhorn { get; set; }

        [JsonProperty("Titan's Mask")]
        public TitansMask TitansMask { get; set; }

        [JsonProperty("Royal Toxin")]
        public RoyalToxin RoyalToxin { get; set; }

        [JsonProperty("Laborer's Pendant")]
        public LaborersPendant LaborersPendant { get; set; }

        [JsonProperty("Bringer of Ragnarok")]
        public BringerOfRagnarok BringerofRagnarok { get; set; }

        [JsonProperty("Parchment of Foresight")]
        public ParchmentOfForesight ParchmentofForesight { get; set; }

        [JsonProperty("Elixir of Eden")]
        public ElixirOfEden ElixirofEden { get; set; }

        [JsonProperty("Hourglass of the Impatient")]
        public HourglassOfTheImpatient HourglassoftheImpatient { get; set; }

        [JsonProperty("Phantom Timepiece")]
        public PhantomTimepiece PhantomTimepiece { get; set; }

        [JsonProperty("Forbidden Scroll")]
        public ForbiddenScroll ForbiddenScroll { get; set; }

        [JsonProperty("Ring of Fealty")]
        public RingOfFealty RingofFealty { get; set; }

        [JsonProperty("Glacial Axe")]
        public GlacialAxe GlacialAxe { get; set; }

        [JsonProperty("Aegis")]
        public Aegis Aegis { get; set; }

        [JsonProperty("Swamp Gauntlet")]
        public SwampGauntlet SwampGauntlet { get; set; }

        [JsonProperty("Infinity Pendulum")]
        public InfinityPendulum InfinityPendulum { get; set; }

        [JsonProperty("Glove of Kuma")]
        public GloveOfKuma GloveofKuma { get; set; }

        [JsonProperty("Titan Spear")]
        public TitanSpear TitanSpear { get; set; }

        [JsonProperty("Oak Staff")]
        public OakStaff OakStaff { get; set; }

        [JsonProperty("The Arcana Cloak")]
        public TheArcanaCloak TheArcanaCloak { get; set; }

        [JsonProperty("Hunter's Ointment")]
        public HuntersOintment HuntersOintment { get; set; }

        [JsonProperty("Ambrosia Elixir")]
        public AmbrosiaElixir AmbrosiaElixir { get; set; }

        [JsonProperty("Mystic Staff")]
        public MysticStaff MysticStaff { get; set; }

        [JsonProperty("Mystical Beans of Senzu")]
        public MysticalBeansOfSenzu MysticalBeansofSenzu { get; set; }

        [JsonProperty("Egg of Fortune")]
        public EggOfFortune EggofFortune { get; set; }

        [JsonProperty("Divine Chalice")]
        public DivineChalice DivineChalice { get; set; }

        [JsonProperty("Invader's Shield")]
        public InvadersShield InvadersShield { get; set; }

        [JsonProperty("Axe of Muerte")]
        public AxeOfMuerte AxeofMuerte { get; set; }

        [JsonProperty("Essence of the Kitsune")]
        public EssenceOfTheKitsune EssenceoftheKitsune { get; set; }

        [JsonProperty("Boots of Hermes")]
        public BootsOfHermes BootsofHermes { get; set; }

        [JsonProperty("Unbound Gauntlet")]
        public UnboundGauntlet UnboundGauntlet { get; set; }

        [JsonProperty("Oberon Pendant")]
        public OberonPendant OberonPendant { get; set; }

        [JsonProperty("Lucky Foot of Al-mi'raj")]
        public LuckyFootOfAlMiraj LuckyFootofAlmiraj { get; set; }

        [JsonProperty("Lost King's Mask")]
        public LostKingsMask LostKingsMask { get; set; }

        [JsonProperty("Staff of Radiance")]
        public StaffOfRadiance StaffofRadiance { get; set; }

        [JsonProperty("Morgelai Sword")]
        public MorgelaiSword MorgelaiSword { get; set; }

        [JsonProperty("Ringing Stone")]
        public RingingStone RingingStone { get; set; }

        [JsonProperty("Quill of Scrolls")]
        public QuillOfScrolls QuillofScrolls { get; set; }

        [JsonProperty("Old King's Stamp")]
        public OldKingsStamp OldKingsStamp { get; set; }

        [JsonProperty("The Master's Sword")]
        public TheMastersSword TheMastersSword { get; set; }

        [JsonProperty("The Magnifier")]
        public TheMagnifier TheMagnifier { get; set; }

        [JsonProperty("The Treasure of Fergus")]
        public TheTreasureOfFergus TheTreasureofFergus { get; set; }

        [JsonProperty("The White Dwarf")]
        public TheWhiteDwarf TheWhiteDwarf { get; set; }

        [JsonProperty("Aram Spear")]
        public AramSpear AramSpear { get; set; }

        [JsonProperty("Ward of the Darkness")]
        public WardOfTheDarkness WardoftheDarkness { get; set; }
    }

    #region Artifact Definitions
    public class BookOfShadows : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class ChargedCard : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class StoneOfTheValrunes : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class ChestOfContentment : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class HeroicShield : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class BookOfProphecy : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class KhrysosBowl : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class ZakynthosCoin : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class GreatFayMedallion : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class NekoSculpture : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class CoinsOfEbizu : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TheBronzedCompass : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class EvergrowingStack : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class FluteOfTheSoloist : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class HeavenlySword : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class DivineRetribution : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class DrunkenHammer : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class SamosekSword : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TheRetaliator : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class StryfesPeace : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class HerosBlade : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TheSwordOfStorms : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class FuriesBow : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class CharmOfTheAncient : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TinyTitanTree : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class HelmOfHermes : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class FruitOfEden : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class InfluentialElixir : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class ShimmeringOil : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class OryansCharm : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class HeartOfStorms : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class ApolloOrb : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class StickyFruit : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class HadesOrb : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class EarringsOfPortara : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class AvianFeather : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class CorruptedRuneHeart : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class DurendalSword : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class HelheimSkull : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class OathsBurden : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class CrownOfTheConstellation : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TitaniasSceptre : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class FaginsGrip : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class RingOfCalisto : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class BladeOfDamocles : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class HelmetOfMadness : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TitaniumPlating : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class MoonlightBracelet : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class AmethystStaff : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class SwordOfTheRoyals : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class SpearitsVigil : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TheCobaltPlate : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class SigilsOfJudgement : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class FoliageOfTheKeeper : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class InvadersGjallarhorn : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TitansMask : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class RoyalToxin : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class LaborersPendant : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class BringerOfRagnarok : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class ParchmentOfForesight : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class ElixirOfEden : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class HourglassOfTheImpatient : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class PhantomTimepiece : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class ForbiddenScroll : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class RingOfFealty : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class GlacialAxe : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class Aegis : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class SwampGauntlet : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class InfinityPendulum : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class GloveOfKuma : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TitanSpear : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class OakStaff : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TheArcanaCloak : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class HuntersOintment : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class AmbrosiaElixir : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class MysticStaff : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class MysticalBeansOfSenzu : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class EggOfFortune : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class DivineChalice : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class InvadersShield : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class AxeOfMuerte : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class EssenceOfTheKitsune : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class BootsOfHermes : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class UnboundGauntlet : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class OberonPendant : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class LuckyFootOfAlMiraj : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class LostKingsMask : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class StaffOfRadiance : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class MorgelaiSword : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class RingingStone : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class QuillOfScrolls : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class OldKingsStamp : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TheMastersSword : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TheMagnifier : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TheTreasureOfFergus : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class TheWhiteDwarf : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class AramSpear : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }

    public class WardOfTheDarkness : IArtifact
    {
        public string Enchanted { get; set; }
        public string Level { get; set; }
    }
    #endregion Artifact Definitions

    public class SplashStats
    {
        [JsonProperty("Splash Damage")]
        public string SplashDamage { get; set; }
        [JsonProperty("Base Max Splash Count")]
        public string BaseMaxSplashCount { get; set; }
        [JsonProperty("All Splash Skip")]
        public string AllSplashSkip { get; set; }
        [JsonProperty("Heavenly Strike Splash Count")]
        public string HeavenlyStrikeSplashCount { get; set; }
        [JsonProperty("Lightning Burst Splash Count")]
        public string LightningBurstSplashCount { get; set; }
        [JsonProperty("Clan Ship Splash Count")]
        public string ClanShipSplashCount { get; set; }
        [JsonProperty("Dagger Splash Count")]
        public string DaggerSplashCount { get; set; }
        [JsonProperty("Heavenly Strike Splash Skip")]
        public string HeavenlyStrikeSplashSkip { get; set; }
        [JsonProperty("Pet Splash Skip")]
        public string PetSplashSkip { get; set; }
        [JsonProperty("Clan Ship Splash Skip")]
        public string ClanShipSplashSkip { get; set; }
        [JsonProperty("Shadow Clone Splash Skip")]
        public string ShadowCloneSplashSkip { get; set; }
        [JsonProperty("Dagger Splash Skip")]
        public string DaggerSplashSkip { get; set; }
    }

    public class RaidCards
    {
        [JsonProperty("Moon Beam")]
        public MoonBeam MoonBeam { get; set; }

        [JsonProperty("Fragmentize")]
        public Fragmentize Fragmentize { get; set; }

        [JsonProperty("Skull Bash")]
        public SkullBash SkullBash { get; set; }

        [JsonProperty("Razor Wind")]
        public RazorWind RazorWind { get; set; }

        [JsonProperty("Whip of Lightning")]
        public WhipOfLightning WhipofLightning { get; set; }

        [JsonProperty("Clanship Barrage")]
        public ClanshipBarrage ClanshipBarrage { get; set; }

        [JsonProperty("Purifying Blast")]
        public PurifyingBlast PurifyingBlast { get; set; }

        [JsonProperty("Psychic Chain")]
        public PsychicChain PsychicChain { get; set; }

        [JsonProperty("Flak Shot")]
        public FlakShot FlakShot { get; set; }

        [JsonProperty("Cosmic Haymaker")]
        public CosmicHaymaker CosmicHaymaker { get; set; }

        [JsonProperty("Blazing Inferno")]
        public BlazingInferno BlazingInferno { get; set; }

        [JsonProperty("Acid Drench")]
        public AcidDrench AcidDrench { get; set; }

        [JsonProperty("Decaying Strike")]
        public DecayingStrike DecayingStrike { get; set; }

        [JsonProperty("Fusion Bomb")]
        public FusionBomb FusionBomb { get; set; }

        [JsonProperty("Grim Shadow")]
        public GrimShadow GrimShadow { get; set; }

        [JsonProperty("Thriving Plague")]
        public ThrivingPlague ThrivingPlague { get; set; }

        [JsonProperty("Radioactivity")]
        public Radioactivity Radioactivity { get; set; }

        [JsonProperty("Ravenous Swarm")]
        public RavenousSwarm RavenousSwarm { get; set; }

        [JsonProperty("Maelstrom")]
        public Maelstrom Maelstrom { get; set; }

        [JsonProperty("Crushing Instinct")]
        public CrushingInstinct CrushingInstinct { get; set; }

        [JsonProperty("Insanity Void")]
        public InsanityVoid InsanityVoid { get; set; }

        [JsonProperty("Rancid Gas")]
        public RancidGas RancidGas { get; set; }

        [JsonProperty("Inspiring Force")]
        public InspiringForce InspiringForce { get; set; }

        [JsonProperty("Soul Fire")]
        public SoulFire SoulFire { get; set; }

        [JsonProperty("Victory March")]
        public VictoryMarch VictoryMarch { get; set; }

        [JsonProperty("Prismatic Rift")]
        public PrismaticRift PrismaticRift { get; set; }

        [JsonProperty("Ancestral Favor")]
        public AncestralFavor AncestralFavor { get; set; }

        [JsonProperty("Grasping Vines")]
        public GraspingVines GraspingVines { get; set; }

        [JsonProperty("Totem of Power")]
        public TotemOfPower TotemofPower { get; set; }
    }

    #region RaidCard Definitions
    public class MoonBeam : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class Fragmentize : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class SkullBash : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class RazorWind : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class WhipOfLightning : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class ClanshipBarrage : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class PurifyingBlast : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class PsychicChain : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class FlakShot : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class CosmicHaymaker : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class BlazingInferno : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class AcidDrench : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class DecayingStrike : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class FusionBomb : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class GrimShadow : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class ThrivingPlague : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class Radioactivity : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class RavenousSwarm : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class Maelstrom : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class CrushingInstinct : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class InsanityVoid : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class RancidGas : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class InspiringForce : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class SoulFire : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class VictoryMarch : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class PrismaticRift : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class AncestralFavor : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class GraspingVines : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }

    public class TotemOfPower : IRaidCard
    {
        public int Level { get; set; }
        public int Cards { get; set; }
    }
    #endregion RaidCard Definitions

    public class PassiveSkills
    {
        [JsonProperty("Intimidating Presence")]
        public int IntimidatingPresence { get; set; }
        [JsonProperty("Power Surge")]
        public int PowerSurge { get; set; }
        [JsonProperty("Anti-Titan Cannon")]
        public int AntiTitanCannon { get; set; }
        [JsonProperty("Mystical Impact")]
        public int MysticalImpact { get; set; }
        [JsonProperty("Arcane Bargain")]
        public int ArcaneBargain { get; set; }
        [JsonProperty("Silent March")]
        public int SilentMarch { get; set; }
        [JsonProperty("Cloak And Dagger")]
        public int CloakAndDagger { get; set; }
    }

    public class PetLevels
    {
        public int Nova { get; set; }
        public int Toto { get; set; }
        public int Cerberus { get; set; }
        public int Mousy { get; set; }
        public int Harker { get; set; }
        public int Bubbles { get; set; }
        public int Demos { get; set; }
        public int Tempest { get; set; }
        public int Basky { get; set; }
        public int Scraps { get; set; }
        public int Zero { get; set; }
        public int Polly { get; set; }
        public int Hamy { get; set; }
        public int Phobos { get; set; }
        public int Fluffers { get; set; }
        public int Kit { get; set; }
        public int Soot { get; set; }
        public int Klack { get; set; }
        public int Cooper { get; set; }
        public int Jaws { get; set; }
        public int Xander { get; set; }
        public int Griff { get; set; }
        public int Basil { get; set; }
        public int Bash { get; set; }
        public int Violet { get; set; }
        public int Annabelle { get; set; }
        public int Effie { get; set; }
        public int Percy { get; set; }
        public int Cosmos { get; set; }
        public int Taffy { get; set; }
    }

    public class SkillTree
    {
        [JsonProperty("Knight's Valor")]
        public int KnightsValor { get; set; }

        [JsonProperty("Chivalric Order")]
        public int ChivalricOrder { get; set; }

        [JsonProperty("Angelic Radiance")]
        public int AngelicRadiance { get; set; }

        [JsonProperty("Midas Ultimate")]
        public int MidasUltimate { get; set; }

        [JsonProperty("Cleaving Strike")]
        public int CleavingStrike { get; set; }

        [JsonProperty("Rejuvenation")]
        public int Rejuvenation { get; set; }

        [JsonProperty("Will Of Midas")]
        public int WillOfMidas { get; set; }

        [JsonProperty("Barbaric Fury")]
        public int BarbaricFury { get; set; }

        [JsonProperty("Divine Wrath")]
        public int DivineWrath { get; set; }

        [JsonProperty("Fairy Charm")]
        public int FairyCharm { get; set; }



        [JsonProperty("Pet Evolution")]
        public int PetEvolution { get; set; }

        [JsonProperty("Summon Inferno")]
        public int SummonInferno { get; set; }

        [JsonProperty("Heart of Midas")]
        public int HeartofMidas { get; set; }

        [JsonProperty("Companion Warfare")]
        public int CompanionWarfare { get; set; }

        [JsonProperty("Ember Arts")]
        public int EmberArts { get; set; }

        [JsonProperty("Lightning Burst")]
        public int LightningBurst { get; set; }

        [JsonProperty("Summoning Circle")]
        public int SummoningCircle { get; set; }

        [JsonProperty("Volcanic Eruption")]
        public int VolcanicEruption { get; set; }

        [JsonProperty("Flash Zip")]
        public int FlashZip { get; set; }

        [JsonProperty("Burning Passion")]
        public int BurningPassion { get; set; }



        [JsonProperty("Master Commander")]
        public int MasterCommander { get; set; }

        [JsonProperty("Spoils of War")]
        public int SpoilsofWar { get; set; }

        [JsonProperty("Heroic Might")]
        public int HeroicMight { get; set; }

        [JsonProperty("Aerial Assault")]
        public int AerialAssault { get; set; }

        [JsonProperty("Tactical Insight")]
        public int TacticalInsight { get; set; }

        [JsonProperty("Searing Light")]
        public int SearingLight { get; set; }

        [JsonProperty("Coordinated Offensive")]
        public int CoordinatedOffensive { get; set; }

        [JsonProperty("Astral Awakening")]
        public int AstralAwakening { get; set; }

        [JsonProperty("Command Supremacy")]
        public int CommandSupremacy { get; set; }

        [JsonProperty("Anchoring Shot")]
        public int AnchoringShot { get; set; }



        [JsonProperty("Phantom Vengeance")]
        public int PhantomVengeance { get; set; }

        [JsonProperty("Limit Break")]
        public int LimitBreak { get; set; }

        [JsonProperty("Eternal Darkness")]
        public int EternalDarkness { get; set; }

        [JsonProperty("Mana Siphon")]
        public int ManaSiphon { get; set; }

        [JsonProperty("Manni Mana")]
        public int ManniMana { get; set; }

        [JsonProperty("Dimensional Shift")]
        public int DimensionalShift { get; set; }

        [JsonProperty("Lightning Strike")]
        public int LightningStrike { get; set; }

        [JsonProperty("Forbidden Contract")]
        public int ForbiddenContract { get; set; }



        [JsonProperty("Master Thief")]
        public int MasterThief { get; set; }

        [JsonProperty("Assassinate")]
        public int Assassinate { get; set; }

        [JsonProperty("Summon Dagger")]
        public int SummonDagger { get; set; }

        [JsonProperty("Ambush")]
        public int Ambush { get; set; }

        [JsonProperty("Stroke Of Luck")]
        public int StrokeOfLuck { get; set; }

        [JsonProperty("Poison Edge")]
        public int PoisonEdge { get; set; }

        [JsonProperty("Cloaking")]
        public int Cloaking { get; set; }

        [JsonProperty("Dagger Storm")]
        public int DaggerStorm { get; set; }

        [JsonProperty("Deadly Focus")]
        public int DeadlyFocus { get; set; }
    }

    public static class ImportExtensions
    {
        public static decimal ToDecimal(this string input) => decimal.TryParse(input, out var value) ? value : 0;
        public static double ToDouble(this string input) => double.TryParse(input, out var value) ? value : 0;
        public static int ToInt(this string input) => int.TryParse(input, out var value) ? value : 0;
    }
}
