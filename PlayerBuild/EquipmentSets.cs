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

        public IEquipmentSet RuthlessNecromancer { get; set; }
        public IEquipmentSet AngelicGuardian { get; set; }
        public IEquipmentSet TreasureHunter { get; set; }
        public IEquipmentSet DarkPredator { get; set; }
        public IEquipmentSet FatalSamurai { get; set; }
        public IEquipmentSet AncientWarrior { get; set; }
        public IEquipmentSet AnniversaryGold { get; set; }
        public IEquipmentSet PhantomPresence { get; set; }
        public IEquipmentSet CyberneticEnhancements { get; set; }
        public IEquipmentSet DragonSlayer { get; set; }
        public IEquipmentSet CorruptEmeraldKnight { get; set; }
        public IEquipmentSet DefenderoftheEgg { get; set; }
        public IEquipmentSet TheHeartbreaker { get; set; }
        public IEquipmentSet SnowMaster { get; set; }
        public IEquipmentSet MidnightRaven { get; set; }
        public IEquipmentSet TheRockstar { get; set; }
        public IEquipmentSet SurfStrike { get; set; }
        public IEquipmentSet VikingKing { get; set; }
        public IEquipmentSet TheSlyWolf { get; set; }
        public IEquipmentSet AmazonPrincess { get; set; }
        public IEquipmentSet HeartlyQueen { get; set; }
        public IEquipmentSet CaptainTitan { get; set; }
        public IEquipmentSet ChainedClockwork { get; set; }
        public IEquipmentSet SolarParagon { get; set; }
        public IEquipmentSet FrostWarden { get; set; }
        public IEquipmentSet ToxicSlayer { get; set; }
        public IEquipmentSet DefiantSpellslinger { get; set; }
        public IEquipmentSet TitanAttacker { get; set; }
        public IEquipmentSet ScarecrowJack { get; set; }
        public IEquipmentSet SledSeason { get; set; }
        public IEquipmentSet ShadowDisciple { get; set; }
        public IEquipmentSet AnniversaryPlatinum { get; set; }
        public IEquipmentSet MechanizedSword { get; set; }
        public IEquipmentSet LunarFestival { get; set; }
        public IEquipmentSet EternalMonk { get; set; }
        public IEquipmentSet ThunderingDeity { get; set; }
        public IEquipmentSet BlessedBishop { get; set; }
        public IEquipmentSet NobleFencer { get; set; }
        public IEquipmentSet TheFallenAngel { get; set; }
        public IEquipmentSet DedicatedFan { get; set; }
        public IEquipmentSet BoneMender { get; set; }
        public IEquipmentSet CelestialEnchanter { get; set; }
        public IEquipmentSet JackFrost { get; set; }
        public IEquipmentSet AnniversaryDiamond { get; set; }
        public IEquipmentSet NimbleHunter { get; set; }
        public IEquipmentSet SweetsandTreats { get; set; }
        public IEquipmentSet HiddenViper { get; set; }
        public IEquipmentSet HeirofShadows { get; set; }
        public IEquipmentSet HeirofLight { get; set; }
        public IEquipmentSet IgnustheVolcanicPhoenix { get; set; }
        public IEquipmentSet IronhearttheCracklingTiger { get; set; }
        public IEquipmentSet KortheWhisperingWave { get; set; }
        public IEquipmentSet StyxsistheSingleTouch { get; set; }
        public IEquipmentSet DigitalIdol { get; set; }
        public IEquipmentSet AzureKnight { get; set; }
        public IEquipmentSet RecklessFirepower { get; set; }
        public IEquipmentSet GoldenMonarch { get; set; }
        public IEquipmentSet BeastRancher { get; set; }
        public IEquipmentSet BlackKnight { get; set; }
        public IEquipmentSet AnniversaryJade { get; set; }
        public IEquipmentSet SpartanChampion { get; set; }
        public IEquipmentSet ImmaculateArbiter { get; set; }
        public IEquipmentSet LoveStruck { get; set; }
        public IEquipmentSet SavagePyromancer { get; set; }
        public IEquipmentSet BraveMinstrel { get; set; }
        public IEquipmentSet ForsakenBattlemage { get; set; }
        public IEquipmentSet InspiringCaptain { get; set; }
        public IEquipmentSet CutthroatRazorfist { get; set; }
        public IEquipmentSet RockQueen { get; set; }


    }
}
