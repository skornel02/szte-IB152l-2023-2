using System.ComponentModel.DataAnnotations;

namespace Backend.Persistance.Entities;

public class PoetryEntity
{
    public int Id { get; set; }
    [StringLength(1000)]
    public string Content { get; set; } = default!;
    public DateTime CreationDate { get; set; }

    public string CreatorUserEmailAddress { get; set; } = default!;
    public UserEntity CreatorUser { get; set; } = default!;

    public List<CommentEntity> Comments { get; set; } = default!;
    public List<EngagementEntity> Engagements { get; set; } = default!;
}
