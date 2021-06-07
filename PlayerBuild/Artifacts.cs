using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TT2Advisor.Artifacts;
using static TT2Advisor.Artifacts.ArtifactsRepo;

namespace TT2Advisor.PlayerBuild
{
    public class Artifacts
    {
        public Artifacts(JToken artifactsToken)
        {
            BookofShadows = new BookofShadows(artifactsToken.SelectToken("['Book of Shadows']"));
            ChargedCard = new ChargedCard(artifactsToken.SelectToken("['Charged Card']"));
            StoneoftheValrunes = new StoneoftheValrunes(artifactsToken.SelectToken("['Stone of the Valrunes']"));
            ChestofContentment = new ChestofContentment(artifactsToken.SelectToken("['Chest of Contentment']"));
            HeroicShield = new HeroicShield(artifactsToken.SelectToken("['Heroic Shield']"));
            BookofProphecy = new BookofProphecy(artifactsToken.SelectToken("['Book of Prophecy']"));
            KhrysosBowl = new KhrysosBowl(artifactsToken.SelectToken("['Khrysos Bowl']"));
            ZakynthosCoin = new ZakynthosCoin(artifactsToken.SelectToken("['Zakynthos Coin']"));
            GreatFayMedallion = new GreatFayMedallion(artifactsToken.SelectToken("['Great Fay Medallion']"));
            NekoSculpture = new NekoSculpture(artifactsToken.SelectToken("['Neko Sculpture']"));
            CoinsofEbizu = new CoinsofEbizu(artifactsToken.SelectToken("['Coins of Ebizu']"));
            TheBronzedCompass = new TheBronzedCompass(artifactsToken.SelectToken("['The Bronzed Compass']"));
            EvergrowingStack = new EvergrowingStack(artifactsToken.SelectToken("['Evergrowing Stack']"));
            FluteoftheSoloist = new FluteoftheSoloist(artifactsToken.SelectToken("['Flute of the Soloist']"));
            HeavenlySword = new HeavenlySword(artifactsToken.SelectToken("['Heavenly Sword']"));
            DivineRetribution = new DivineRetribution(artifactsToken.SelectToken("['Divine Retribution']"));
            DrunkenHammer = new DrunkenHammer(artifactsToken.SelectToken("['Drunken Hammer']"));
            SamosekSword = new SamosekSword(artifactsToken.SelectToken("['Samosek Sword']"));
            TheRetaliator = new TheRetaliator(artifactsToken.SelectToken("['The Retaliator']"));
            StryfesPeace = new StryfesPeace(artifactsToken.SelectToken("['Stryfe\\'s Peace']"));
            HerosBlade = new HerosBlade(artifactsToken.SelectToken("['Hero\\'s Blade']"));
            TheSwordofStorms = new TheSwordofStorms(artifactsToken.SelectToken("['The Sword of Storms']"));
            FuriesBow = new FuriesBow(artifactsToken.SelectToken("['Furies Bow']"));
            CharmoftheAncient = new CharmoftheAncient(artifactsToken.SelectToken("['Charm of the Ancient']"));
            TinyTitanTree = new TinyTitanTree(artifactsToken.SelectToken("['Tiny Titan Tree']"));
            HelmofHermes = new HelmofHermes(artifactsToken.SelectToken("['Helm of Hermes']"));
            FruitofEden = new FruitofEden(artifactsToken.SelectToken("['Fruit of Eden']"));
            InfluentialElixir = new InfluentialElixir(artifactsToken.SelectToken("['Influential Elixir']"));
            ShimmeringOil = new ShimmeringOil(artifactsToken.SelectToken("['Shimmering Oil']"));
            ORyansCharm = new ORyansCharm(artifactsToken.SelectToken("['O\\'Ryan\\'s Charm']"));
            HeartofStorms = new HeartofStorms(artifactsToken.SelectToken("['Heart of Storms']"));
            ApolloOrb = new ApolloOrb(artifactsToken.SelectToken("['Apollo Orb']"));
            StickyFruit = new StickyFruit(artifactsToken.SelectToken("['Sticky Fruit']"));
            HadesOrb = new HadesOrb(artifactsToken.SelectToken("['Hades Orb']"));
            EarringsofPortara = new EarringsofPortara(artifactsToken.SelectToken("['Earrings of Portara']"));
            AvianFeather = new AvianFeather(artifactsToken.SelectToken("['Avian Feather']"));
            CorruptedRuneHeart = new CorruptedRuneHeart(artifactsToken.SelectToken("['Corrupted Rune Heart']"));
            DurendalSword = new DurendalSword(artifactsToken.SelectToken("['Durendal Sword']"));
            HelheimSkull = new HelheimSkull(artifactsToken.SelectToken("['Helheim Skull']"));
            OathsBurden = new OathsBurden(artifactsToken.SelectToken("['Oath\\'s Burden']"));
            CrownoftheConstellation = new CrownoftheConstellation(artifactsToken.SelectToken("['Crown of the Constellation']"));
            TitaniasSceptre = new TitaniasSceptre(artifactsToken.SelectToken("['Titania\\'s Sceptre']"));
            FaginsGrip = new FaginsGrip(artifactsToken.SelectToken("['Fagin\\'s Grip']"));
            RingofCalisto = new RingofCalisto(artifactsToken.SelectToken("['Ring of Calisto']"));
            BladeofDamocles = new BladeofDamocles(artifactsToken.SelectToken("['Blade of Damocles']"));
            HelmetofMadness = new HelmetofMadness(artifactsToken.SelectToken("['Helmet of Madness']"));
            TitaniumPlating = new TitaniumPlating(artifactsToken.SelectToken("['Titanium Plating']"));
            MoonlightBracelet = new MoonlightBracelet(artifactsToken.SelectToken("['Moonlight Bracelet']"));
            AmethystStaff = new AmethystStaff(artifactsToken.SelectToken("['Amethyst Staff']"));
            SwordoftheRoyals = new SwordoftheRoyals(artifactsToken.SelectToken("['Sword of the Royals']"));
            SpearitsVigil = new SpearitsVigil(artifactsToken.SelectToken("['Spearit\\'s Vigil']"));
            TheCobaltPlate = new TheCobaltPlate(artifactsToken.SelectToken("['The Cobalt Plate']"));
            SigilsofJudgement = new SigilsofJudgement(artifactsToken.SelectToken("['Sigils of Judgement']"));
            FoliageoftheKeeper = new FoliageoftheKeeper(artifactsToken.SelectToken("['Foliage of the Keeper']"));
            InvadersGjallarhorn = new InvadersGjallarhorn(artifactsToken.SelectToken("['Invader\\'s Gjallarhorn']"));
            TitansMask = new TitansMask(artifactsToken.SelectToken("['Titan\\'s Mask']"));
            RoyalToxin = new RoyalToxin(artifactsToken.SelectToken("['Royal Toxin']"));
            LaborersPendant = new LaborersPendant(artifactsToken.SelectToken("['Laborer\\'s Pendant']"));
            BringerofRagnarok = new BringerofRagnarok(artifactsToken.SelectToken("['Bringer of Ragnarok']"));
            ParchmentofForesight = new ParchmentofForesight(artifactsToken.SelectToken("['Parchment of Foresight']"));
            ElixirofEden = new ElixirofEden(artifactsToken.SelectToken("['Elixir of Eden']"));
            HourglassoftheImpatient = new HourglassoftheImpatient(artifactsToken.SelectToken("['Hourglass of the Impatient']"));
            PhantomTimepiece = new PhantomTimepiece(artifactsToken.SelectToken("['Phantom Timepiece']"));
            ForbiddenScroll = new ForbiddenScroll(artifactsToken.SelectToken("['Forbidden Scroll']"));
            RingofFealty = new RingofFealty(artifactsToken.SelectToken("['Ring of Fealty']"));
            GlacialAxe = new GlacialAxe(artifactsToken.SelectToken("['Glacial Axe']"));
            Aegis = new Aegis(artifactsToken.SelectToken("['Aegis']"));
            SwampGauntlet = new SwampGauntlet(artifactsToken.SelectToken("['Swamp Gauntlet']"));
            InfinityPendulum = new InfinityPendulum(artifactsToken.SelectToken("['Infinity Pendulum']"));
            GloveofKuma = new GloveofKuma(artifactsToken.SelectToken("['Glove of Kuma']"));
            TitanSpear = new TitanSpear(artifactsToken.SelectToken("['Titan Spear']"));
            OakStaff = new OakStaff(artifactsToken.SelectToken("['Oak Staff']"));
            TheArcanaCloak = new TheArcanaCloak(artifactsToken.SelectToken("['The Arcana Cloak']"));
            HuntersOintment = new HuntersOintment(artifactsToken.SelectToken("['Hunter\\'s Ointment']"));
            AmbrosiaElixir = new AmbrosiaElixir(artifactsToken.SelectToken("['Ambrosia Elixir']"));
            MysticStaff = new MysticStaff(artifactsToken.SelectToken("['Mystic Staff']"));
            MysticalBeansofSenzu = new MysticalBeansofSenzu(artifactsToken.SelectToken("['Mystical Beans of Senzu']"));
            EggofFortune = new EggofFortune(artifactsToken.SelectToken("['Egg of Fortune']"));
            DivineChalice = new DivineChalice(artifactsToken.SelectToken("['Divine Chalice']"));
            InvadersShield = new InvadersShield(artifactsToken.SelectToken("['Invader\\'s Shield']"));
            AxeofMuerte = new AxeofMuerte(artifactsToken.SelectToken("['Axe of Muerte']"));
            EssenceoftheKitsune = new EssenceoftheKitsune(artifactsToken.SelectToken("['Essence of the Kitsune']"));
            BootsofHermes = new BootsofHermes(artifactsToken.SelectToken("['Boots of Hermes']"));
            UnboundGauntlet = new UnboundGauntlet(artifactsToken.SelectToken("['Unbound Gauntlet']"));
            OberonPendant = new OberonPendant(artifactsToken.SelectToken("['Oberon Pendant']"));
            LuckyFootofAlmiraj = new LuckyFootofAlmiraj(artifactsToken.SelectToken("['Lucky Foot of Al-mi\\'raj']"));
            LostKingsMask = new LostKingsMask(artifactsToken.SelectToken("['Lost King\\'s Mask']"));
            StaffofRadiance = new StaffofRadiance(artifactsToken.SelectToken("['Staff of Radiance']"));
            MorgelaiSword = new MorgelaiSword(artifactsToken.SelectToken("['Morgelai Sword']"));
            RingingStone = new RingingStone(artifactsToken.SelectToken("['Ringing Stone']"));
            QuillofScrolls = new QuillofScrolls(artifactsToken.SelectToken("['Quill of Scrolls']"));
            OldKingsStamp = new OldKingsStamp(artifactsToken.SelectToken("['Old King\\'s Stamp']"));
            TheMastersSword = new TheMastersSword(artifactsToken.SelectToken("['The Master\\'s Sword']"));
            TheMagnifier = new TheMagnifier(artifactsToken.SelectToken("['The Magnifier']"));
            TheTreasureofFergus = new TheTreasureofFergus(artifactsToken.SelectToken("['The Treasure of Fergus']"));
            TheWhiteDwarf = new TheWhiteDwarf(artifactsToken.SelectToken("['The White Dwarf']"));
            AramSpear = new AramSpear(artifactsToken.SelectToken("['Aram Spear']"));
            WardoftheDarkness = new WardoftheDarkness(artifactsToken.SelectToken("['Ward of the Darkness']"));
        }

