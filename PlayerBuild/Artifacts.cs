using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using TT2Advisor.Artifacts;
using TT2Advisor.Common.Interfaces;
using static TT2Advisor.Artifacts.ArtifactsRepo;

namespace TT2Advisor.PlayerBuild
{
    public class Artifacts
    {
        //public Artifacts(JToken artifactsToken)
        //{
        //    BookofShadows = new BookofShadows(artifactsToken.SelectToken("['Book of Shadows']"));
        //    ChargedCard = new ChargedCard(artifactsToken.SelectToken("['Charged Card']"));
        //    StoneoftheValrunes = new StoneoftheValrunes(artifactsToken.SelectToken("['Stone of the Valrunes']"));
        //    ChestofContentment = new ChestofContentment(artifactsToken.SelectToken("['Chest of Contentment']"));
        //    HeroicShield = new HeroicShield(artifactsToken.SelectToken("['Heroic Shield']"));
        //    BookofProphecy = new BookofProphecy(artifactsToken.SelectToken("['Book of Prophecy']"));
        //    KhrysosBowl = new KhrysosBowl(artifactsToken.SelectToken("['Khrysos Bowl']"));
        //    ZakynthosCoin = new ZakynthosCoin(artifactsToken.SelectToken("['Zakynthos Coin']"));
        //    GreatFayMedallion = new GreatFayMedallion(artifactsToken.SelectToken("['Great Fay Medallion']"));
        //    NekoSculpture = new NekoSculpture(artifactsToken.SelectToken("['Neko Sculpture']"));
        //    CoinsofEbizu = new CoinsofEbizu(artifactsToken.SelectToken("['Coins of Ebizu']"));
        //    TheBronzedCompass = new TheBronzedCompass(artifactsToken.SelectToken("['The Bronzed Compass']"));
        //    EvergrowingStack = new EvergrowingStack(artifactsToken.SelectToken("['Evergrowing Stack']"));
        //    FluteoftheSoloist = new FluteoftheSoloist(artifactsToken.SelectToken("['Flute of the Soloist']"));
        //    HeavenlySword = new HeavenlySword(artifactsToken.SelectToken("['Heavenly Sword']"));
        //    DivineRetribution = new DivineRetribution(artifactsToken.SelectToken("['Divine Retribution']"));
        //    DrunkenHammer = new DrunkenHammer(artifactsToken.SelectToken("['Drunken Hammer']"));
        //    SamosekSword = new SamosekSword(artifactsToken.SelectToken("['Samosek Sword']"));
        //    TheRetaliator = new TheRetaliator(artifactsToken.SelectToken("['The Retaliator']"));
        //    StryfesPeace = new StryfesPeace(artifactsToken.SelectToken("['Stryfe\\'s Peace']"));
        //    HerosBlade = new HerosBlade(artifactsToken.SelectToken("['Hero\\'s Blade']"));
        //    TheSwordofStorms = new TheSwordofStorms(artifactsToken.SelectToken("['The Sword of Storms']"));
        //    FuriesBow = new FuriesBow(artifactsToken.SelectToken("['Furies Bow']"));
        //    CharmoftheAncient = new CharmoftheAncient(artifactsToken.SelectToken("['Charm of the Ancient']"));
        //    TinyTitanTree = new TinyTitanTree(artifactsToken.SelectToken("['Tiny Titan Tree']"));
        //    HelmofHermes = new HelmofHermes(artifactsToken.SelectToken("['Helm of Hermes']"));
        //    FruitofEden = new FruitofEden(artifactsToken.SelectToken("['Fruit of Eden']"));
        //    InfluentialElixir = new InfluentialElixir(artifactsToken.SelectToken("['Influential Elixir']"));
        //    ShimmeringOil = new ShimmeringOil(artifactsToken.SelectToken("['Shimmering Oil']"));
        //    ORyansCharm = new ORyansCharm(artifactsToken.SelectToken("['O\\'Ryan\\'s Charm']"));
        //    HeartofStorms = new HeartofStorms(artifactsToken.SelectToken("['Heart of Storms']"));
        //    ApolloOrb = new ApolloOrb(artifactsToken.SelectToken("['Apollo Orb']"));
        //    StickyFruit = new StickyFruit(artifactsToken.SelectToken("['Sticky Fruit']"));
        //    HadesOrb = new HadesOrb(artifactsToken.SelectToken("['Hades Orb']"));
        //    EarringsofPortara = new EarringsofPortara(artifactsToken.SelectToken("['Earrings of Portara']"));
        //    AvianFeather = new AvianFeather(artifactsToken.SelectToken("['Avian Feather']"));
        //    CorruptedRuneHeart = new CorruptedRuneHeart(artifactsToken.SelectToken("['Corrupted Rune Heart']"));
        //    DurendalSword = new DurendalSword(artifactsToken.SelectToken("['Durendal Sword']"));
        //    HelheimSkull = new HelheimSkull(artifactsToken.SelectToken("['Helheim Skull']"));
        //    OathsBurden = new OathsBurden(artifactsToken.SelectToken("['Oath\\'s Burden']"));
        //    CrownoftheConstellation = new CrownoftheConstellation(artifactsToken.SelectToken("['Crown of the Constellation']"));
        //    TitaniasSceptre = new TitaniasSceptre(artifactsToken.SelectToken("['Titania\\'s Sceptre']"));
        //    FaginsGrip = new FaginsGrip(artifactsToken.SelectToken("['Fagin\\'s Grip']"));
        //    RingofCalisto = new RingofCalisto(artifactsToken.SelectToken("['Ring of Calisto']"));
        //    BladeofDamocles = new BladeofDamocles(artifactsToken.SelectToken("['Blade of Damocles']"));
        //    HelmetofMadness = new HelmetofMadness(artifactsToken.SelectToken("['Helmet of Madness']"));
        //    TitaniumPlating = new TitaniumPlating(artifactsToken.SelectToken("['Titanium Plating']"));
        //    MoonlightBracelet = new MoonlightBracelet(artifactsToken.SelectToken("['Moonlight Bracelet']"));
        //    AmethystStaff = new AmethystStaff(artifactsToken.SelectToken("['Amethyst Staff']"));
        //    SwordoftheRoyals = new SwordoftheRoyals(artifactsToken.SelectToken("['Sword of the Royals']"));
        //    SpearitsVigil = new SpearitsVigil(artifactsToken.SelectToken("['Spearit\\'s Vigil']"));
        //    TheCobaltPlate = new TheCobaltPlate(artifactsToken.SelectToken("['The Cobalt Plate']"));
        //    SigilsofJudgement = new SigilsofJudgement(artifactsToken.SelectToken("['Sigils of Judgement']"));
        //    FoliageoftheKeeper = new FoliageoftheKeeper(artifactsToken.SelectToken("['Foliage of the Keeper']"));
        //    InvadersGjallarhorn = new InvadersGjallarhorn(artifactsToken.SelectToken("['Invader\\'s Gjallarhorn']"));
        //    TitansMask = new TitansMask(artifactsToken.SelectToken("['Titan\\'s Mask']"));
        //    RoyalToxin = new RoyalToxin(artifactsToken.SelectToken("['Royal Toxin']"));
        //    LaborersPendant = new LaborersPendant(artifactsToken.SelectToken("['Laborer\\'s Pendant']"));
        //    BringerofRagnarok = new BringerofRagnarok(artifactsToken.SelectToken("['Bringer of Ragnarok']"));
        //    ParchmentofForesight = new ParchmentofForesight(artifactsToken.SelectToken("['Parchment of Foresight']"));
        //    ElixirofEden = new ElixirofEden(artifactsToken.SelectToken("['Elixir of Eden']"));
        //    HourglassoftheImpatient = new HourglassoftheImpatient(artifactsToken.SelectToken("['Hourglass of the Impatient']"));
        //    PhantomTimepiece = new PhantomTimepiece(artifactsToken.SelectToken("['Phantom Timepiece']"));
        //    ForbiddenScroll = new ForbiddenScroll(artifactsToken.SelectToken("['Forbidden Scroll']"));
        //    RingofFealty = new RingofFealty(artifactsToken.SelectToken("['Ring of Fealty']"));
        //    GlacialAxe = new GlacialAxe(artifactsToken.SelectToken("['Glacial Axe']"));
        //    Aegis = new Aegis(artifactsToken.SelectToken("['Aegis']"));
        //    SwampGauntlet = new SwampGauntlet(artifactsToken.SelectToken("['Swamp Gauntlet']"));
        //    InfinityPendulum = new InfinityPendulum(artifactsToken.SelectToken("['Infinity Pendulum']"));
        //    GloveofKuma = new GloveofKuma(artifactsToken.SelectToken("['Glove of Kuma']"));
        //    TitanSpear = new TitanSpear(artifactsToken.SelectToken("['Titan Spear']"));
        //    OakStaff = new OakStaff(artifactsToken.SelectToken("['Oak Staff']"));
        //    TheArcanaCloak = new TheArcanaCloak(artifactsToken.SelectToken("['The Arcana Cloak']"));
        //    HuntersOintment = new HuntersOintment(artifactsToken.SelectToken("['Hunter\\'s Ointment']"));
        //    AmbrosiaElixir = new AmbrosiaElixir(artifactsToken.SelectToken("['Ambrosia Elixir']"));
        //    MysticStaff = new MysticStaff(artifactsToken.SelectToken("['Mystic Staff']"));
        //    MysticalBeansofSenzu = new MysticalBeansofSenzu(artifactsToken.SelectToken("['Mystical Beans of Senzu']"));
        //    EggofFortune = new EggofFortune(artifactsToken.SelectToken("['Egg of Fortune']"));
        //    DivineChalice = new DivineChalice(artifactsToken.SelectToken("['Divine Chalice']"));
        //    InvadersShield = new InvadersShield(artifactsToken.SelectToken("['Invader\\'s Shield']"));
        //    AxeofMuerte = new AxeofMuerte(artifactsToken.SelectToken("['Axe of Muerte']"));
        //    EssenceoftheKitsune = new EssenceoftheKitsune(artifactsToken.SelectToken("['Essence of the Kitsune']"));
        //    BootsofHermes = new BootsofHermes(artifactsToken.SelectToken("['Boots of Hermes']"));
        //    UnboundGauntlet = new UnboundGauntlet(artifactsToken.SelectToken("['Unbound Gauntlet']"));
        //    OberonPendant = new OberonPendant(artifactsToken.SelectToken("['Oberon Pendant']"));
        //    LuckyFootofAlmiraj = new LuckyFootofAlmiraj(artifactsToken.SelectToken("['Lucky Foot of Al-mi\\'raj']"));
        //    LostKingsMask = new LostKingsMask(artifactsToken.SelectToken("['Lost King\\'s Mask']"));
        //    StaffofRadiance = new StaffofRadiance(artifactsToken.SelectToken("['Staff of Radiance']"));
        //    MorgelaiSword = new MorgelaiSword(artifactsToken.SelectToken("['Morgelai Sword']"));
        //    RingingStone = new RingingStone(artifactsToken.SelectToken("['Ringing Stone']"));
        //    QuillofScrolls = new QuillofScrolls(artifactsToken.SelectToken("['Quill of Scrolls']"));
        //    OldKingsStamp = new OldKingsStamp(artifactsToken.SelectToken("['Old King\\'s Stamp']"));
        //    TheMastersSword = new TheMastersSword(artifactsToken.SelectToken("['The Master\\'s Sword']"));
        //    TheMagnifier = new TheMagnifier(artifactsToken.SelectToken("['The Magnifier']"));
        //    TheTreasureofFergus = new TheTreasureofFergus(artifactsToken.SelectToken("['The Treasure of Fergus']"));
        //    TheWhiteDwarf = new TheWhiteDwarf(artifactsToken.SelectToken("['The White Dwarf']"));
        //    AramSpear = new AramSpear(artifactsToken.SelectToken("['Aram Spear']"));
        //    WardoftheDarkness = new WardoftheDarkness(artifactsToken.SelectToken("['Ward of the Darkness']"));
        //}

