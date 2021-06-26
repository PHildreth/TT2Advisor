using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TT2Advisor.Common.Attributes;
using TT2Advisor.Common.Interfaces;

namespace TT2Advisor.PlayerBuild.Import
{
    public class ImportBuild
    {
        public Playerstats playerStats { get; set; }
        public Raidstats raidStats { get; set; }
        public Artifacts artifacts { get; set; }
        public Splashstats splashStats { get; set; }
        public Raidcards raidCards { get; set; }
        public string[] equipmentSets { get; set; }
        public Passiveskills passiveSkills { get; set; }
        public Petlevels petLevels { get; set; }
        public Skilltree skillTree { get; set; }
    }

    public class Playerstats
    {
        public string MaxPrestigeStage { get; set; }
        public string ArtifactsCollected { get; set; }
        public string CraftingPower { get; set; }
        public string TotalPetLevels { get; set; }
        public string SkillPointsOwned { get; set; }
        public string HeroWeaponUpgrades { get; set; }
        public string HeroScrollUpgrades { get; set; }
        public string TournamentsJoined { get; set; }
        public string UndisputedWins { get; set; }
        public string TournamentPoints { get; set; }
        public string LifetimeRelics { get; set; }
    }

    public class Raidstats
    {
        public string RaidLevel { get; set; }
        public string RaidDamage { get; set; }
        public string TotalRaidExperience { get; set; }
        public string TotalRaidAttacks { get; set; }
        public string TotalRaidCardLevels { get; set; }
        public string RaidCardsOwned { get; set; }
        public string LifetimeClanMorale { get; set; }
    }