        public BookofShadows BookofShadows { get; set; }
        public ChargedCard ChargedCard { get; set; }
        public StoneoftheValrunes StoneoftheValrunes { get; set; }
        public ChestofContentment ChestofContentment { get; set; }
        public HeroicShield HeroicShield { get; set; }
        public BookofProphecy BookofProphecy { get; set; }
        public KhrysosBowl KhrysosBowl { get; set; }
        public ZakynthosCoin ZakynthosCoin { get; set; }
        public GreatFayMedallion GreatFayMedallion { get; set; }
        public NekoSculpture NekoSculpture { get; set; }
        public CoinsofEbizu CoinsofEbizu { get; set; }
        public TheBronzedCompass TheBronzedCompass { get; set; }
        public EvergrowingStack EvergrowingStack { get; set; }
        public FluteoftheSoloist FluteoftheSoloist { get; set; }
        public HeavenlySword HeavenlySword { get; set; }
        public DivineRetribution DivineRetribution { get; set; }
        public DrunkenHammer DrunkenHammer { get; set; }
        public SamosekSword SamosekSword { get; set; }
        public TheRetaliator TheRetaliator { get; set; }
        public StryfesPeace StryfesPeace { get; set; }
        public HerosBlade HerosBlade { get; set; }
        public TheSwordofStorms TheSwordofStorms { get; set; }
        public FuriesBow FuriesBow { get; set; }
        public CharmoftheAncient CharmoftheAncient { get; set; }
        public TinyTitanTree TinyTitanTree { get; set; }
        public HelmofHermes HelmofHermes { get; set; }
        public FruitofEden FruitofEden { get; set; }
        public InfluentialElixir InfluentialElixir { get; set; }
        public ShimmeringOil ShimmeringOil { get; set; }
        public ORyansCharm ORyansCharm { get; set; }
        public HeartofStorms HeartofStorms { get; set; }
        public ApolloOrb ApolloOrb { get; set; }
        public StickyFruit StickyFruit { get; set; }
        public HadesOrb HadesOrb { get; set; }
        public EarringsofPortara EarringsofPortara { get; set; }
        public AvianFeather AvianFeather { get; set; }
        public CorruptedRuneHeart CorruptedRuneHeart { get; set; }
        public DurendalSword DurendalSword { get; set; }
        public HelheimSkull HelheimSkull { get; set; }
        public OathsBurden OathsBurden { get; set; }
        public CrownoftheConstellation CrownoftheConstellation { get; set; }
        public TitaniasSceptre TitaniasSceptre { get; set; }
        public FaginsGrip FaginsGrip { get; set; }
        public RingofCalisto RingofCalisto { get; set; }
        public BladeofDamocles BladeofDamocles { get; set; }
        public HelmetofMadness HelmetofMadness { get; set; }
        public TitaniumPlating TitaniumPlating { get; set; }
        public MoonlightBracelet MoonlightBracelet { get; set; }
        public AmethystStaff AmethystStaff { get; set; }
        public SwordoftheRoyals SwordoftheRoyals { get; set; }
        public SpearitsVigil SpearitsVigil { get; set; }
        public TheCobaltPlate TheCobaltPlate { get; set; }
        public SigilsofJudgement SigilsofJudgement { get; set; }
        public FoliageoftheKeeper FoliageoftheKeeper { get; set; }
        public InvadersGjallarhorn InvadersGjallarhorn { get; set; }
        public TitansMask TitansMask { get; set; }
        public RoyalToxin RoyalToxin { get; set; }
        public LaborersPendant LaborersPendant { get; set; }
        public BringerofRagnarok BringerofRagnarok { get; set; }
        public ParchmentofForesight ParchmentofForesight { get; set; }
        public ElixirofEden ElixirofEden { get; set; }
        public HourglassoftheImpatient HourglassoftheImpatient { get; set; }
        public PhantomTimepiece PhantomTimepiece { get; set; }
        public ForbiddenScroll ForbiddenScroll { get; set; }
        public RingofFealty RingofFealty { get; set; }
        public GlacialAxe GlacialAxe { get; set; }
        public Aegis Aegis { get; set; }
        public SwampGauntlet SwampGauntlet { get; set; }
        public InfinityPendulum InfinityPendulum { get; set; }
        public GloveofKuma GloveofKuma { get; set; }
        public TitanSpear TitanSpear { get; set; }
        public OakStaff OakStaff { get; set; }
        public TheArcanaCloak TheArcanaCloak { get; set; }
        public HuntersOintment HuntersOintment { get; set; }
        public AmbrosiaElixir AmbrosiaElixir { get; set; }
        public MysticStaff MysticStaff { get; set; }
        public MysticalBeansofSenzu MysticalBeansofSenzu { get; set; }
        public EggofFortune EggofFortune { get; set; }
        public DivineChalice DivineChalice { get; set; }
        public InvadersShield InvadersShield { get; set; }
        public AxeofMuerte AxeofMuerte { get; set; }
        public EssenceoftheKitsune EssenceoftheKitsune { get; set; }
        public BootsofHermes BootsofHermes { get; set; }
        public UnboundGauntlet UnboundGauntlet { get; set; }
        public OberonPendant OberonPendant { get; set; }
        public LuckyFootofAlmiraj LuckyFootofAlmiraj { get; set; }
        public LostKingsMask LostKingsMask { get; set; }
        public StaffofRadiance StaffofRadiance { get; set; }
        public MorgelaiSword MorgelaiSword { get; set; }
        public RingingStone RingingStone { get; set; }
        public QuillofScrolls QuillofScrolls { get; set; }
        public OldKingsStamp OldKingsStamp { get; set; }
        public TheMastersSword TheMastersSword { get; set; }
        public TheMagnifier TheMagnifier { get; set; }
        public TheTreasureofFergus TheTreasureofFergus { get; set; }
        public TheWhiteDwarf TheWhiteDwarf { get; set; }
        public AramSpear AramSpear { get; set; }
        public WardoftheDarkness WardoftheDarkness { get; set; }
    }
}
