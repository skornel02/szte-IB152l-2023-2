namespace Backend.Persistance.Entities;

public class EmailQueueEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string Content { get; set; } = default!;
    public int Priority { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? SentAt { get; set; }

    public string RecipientUserEmailAddress { get; set; } = default!;
    public UserEntity RecipientUser { get; set; } = default!;
}
