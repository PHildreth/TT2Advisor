using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TT2Advisor.RaidCards
{
    public enum RaidCardTypeEnum
    {
        [Display(Name = "Moon Beam")] MoonBeam,
        [Display(Name = "Razor Wind")] RazorWind,
    }
}
