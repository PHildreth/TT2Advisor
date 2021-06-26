using TT2Advisor.Common.Enums;

namespace TT2Advisor.Common.Interfaces
{
    public interface IArtifact
    {
        public static ArtifactTypeEnum ArtifactType { get; }
        public string Enchanted { get; }
        public string Level { get; }
        public static double AllArtifactDamage { get; }
        public static double NextAllArtifactDamage { get; }
        public static ArtifactBonusTypeEnum BonusType { get; }
        public static double BonusAmount { get; }
        public static double NextBonusAmount { get; }
        static string FriendlyName { get; }
    }
}
