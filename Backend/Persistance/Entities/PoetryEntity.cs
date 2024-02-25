namespace Backend.Persistance.Entities;

public class PoetryEntity
{
    public int Id { get; set; }
    public string Content { get; set; } = default!;
    public DateTime CreationDate { get; set; }

    public string CreatorUserEmailAddress { get; set; } = default!;
    public UserEntity CreatorUser { get; set; } = default!;

    public List<CommentEntity> Comments { get; set; } = default!;
    public List<EngagementEntity> Engagements { get; set; } = default!;
}