        public Artifacts(Import.Artifacts artifacts)
        {
            BookofShadows = new BookofShadows(artifacts.BookofShadows);
            ChargedCard = artifacts.ChargedCard;
            StoneoftheValrunes = artifacts.StoneoftheValrunes;
            ChestofContentment = artifacts.ChestofContentment;
            HeroicShield = artifacts.HeroicShield;
            BookofProphecy = artifacts.BookofProphecy;
            KhrysosBowl = artifacts.KhrysosBowl;
            ZakynthosCoin = artifacts.ZakynthosCoin;
            GreatFayMedallion = artifacts.GreatFayMedallion;
            NekoSculpture = artifacts.NekoSculpture;
            CoinsofEbizu = artifacts.CoinsofEbizu;
            TheBronzedCompass = artifacts.TheBronzedCompass;
            EvergrowingStack = artifacts.EvergrowingStack;
            FluteoftheSoloist = artifacts.FluteoftheSoloist;
            HeavenlySword = artifacts.HeavenlySword;
            DivineRetribution = artifacts.DivineRetribution;
            DrunkenHammer = artifacts.DrunkenHammer;
            SamosekSword = artifacts.SamosekSword;
            TheRetaliator = artifacts.TheRetaliator;
            StryfesPeace = artifacts.StryfesPeace;
            HerosBlade = artifacts.HerosBlade;
            TheSwordofStorms = artifacts.TheSwordofStorms;
            FuriesBow = artifacts.FuriesBow;
            CharmoftheAncient = artifacts.CharmoftheAncient;
            TinyTitanTree = artifacts.TinyTitanTree;
            HelmofHermes = artifacts.HelmofHermes;
            FruitofEden = artifacts.FruitofEden;
            InfluentialElixir = artifacts.InfluentialElixir;
            ShimmeringOil = artifacts.ShimmeringOil;
            ORyansCharm = artifacts.ORyansCharm;
            HeartofStorms = artifacts.HeartofStorms;
            ApolloOrb = artifacts.ApolloOrb;
            StickyFruit = artifacts.StickyFruit;
            HadesOrb = artifacts.HadesOrb;
            EarringsofPortara = artifacts.EarringsofPortara;
            AvianFeather = artifacts.AvianFeather;
            CorruptedRuneHeart = artifacts.CorruptedRuneHeart;
            DurendalSword = artifacts.DurendalSword;
            HelheimSkull = artifacts.HelheimSkull;
            OathsBurden = artifacts.OathsBurden;
            CrownoftheConstellation = artifacts.CrownoftheConstellation;
            TitaniasSceptre = artifacts.TitaniasSceptre;
            FaginsGrip = artifacts.FaginsGrip;
            RingofCalisto = artifacts.RingofCalisto;
            BladeofDamocles = artifacts.BladeofDamocles;
            HelmetofMadness = artifacts.HelmetofMadness;
            TitaniumPlating = artifacts.TitaniumPlating;
            MoonlightBracelet = artifacts.MoonlightBracelet;
            AmethystStaff = artifacts.AmethystStaff;
            SwordoftheRoyals = artifacts.SwordoftheRoyals;
            SpearitsVigil = artifacts.SpearitsVigil;
            TheCobaltPlate = artifacts.TheCobaltPlate;
            SigilsofJudgement = artifacts.SigilsofJudgement;
            FoliageoftheKeeper = artifacts.FoliageoftheKeeper;
            InvadersGjallarhorn = artifacts.InvadersGjallarhorn;
            TitansMask = artifacts.TitansMask;
            RoyalToxin = artifacts.RoyalToxin;
            LaborersPendant = artifacts.LaborersPendant;
            BringerofRagnarok = artifacts.BringerofRagnarok;
            ParchmentofForesight = artifacts.ParchmentofForesight;
            ElixirofEden = artifacts.ElixirofEden;
            HourglassoftheImpatient = artifacts.HourglassoftheImpatient;
            PhantomTimepiece = artifacts.PhantomTimepiece;
            ForbiddenScroll = artifacts.ForbiddenScroll;
            RingofFealty = artifacts.RingofFealty;
            GlacialAxe = artifacts.GlacialAxe;
            Aegis = artifacts.Aegis;
            SwampGauntlet = artifacts.SwampGauntlet;
            InfinityPendulum = artifacts.InfinityPendulum;
            GloveofKuma = artifacts.GloveofKuma;
            TitanSpear = artifacts.TitanSpear;
            OakStaff = artifacts.OakStaff;
            TheArcanaCloak = artifacts.TheArcanaCloak;
            HuntersOintment = artifacts.HuntersOintment;
            AmbrosiaElixir = artifacts.AmbrosiaElixir;
            MysticStaff = artifacts.MysticStaff;
            MysticalBeansofSenzu = artifacts.MysticalBeansofSenzu;
            EggofFortune = artifacts.EggofFortune;
            DivineChalice = artifacts.DivineChalice;
            InvadersShield = artifacts.InvadersShield;
            AxeofMuerte = artifacts.AxeofMuerte;
            EssenceoftheKitsune = artifacts.EssenceoftheKitsune;
            BootsofHermes = artifacts.BootsofHermes;
            UnboundGauntlet = artifacts.UnboundGauntlet;
            OberonPendant = artifacts.OberonPendant;
            LuckyFootofAlmiraj = artifacts.LuckyFootofAlmiraj;
            LostKingsMask = artifacts.LostKingsMask;
            StaffofRadiance = artifacts.StaffofRadiance;
            MorgelaiSword = artifacts.MorgelaiSword;
            RingingStone = artifacts.RingingStone;
            QuillofScrolls = artifacts.QuillofScrolls;
            OldKingsStamp = artifacts.OldKingsStamp;
            TheMastersSword = artifacts.TheMastersSword;
            TheMagnifier = artifacts.TheMagnifier;
            TheTreasureofFergus = artifacts.TheTreasureofFergus;
            TheWhiteDwarf = artifacts.TheWhiteDwarf;
            AramSpear = artifacts.AramSpear;
            WardoftheDarkness = artifacts.WardoftheDarkness;

        }

