namespace Backend.Persistance.Entities;

public class FollowingEntity
{
    public string FollowerUserEmailAddress { get; set; } = default!;
    public UserEntity FollowerUser { get; set; } = default!;

    public string FollowedUserEmailAddress { get; set; } = default!;
    public UserEntity FollowedUser { get; set; } = default!;
}
