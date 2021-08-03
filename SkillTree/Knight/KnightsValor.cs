using System;
using System.Collections.Generic;
using System.Text;
using TT2Advisor.Common.Enums;
using TT2Advisor.Common.Interfaces;

namespace TT2Advisor.SkillTree
{
    public class KnightsValor : Skill
    {
        public KnightsValor(int level)
        {
            Level = level;
        }

        public string Name => "KnightsValor";
        public string FriendlyName => "Knight's Valor";
        public int Tier => 1;
        public int Level { get; set; }
        public int SPCost => Level switch
        {
            0 => 0,
            1 => 1,
            2 => 2,
            3 => 2,
            4 => 3,
            5 => 3,
            6 => 3,
            7 => 4,
            8 => 5,
            9 => 5,
            10 => 6,
            11 => 7,
            12 => 8,
            13 => 9,
            14 => 11,
            15 => 12,
            16 => 14,
            17 => 16,
            18 => 19,
            19 => 22,
            20 => 25,
            21 => 28,
            22 => 33,
            23 => 38,
            24 => 43,
            25 => 50,
            _ => throw new NotImplementedException(),
        };

        public List<BonusType> Bonuses
        {
            get 
            {
                var bonii = new List<BonusType>();
                
                var bon1 = new TapDamage(BonusAmount);
                bonii.Add(bon1);
                
                return bonii;
            }
        }

        public double BonusAmount => Level switch
        {
            0 => 0,
            1 => 1.2,
            2 => 1.71,
            3 => 2.43,
            4 => 3.82,
            5 => 6.02,
            6 => 9.47,
            7 => 16.4,
            8 => 31.4,
            9 => 60.1,
            10 => 126,
            11 => 290,
            12 => 728,
            13 => 2e+3,
            14 => 6.49e+3,
            15 => 2.29e+4,
            16 => 9.48e+4,
            17 => 4.59e+5,
            18 => 2.79e+6,
            19 => 2.11e+7,
            20 => 1.97e+8,
            21 => 2.27e+9,
            22 => 3.65e+10,
            23 => 8.15e+11,
            24 => 2.5e+13,
            25 => 1.19e+15,
            _ => throw new NotImplementedException(),
        };

    }
}