        public BookofShadows BookofShadows { get; set; }
        public IArtifact ChargedCard { get; set; }
        public IArtifact StoneoftheValrunes { get; set; }
        public IArtifact ChestofContentment { get; set; }
        public IArtifact HeroicShield { get; set; }
        public IArtifact BookofProphecy { get; set; }
        public IArtifact KhrysosBowl { get; set; }
        public IArtifact ZakynthosCoin { get; set; }
        public IArtifact GreatFayMedallion { get; set; }
        public IArtifact NekoSculpture { get; set; }
        public IArtifact CoinsofEbizu { get; set; }
        public IArtifact TheBronzedCompass { get; set; }
        public IArtifact EvergrowingStack { get; set; }
        public IArtifact FluteoftheSoloist { get; set; }
        public IArtifact HeavenlySword { get; set; }
        public IArtifact DivineRetribution { get; set; }
        public IArtifact DrunkenHammer { get; set; }
        public IArtifact SamosekSword { get; set; }
        public IArtifact TheRetaliator { get; set; }
        public IArtifact StryfesPeace { get; set; }
        public IArtifact HerosBlade { get; set; }
        public IArtifact TheSwordofStorms { get; set; }
        public IArtifact FuriesBow { get; set; }
        public IArtifact CharmoftheAncient { get; set; }
        public IArtifact TinyTitanTree { get; set; }
        public IArtifact HelmofHermes { get; set; }
        public IArtifact FruitofEden { get; set; }
        public IArtifact InfluentialElixir { get; set; }
        public IArtifact ShimmeringOil { get; set; }
        public IArtifact ORyansCharm { get; set; }
        public IArtifact HeartofStorms { get; set; }
        public IArtifact ApolloOrb { get; set; }
        public IArtifact StickyFruit { get; set; }
        public IArtifact HadesOrb { get; set; }
        public IArtifact EarringsofPortara { get; set; }
        public IArtifact AvianFeather { get; set; }
        public IArtifact CorruptedRuneHeart { get; set; }
        public IArtifact DurendalSword { get; set; }
        public IArtifact HelheimSkull { get; set; }
        public IArtifact OathsBurden { get; set; }
        public IArtifact CrownoftheConstellation { get; set; }
        public IArtifact TitaniasSceptre { get; set; }
        public IArtifact FaginsGrip { get; set; }
        public IArtifact RingofCalisto { get; set; }
        public IArtifact BladeofDamocles { get; set; }
        public IArtifact HelmetofMadness { get; set; }
        public IArtifact TitaniumPlating { get; set; }
        public IArtifact MoonlightBracelet { get; set; }
        public IArtifact AmethystStaff { get; set; }
        public IArtifact SwordoftheRoyals { get; set; }
        public IArtifact SpearitsVigil { get; set; }
        public IArtifact TheCobaltPlate { get; set; }
        public IArtifact SigilsofJudgement { get; set; }
        public IArtifact FoliageoftheKeeper { get; set; }
        public IArtifact InvadersGjallarhorn { get; set; }
        public IArtifact TitansMask { get; set; }
        public IArtifact RoyalToxin { get; set; }
        public IArtifact LaborersPendant { get; set; }
        public IArtifact BringerofRagnarok { get; set; }
        public IArtifact ParchmentofForesight { get; set; }
        public IArtifact ElixirofEden { get; set; }
        public IArtifact HourglassoftheImpatient { get; set; }
        public IArtifact PhantomTimepiece { get; set; }
        public IArtifact ForbiddenScroll { get; set; }
        public IArtifact RingofFealty { get; set; }
        public IArtifact GlacialAxe { get; set; }
        public IArtifact Aegis { get; set; }
        public IArtifact SwampGauntlet { get; set; }
        public IArtifact InfinityPendulum { get; set; }
        public IArtifact GloveofKuma { get; set; }
        public IArtifact TitanSpear { get; set; }
        public IArtifact OakStaff { get; set; }
        public IArtifact TheArcanaCloak { get; set; }
        public IArtifact HuntersOintment { get; set; }
        public IArtifact AmbrosiaElixir { get; set; }
        public IArtifact MysticStaff { get; set; }
        public IArtifact MysticalBeansofSenzu { get; set; }
        public IArtifact EggofFortune { get; set; }
        public IArtifact DivineChalice { get; set; }
        public IArtifact InvadersShield { get; set; }
        public IArtifact AxeofMuerte { get; set; }
        public IArtifact EssenceoftheKitsune { get; set; }
        public IArtifact BootsofHermes { get; set; }
        public IArtifact UnboundGauntlet { get; set; }
        public IArtifact OberonPendant { get; set; }
        public IArtifact LuckyFootofAlmiraj { get; set; }
        public IArtifact LostKingsMask { get; set; }
        public IArtifact StaffofRadiance { get; set; }
        public IArtifact MorgelaiSword { get; set; }
        public IArtifact RingingStone { get; set; }
        public IArtifact QuillofScrolls { get; set; }
        public IArtifact OldKingsStamp { get; set; }
        public IArtifact TheMastersSword { get; set; }
        public IArtifact TheMagnifier { get; set; }
        public IArtifact TheTreasureofFergus { get; set; }
        public IArtifact TheWhiteDwarf { get; set; }
        public IArtifact AramSpear { get; set; }
        public IArtifact WardoftheDarkness { get; set; }
    }
}
