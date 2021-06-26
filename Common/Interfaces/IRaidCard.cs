using System;
using System.Collections.Generic;
using System.Text;
using TT2Advisor.Common.Enums;

namespace TT2Advisor.Common.Interfaces
{
    public interface IRaidCard
    {
        public static RaidCardTypeEnum RaidCardType { get; }
        public int Level { get; }
        public int Cards { get; }
        public static string FriendlyName { get; }
    }
}
