using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TT2Advisor.Equipment;
using TT2Advisor.Equipment.EquipmentSets;
//using static TT2Advisor.Equipment.EquipmentSetsRepo;

namespace TT2Advisor.PlayerBuild
{
    public class EquipmentSets
    {
        //public EquipmentSets(JToken equipmentSetsToken)
        //{
        //    var tokens = equipmentSetsToken.SelectTokens("[*]");
        //    var convertedTokens = tokens.Select(t => t.ToString());
        //    //var eqSets = convertedTokens.Select(t => new EquipmentSet(t));
        //    //Owned = eqSets.ToList();

        //    if (convertedTokens.Contains("The Fallen Angel")) TheFallenAngel = new TheFallenAngel("The Fallen Angel");
        //}

        public EquipmentSets(string[] equipmentSets)
        {
            //if (equipmentSets.Contains("RuthlessNecromancer")) RuthlessNecromancer = new RuthlessNecromancer();
            //if (equipmentSets.Contains("AngelicGuardian")) AngelicGuardian = new AngelicGuardian();
            //if (equipmentSets.Contains("TreasureHunter")) TreasureHunter = new TreasureHunter();
            //if (equipmentSets.Contains("DarkPredator")) DarkPredator = new DarkPredator();
            //if (equipmentSets.Contains("FatalSamurai")) FatalSamurai = new FatalSamurai();
            //if (equipmentSets.Contains("AncientWarrior")) AncientWarrior = new AncientWarrior();
            //if (equipmentSets.Contains("AnniversaryGold")) AnniversaryGold = new AnniversaryGold();
            //if (equipmentSets.Contains("PhantomPresence")) PhantomPresence = new PhantomPresence();
            //if (equipmentSets.Contains("CyberneticEnhancements")) CyberneticEnhancements = new CyberneticEnhancements();
            //if (equipmentSets.Contains("DragonSlayer")) DragonSlayer = new DragonSlayer();
            //if (equipmentSets.Contains("CorruptEmeraldKnight")) CorruptEmeraldKnight = new CorruptEmeraldKnight();
            //if (equipmentSets.Contains("DefenderoftheEgg")) DefenderoftheEgg = new DefenderoftheEgg();
            //if (equipmentSets.Contains("TheHeartbreaker")) TheHeartbreaker = new TheHeartbreaker();
            //if (equipmentSets.Contains("SnowMaster")) SnowMaster = new SnowMaster();
            //if (equipmentSets.Contains("MidnightRaven")) MidnightRaven = new MidnightRaven();
            //if (equipmentSets.Contains("TheRockstar")) TheRockstar = new TheRockstar();
            //if (equipmentSets.Contains("SurfStrike")) SurfStrike = new SurfStrike();
            //if (equipmentSets.Contains("VikingKing")) VikingKing = new VikingKing();
            //if (equipmentSets.Contains("TheSlyWolf")) TheSlyWolf = new TheSlyWolf();
            //if (equipmentSets.Contains("AmazonPrincess")) AmazonPrincess = new AmazonPrincess();
            //if (equipmentSets.Contains("HeartlyQueen")) HeartlyQueen = new HeartlyQueen();
            //if (equipmentSets.Contains("CaptainTitan")) CaptainTitan = new CaptainTitan();
            //if (equipmentSets.Contains("ChainedClockwork")) ChainedClockwork = new ChainedClockwork();
            //if (equipmentSets.Contains("SolarParagon")) SolarParagon = new SolarParagon();
            //if (equipmentSets.Contains("FrostWarden")) FrostWarden = new FrostWarden();
            //if (equipmentSets.Contains("ToxicSlayer")) ToxicSlayer = new ToxicSlayer();
            //if (equipmentSets.Contains("DefiantSpellslinger")) DefiantSpellslinger = new DefiantSpellslinger();
            //if (equipmentSets.Contains("TitanAttacker")) TitanAttacker = new TitanAttacker();
            //if (equipmentSets.Contains("ScarecrowJack")) ScarecrowJack = new ScarecrowJack();
            //if (equipmentSets.Contains("SledSeason")) SledSeason = new SledSeason();
            //if (equipmentSets.Contains("ShadowDisciple")) ShadowDisciple = new ShadowDisciple();
            //if (equipmentSets.Contains("AnniversaryPlatinum")) AnniversaryPlatinum = new AnniversaryPlatinum();
            //if (equipmentSets.Contains("MechanizedSword")) MechanizedSword = new MechanizedSword();
            //if (equipmentSets.Contains("LunarFestival")) LunarFestival = new LunarFestival();
            //if (equipmentSets.Contains("EternalMonk")) EternalMonk = new EternalMonk();
            //if (equipmentSets.Contains("ThunderingDeity")) ThunderingDeity = new ThunderingDeity();
            //if (equipmentSets.Contains("BlessedBishop")) BlessedBishop = new BlessedBishop();
            //if (equipmentSets.Contains("NobleFencer")) NobleFencer = new NobleFencer();
            if (equipmentSets.Contains("The Fallen Angel")) TheFallenAngel = new TheFallenAngel();
            //if (equipmentSets.Contains("DedicatedFan")) DedicatedFan = new DedicatedFan();
            //if (equipmentSets.Contains("BoneMender")) BoneMender = new BoneMender();
            //if (equipmentSets.Contains("CelestialEnchanter")) CelestialEnchanter = new CelestialEnchanter();
            //if (equipmentSets.Contains("JackFrost")) JackFrost = new JackFrost();
            //if (equipmentSets.Contains("AnniversaryDiamond")) AnniversaryDiamond = new AnniversaryDiamond();
            //if (equipmentSets.Contains("NimbleHunter")) NimbleHunter = new NimbleHunter();
            //if (equipmentSets.Contains("SweetsandTreats")) SweetsandTreats = new SweetsandTreats();
            //if (equipmentSets.Contains("HiddenViper")) HiddenViper = new HiddenViper();
            //if (equipmentSets.Contains("HeirofShadows")) HeirofShadows = new HeirofShadows();
            //if (equipmentSets.Contains("HeirofLight")) HeirofLight = new HeirofLight();
            //if (equipmentSets.Contains("IgnustheVolcanicPhoenix")) IgnustheVolcanicPhoenix = new IgnustheVolcanicPhoenix();
            //if (equipmentSets.Contains("IronhearttheCracklingTiger")) IronhearttheCracklingTiger = new IronhearttheCracklingTiger();
            //if (equipmentSets.Contains("KortheWhisperingWave")) KortheWhisperingWave = new KortheWhisperingWave();
            //if (equipmentSets.Contains("StyxsistheSingleTouch")) StyxsistheSingleTouch = new StyxsistheSingleTouch();
            //if (equipmentSets.Contains("DigitalIdol")) DigitalIdol = new DigitalIdol();
            //if (equipmentSets.Contains("AzureKnight")) AzureKnight = new AzureKnight();
            //if (equipmentSets.Contains("RecklessFirepower")) RecklessFirepower = new RecklessFirepower();
            //if (equipmentSets.Contains("GoldenMonarch")) GoldenMonarch = new GoldenMonarch();
            //if (equipmentSets.Contains("BeastRancher")) BeastRancher = new BeastRancher();
            //if (equipmentSets.Contains("BlackKnight")) BlackKnight = new BlackKnight();
            //if (equipmentSets.Contains("AnniversaryJade")) AnniversaryJade = new AnniversaryJade();
            //if (equipmentSets.Contains("SpartanChampion")) SpartanChampion = new SpartanChampion();
            //if (equipmentSets.Contains("ImmaculateArbiter")) ImmaculateArbiter = new ImmaculateArbiter();
            //if (equipmentSets.Contains("LoveStruck")) LoveStruck = new LoveStruck();
            //if (equipmentSets.Contains("SavagePyromancer")) SavagePyromancer = new SavagePyromancer();
            //if (equipmentSets.Contains("BraveMinstrel")) BraveMinstrel = new BraveMinstrel();
            //if (equipmentSets.Contains("ForsakenBattlemage")) ForsakenBattlemage = new ForsakenBattlemage();
            //if (equipmentSets.Contains("InspiringCaptain")) InspiringCaptain = new InspiringCaptain();
            //if (equipmentSets.Contains("CutthroatRazorfist")) CutthroatRazorfist = new CutthroatRazorfist();
            //if (equipmentSets.Contains("RockQueen")) RockQueen = new RockQueen();

        }

