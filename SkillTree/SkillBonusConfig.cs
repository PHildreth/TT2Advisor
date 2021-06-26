using System;
using System.Collections.Generic;
using System.Text;
using TT2Advisor.Common.Enums;

namespace TT2Advisor.SkillTree
{
    class SkillBonusConfig
    {
    }


    public interface ISkillBonusType { }
    public interface IGoldSkillBonusType : ISkillBonusType
    {
        public GoldSourceTypeEnum GoldSourceType { get; }
    }

    public interface IDamageSkillBonusType : ISkillBonusType 
    { 
        public DamageTypeEnum DamageType { get; }
    }

    public class BonusType
    {
        public BonusType(double bonusAmount)
        {
            BonusAmount = bonusAmount;
        }

        public double BonusAmount { get; set; }
    }

    public class TapDamage : BonusType, IDamageSkillBonusType
    {
        public TapDamage(double bonusAmount) : base(bonusAmount) { }
        public DamageTypeEnum DamageType => DamageTypeEnum.TapDamage;
    }

}
