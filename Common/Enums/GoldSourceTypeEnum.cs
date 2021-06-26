using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TT2Advisor.Common.Enums
{
    public enum GoldSourceTypeEnum
    {
        [Display(Name = "All Gold")] AllGold,
        [Display(Name = "Boss Gold")] BossGold,
        [Display(Name = "Chesterson Gold")] ChestersonGold,
        [Display(Name = "Stealth Gold")] StealthGold,
    }

    public enum ArmorGoldSourceTypeEnum
    {
        AllGold = GoldSourceTypeEnum.AllGold,
        BossGold = GoldSourceTypeEnum.BossGold,
        ChestersonGold = GoldSourceTypeEnum.ChestersonGold,
        StealthGold = GoldSourceTypeEnum.StealthGold,
    }
}