        //public RuthlessNecromancer RuthlessNecromancer { get; set; }
        //public AngelicGuardian AngelicGuardian { get; set; }
        //public TreasureHunter TreasureHunter { get; set; }
        //public DarkPredator DarkPredator { get; set; }
        //public FatalSamurai FatalSamurai { get; set; }
        //public AncientWarrior AncientWarrior { get; set; }
        //public AnniversaryGold AnniversaryGold { get; set; }
        //public PhantomPresence PhantomPresence { get; set; }
        //public CyberneticEnhancements CyberneticEnhancements { get; set; }
        //public DragonSlayer DragonSlayer { get; set; }
        //public CorruptEmeraldKnight CorruptEmeraldKnight { get; set; }
        //public DefenderoftheEgg DefenderoftheEgg { get; set; }
        //public TheHeartbreaker TheHeartbreaker { get; set; }
        //public SnowMaster SnowMaster { get; set; }
        //public MidnightRaven MidnightRaven { get; set; }
        //public TheRockstar TheRockstar { get; set; }
        //public SurfStrike SurfStrike { get; set; }
        //public VikingKing VikingKing { get; set; }
        //public TheSlyWolf TheSlyWolf { get; set; }
        //public AmazonPrincess AmazonPrincess { get; set; }
        //public HeartlyQueen HeartlyQueen { get; set; }
        //public CaptainTitan CaptainTitan { get; set; }
        //public ChainedClockwork ChainedClockwork { get; set; }
        //public SolarParagon SolarParagon { get; set; }
        //public FrostWarden FrostWarden { get; set; }
        //public ToxicSlayer ToxicSlayer { get; set; }
        //public DefiantSpellslinger DefiantSpellslinger { get; set; }
        //public TitanAttacker TitanAttacker { get; set; }
        //public ScarecrowJack ScarecrowJack { get; set; }
        //public SledSeason SledSeason { get; set; }
        //public ShadowDisciple ShadowDisciple { get; set; }
        //public AnniversaryPlatinum AnniversaryPlatinum { get; set; }
        //public MechanizedSword MechanizedSword { get; set; }
        //public LunarFestival LunarFestival { get; set; }
        //public EternalMonk EternalMonk { get; set; }
        //public ThunderingDeity ThunderingDeity { get; set; }
        //public BlessedBishop BlessedBishop { get; set; }
        //public NobleFencer NobleFencer { get; set; }
        public TheFallenAngel TheFallenAngel { get; set; }
        //public DedicatedFan DedicatedFan { get; set; }
        //public BoneMender BoneMender { get; set; }
        //public CelestialEnchanter CelestialEnchanter { get; set; }
        //public JackFrost JackFrost { get; set; }
        //public AnniversaryDiamond AnniversaryDiamond { get; set; }
        //public NimbleHunter NimbleHunter { get; set; }
        //public SweetsandTreats SweetsandTreats { get; set; }
        //public HiddenViper HiddenViper { get; set; }
        //public HeirofShadows HeirofShadows { get; set; }
        //public HeirofLight HeirofLight { get; set; }
        //public IgnustheVolcanicPhoenix IgnustheVolcanicPhoenix { get; set; }
        //public IronhearttheCracklingTiger IronhearttheCracklingTiger { get; set; }
        //public KortheWhisperingWave KortheWhisperingWave { get; set; }
        //public StyxsistheSingleTouch StyxsistheSingleTouch { get; set; }
        //public DigitalIdol DigitalIdol { get; set; }
        //public AzureKnight AzureKnight { get; set; }
        //public RecklessFirepower RecklessFirepower { get; set; }
        //public GoldenMonarch GoldenMonarch { get; set; }
        //public BeastRancher BeastRancher { get; set; }
        //public BlackKnight BlackKnight { get; set; }
        //public AnniversaryJade AnniversaryJade { get; set; }
        //public SpartanChampion SpartanChampion { get; set; }
        //public ImmaculateArbiter ImmaculateArbiter { get; set; }
        //public LoveStruck LoveStruck { get; set; }
        //public SavagePyromancer SavagePyromancer { get; set; }
        //public BraveMinstrel BraveMinstrel { get; set; }
        //public ForsakenBattlemage ForsakenBattlemage { get; set; }
        //public InspiringCaptain InspiringCaptain { get; set; }
        //public CutthroatRazorfist CutthroatRazorfist { get; set; }
        //public RockQueen RockQueen { get; set; }

    }
}
