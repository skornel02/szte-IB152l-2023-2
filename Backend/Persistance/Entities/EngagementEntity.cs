using System.Diagnostics.CodeAnalysis;

namespace Backend.Persistance.Entities;

public class EngagementEntity
{
    public int Id { get; set; }
    public DateTime CreationDate { get; set; }

    public string CreatorUserEmailAddress { get; set; } = default!;
    public UserEntity CreatorUser { get; set; } = default!;

    public int? EngagedWithPostId { get; set; }
    public PostEntity? EngagedWithPost { get; set; }

    public int? EngagedWithPoetryId { get; set; }
    public PoetryEntity? EngagedWithPoetry { get; set; }

    [MemberNotNullWhen(true, nameof(EngagedWithPoetryId))]
    [MemberNotNullWhen(true, nameof(EngagedWithPoetry))]
    [MemberNotNullWhen(false, nameof(EngagedWithPostId))]
    [MemberNotNullWhen(false, nameof(EngagedWithPost))]
    public bool IsPoetry => EngagedWithPoetryId != null;
}
