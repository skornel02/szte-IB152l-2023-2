using System.Diagnostics.CodeAnalysis;

namespace Backend.Persistance.Entities;

public class CommentEntity
{
    public int Id { get; set; }
    public string Content { get; set; } = default!;
    public DateTime CreationDate { get; set; }

    public string CreatorUserEmailAddress { get; set; } = default!;
    public UserEntity CreatorUser { get; set; } = default!;

    public int? CommentedOnPostId { get; set; }
    public PostEntity? CommentedOnPost { get; set; }

    public int? CommentedOnPoetryId { get; set; }
    public PoetryEntity? CommentedOnPoetry { get; set; }

    [MemberNotNullWhen(true, nameof(CommentedOnPoetryId))]
    [MemberNotNullWhen(true, nameof(CommentedOnPoetry))]
    [MemberNotNullWhen(false, nameof(CommentedOnPostId))]
    [MemberNotNullWhen(false, nameof(CommentedOnPost))]
    public bool IsPoetry => CommentedOnPoetryId != null;
}