    public class Artifacts
    {
        public BookOfShadows BookofShadows { get; set; }
        public ChargedCard ChargedCard { get; set; }
        public StoneOfTheValrunes StoneoftheValrunes { get; set; }
        public ChestOfContentment ChestofContentment { get; set; }
        public HeroicShield HeroicShield { get; set; }
        public BookOfProphecy BookofProphecy { get; set; }
        public KhrysosBowl KhrysosBowl { get; set; }
        public ZakynthosCoin ZakynthosCoin { get; set; }
        public GreatFayMedallion GreatFayMedallion { get; set; }
        public NekoSculpture NekoSculpture { get; set; }
        public CoinsOfEbizu CoinsofEbizu { get; set; }
        public TheBronzedCompass TheBronzedCompass { get; set; }
        public EvergrowingStack EvergrowingStack { get; set; }
        public FluteOfTheSoloist FluteoftheSoloist { get; set; }
        public HeavenlySword HeavenlySword { get; set; }
        public DivineRetribution DivineRetribution { get; set; }
        public DrunkenHammer DrunkenHammer { get; set; }
        public SamosekSword SamosekSword { get; set; }
        public TheRetaliator TheRetaliator { get; set; }
        public StryfesPeace StryfesPeace { get; set; }
        public HerosBlade HerosBlade { get; set; }
        public TheSwordOfStorms TheSwordofStorms { get; set; }
        public FuriesBow FuriesBow { get; set; }
        public CharmOfTheAncient CharmoftheAncient { get; set; }
        public TinyTitanTree TinyTitanTree { get; set; }
        public HelmOfHermes HelmofHermes { get; set; }
        public FruitOfEden FruitofEden { get; set; }
        public InfluentialElixir InfluentialElixir { get; set; }
        public ShimmeringOil ShimmeringOil { get; set; }
        public OryansCharm ORyansCharm { get; set; }
        public HeartOfStorms HeartofStorms { get; set; }
        public ApolloOrb ApolloOrb { get; set; }
        public StickyFruit StickyFruit { get; set; }
        public HadesOrb HadesOrb { get; set; }
        public EarringsOfPortara EarringsofPortara { get; set; }
        public AvianFeather AvianFeather { get; set; }
        public CorruptedRuneHeart CorruptedRuneHeart { get; set; }
        public DurendalSword DurendalSword { get; set; }
        public HelheimSkull HelheimSkull { get; set; }
        public OathsBurden OathsBurden { get; set; }
        public CrownOfTheConstellation CrownoftheConstellation { get; set; }
        public TitaniasSceptre TitaniasSceptre { get; set; }
        public FaginsGrip FaginsGrip { get; set; }
        public RingOfCalisto RingofCalisto { get; set; }
        public BladeOfDamocles BladeofDamocles { get; set; }
        public HelmetOfMadness HelmetofMadness { get; set; }
        public TitaniumPlating TitaniumPlating { get; set; }
        public MoonlightBracelet MoonlightBracelet { get; set; }
        public AmethystStaff AmethystStaff { get; set; }
        public SwordOfTheRoyals SwordoftheRoyals { get; set; }
        public SpearitsVigil SpearitsVigil { get; set; }
        public TheCobaltPlate TheCobaltPlate { get; set; }
        public SigilsOfJudgement SigilsofJudgement { get; set; }
        public FoliageOfTheKeeper FoliageoftheKeeper { get; set; }
        public InvadersGjallarhorn InvadersGjallarhorn { get; set; }
        public TitansMask TitansMask { get; set; }
        public RoyalToxin RoyalToxin { get; set; }
        public LaborersPendant LaborersPendant { get; set; }
        public BringerOfRagnarok BringerofRagnarok { get; set; }
        public ParchmentOfForesight ParchmentofForesight { get; set; }
        public ElixirOfEden ElixirofEden { get; set; }
        public HourglassOfTheImpatient HourglassoftheImpatient { get; set; }
        public PhantomTimepiece PhantomTimepiece { get; set; }
        public ForbiddenScroll ForbiddenScroll { get; set; }
        public RingOfFealty RingofFealty { get; set; }
        public GlacialAxe GlacialAxe { get; set; }
        public Aegis Aegis { get; set; }
        public SwampGauntlet SwampGauntlet { get; set; }
        public InfinityPendulum InfinityPendulum { get; set; }
        public GloveOfKuma GloveofKuma { get; set; }
        public TitanSpear TitanSpear { get; set; }
        public OakStaff OakStaff { get; set; }
        public TheArcanaCloak TheArcanaCloak { get; set; }
        public HuntersOintment HuntersOintment { get; set; }
        public AmbrosiaElixir AmbrosiaElixir { get; set; }
        public MysticStaff MysticStaff { get; set; }
        public MysticalBeansOfSenzu MysticalBeansofSenzu { get; set; }
        public EggOfFortune EggofFortune { get; set; }
        public DivineChalice DivineChalice { get; set; }
        public InvadersShield InvadersShield { get; set; }
        public AxeOfMuerte AxeofMuerte { get; set; }
        public EssenceOfTheKitsune EssenceoftheKitsune { get; set; }
        public BootsOfHermes BootsofHermes { get; set; }
        public UnboundGauntlet UnboundGauntlet { get; set; }
        public OberonPendant OberonPendant { get; set; }
        public LuckyFootOfAlMiraj LuckyFootofAlmiraj { get; set; }
        public LostKingsMask LostKingsMask { get; set; }
        public StaffOfRadiance StaffofRadiance { get; set; }
        public MorgelaiSword MorgelaiSword { get; set; }
        public RingingStone RingingStone { get; set; }
        public QuillOfScrolls QuillofScrolls { get; set; }
        public OldKingsStamp OldKingsStamp { get; set; }
        public TheMastersSword TheMastersSword { get; set; }
        public TheMagnifier TheMagnifier { get; set; }
        public TheTreasureOfFergus TheTreasureofFergus { get; set; }
        public TheWhiteDwarf TheWhiteDwarf { get; set; }
        public AramSpear AramSpear { get; set; }
        public WardOfTheDarkness WardoftheDarkness { get; set; }
    }

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

    public class Splashstats
    {
        public string SplashDamage { get; set; }
        public string BaseMaxSplashCount { get; set; }
        public string AllSplashSkip { get; set; }
        public string HeavenlyStrikeSplashCount { get; set; }
        public string LightningBurstSplashCount { get; set; }
        public string ClanShipSplashCount { get; set; }
        public string DaggerSplashCount { get; set; }
        public string HeavenlyStrikeSplashSkip { get; set; }
        public string PetSplashSkip { get; set; }
        public string ClanShipSplashSkip { get; set; }
        public string ShadowCloneSplashSkip { get; set; }
        public string DaggerSplashSkip { get; set; }
    }

