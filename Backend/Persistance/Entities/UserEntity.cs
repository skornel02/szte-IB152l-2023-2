namespace Backend.Persistance.Entities;

public class UserEntity
{
    public string EmailAddress { get; set; } = default!;

    public string FirstName { get; set; } = default!;
    public string MiddleName { get; set; } = default!;
    public string LastName { get; set; } = default!;

    public string PasswordHash { get; set; } = default!;
    public string Pronouns { get; set; } = default!;

    public bool UserWatcher { get; set; } 

    public List<FollowingEntity> Followings { get; set; } = default!;
    public List<FollowingEntity> Followers { get; set; } = default!;

    public List<WatchListEntity> StalkedBy { get; set; } = default!;
    public List<WatchListEntity> StalkedUsers { get; set; } = default!;

    public List<PoetryEntity> Poetries { get; set; } = default!;
    public List<PostEntity> Posts { get; set; } = default!;
    public List<CommentEntity> Comments { get; set; } = default!;
    public List<EngagementEntity> Engagements { get; set; } = default!;

    public List<EmailQueueEntity> Emails { get; set; } = default!;
}
