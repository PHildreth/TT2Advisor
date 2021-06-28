using TT2Advisor.Common.Enums;

namespace TT2Advisor.Common.Interfaces
{
    public interface IArtifact
    {
        static string Name { get; set; }
        static ArtifactTypeEnum ArtifactType { get; }
        string Enchanted { get; }
        string Level { get; }
        static double AllArtifactDamage { get; }
        static double NextAllArtifactDamage { get; }
        static ArtifactBonusTypeEnum BonusType { get; }
        static double BonusAmount { get; }
        static double NextBonusAmount { get; }
        static string FriendlyName { get; }
    }
}