    public class Raidcards
    {
        public MoonBeam MoonBeam { get; set; }
        public Fragmentize Fragmentize { get; set; }
        public SkullBash SkullBash { get; set; }
        public RazorWind RazorWind { get; set; }
        public WhipOfLightning WhipofLightning { get; set; }
        public ClanshipBarrage ClanshipBarrage { get; set; }
        public PurifyingBlast PurifyingBlast { get; set; }
        public PsychicChain PsychicChain { get; set; }
        public FlakShot FlakShot { get; set; }
        public CosmicHaymaker CosmicHaymaker { get; set; }
        public BlazingInferno BlazingInferno { get; set; }
        public AcidDrench AcidDrench { get; set; }
        public DecayingStrike DecayingStrike { get; set; }
        public FusionBomb FusionBomb { get; set; }
        public GrimShadow GrimShadow { get; set; }
        public ThrivingPlague ThrivingPlague { get; set; }
        public Radioactivity Radioactivity { get; set; }
        public RavenousSwarm RavenousSwarm { get; set; }
        public Maelstrom Maelstrom { get; set; }
        public CrushingInstinct CrushingInstinct { get; set; }
        public InsanityVoid InsanityVoid { get; set; }
        public RancidGas RancidGas { get; set; }
        public InspiringForce InspiringForce { get; set; }
        public SoulFire SoulFire { get; set; }
        public VictoryMarch VictoryMarch { get; set; }
        public PrismaticRift PrismaticRift { get; set; }
        public AncestralFavor AncestralFavor { get; set; }
        public GraspingVines GraspingVines { get; set; }
        public TotemOfPower TotemofPower { get; set; }
    }

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

    public class Passiveskills
    {
        public int IntimidatingPresence { get; set; }
        public int PowerSurge { get; set; }
        public int AntiTitanCannon { get; set; }
        public int MysticalImpact { get; set; }
        public int ArcaneBargain { get; set; }
        public int SilentMarch { get; set; }
        public int CloakAndDagger { get; set; }
    }

    public class Petlevels
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
    
    public class Skilltree : ISkillTree
    {
        [KnightTree]
        public int KnightsValor { get; set; }
        [KnightTree]
        public int ChivalricOrder { get; set; }
        [KnightTree]
        public int PetEvolution { get; set; }
        [KnightTree]
        public int HeartofMidas { get; set; }
        [KnightTree]
        public int CleavingStrike { get; set; }
        [KnightTree]
        public int SummonInferno { get; set; }
        [KnightTree]
        public int LightningBurst { get; set; }
        [KnightTree]
        public int BarbaricFury { get; set; }
        [KnightTree]
        public int VolcanicSupremacy { get; set; }
        [KnightTree]
        public int FlashZip { get; set; }

        [WarlordTree]
        public int MasterCommander { get; set; }
        [WarlordTree]
        public int SpoilsofWar { get; set; }
        [WarlordTree]
        public int HeroicMight { get; set; }
        [WarlordTree]
        public int AerialAssault { get; set; }
        [WarlordTree]
        public int TacticalInsight { get; set; }
        [WarlordTree]
        public int SearingLight { get; set; }
        [WarlordTree]
        public int CoordinatedOffensive { get; set; }
        [WarlordTree]
        public int AstralAwakening { get; set; }
        [WarlordTree]
        public int CommandSupremacy { get; set; }
        [WarlordTree]
        public int AnchoringShot { get; set; }

        [SorcererTree]
        public int LimitBreak { get; set; }
        [SorcererTree]
        public int MidasUltimate { get; set; }
        [SorcererTree]
        public int AngelicRadiance { get; set; }
        [SorcererTree]
        public int PhantomVengeance { get; set; }
        [SorcererTree]
        public int FairyCharm { get; set; }
        [SorcererTree]
        public int ManaSiphon { get; set; }
        [SorcererTree]
        public int EternalDarkness { get; set; }
        [SorcererTree]
        public int ManniMana { get; set; }
        [SorcererTree]
        public int LightningStrike { get; set; }
        [SorcererTree]
        public int DimensionalShift { get; set; }
        [SorcererTree]

        [RogueTree]
        public int MasterThief { get; set; }
        [RogueTree]
        public int Ambush { get; set; }
        [RogueTree]
        public int Assassinate { get; set; }
        [RogueTree]
        public int SummonDagger { get; set; }
        [RogueTree]
        public int StrokeOfLuck { get; set; }
        [RogueTree]
        public int DaggerStorm { get; set; }
        [RogueTree]
        public int Cloaking { get; set; }
        [RogueTree]
        public int ForbiddenContract { get; set; }
        [RogueTree]
        public int PoisonEdge { get; set; }
        [RogueTree]
        public int DeadlyFocus { get; set; }


    }

    public static class ImportExtensions
    {
        public static int GetInt(this string input) => int.TryParse(input, out int output) ? output : -1;
        public static double GetDouble(this string input) => double.TryParse(input, out double output) ? output : -1;

        //public static bool TryParse<T>(this string input, out T value)
        //{
        //    TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));
        //    if (converter.CanConvertTo(typeof(T)) && converter.CanConvertFrom(typeof(string)))
        //    {
        //        value = (T)converter.ConvertFromString(input);
        //        return true;
        //    }
        //    else
        //    {
        //        value = default(T);
        //        return false;
        //    }
        //}
    }
}
