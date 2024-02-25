namespace Backend.Persistance.Entities;

public class WatchListEntity
{
    public int Id { get; set; }

    public DateTime From { get; set; }
    public DateTime Until { get; set; }

    public string StalkedEmailAddress { get; set; } = default!;
    public UserEntity StalkedUser { get; set; } = default!;

    public string StalkerEmailAddress { get; set; } = default!;
    public UserEntity StalkerUser { get; set; } = default!;
}
