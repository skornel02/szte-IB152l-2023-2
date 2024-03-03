using System.ComponentModel.DataAnnotations;

namespace Backend.Persistance.Entities;

public class EmailQueueEntity
{
    public int Id { get; set; }
    [StringLength(100)]
    public string Title { get; set; } = default!;
    [StringLength(1000)]
    public string Content { get; set; } = default!;
    public int Priority { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? SentAt { get; set; }

    public string RecipientUserEmailAddress { get; set; } = default!;
    public UserEntity RecipientUser { get; set; } = default!;
}
