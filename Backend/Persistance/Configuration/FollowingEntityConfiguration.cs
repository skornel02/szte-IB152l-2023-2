using Backend.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistance.Configuration;

public class FollowingEntityConfiguration : IEntityTypeConfiguration<FollowingEntity>
{
    public void Configure(EntityTypeBuilder<FollowingEntity> builder)
    {
        builder.HasKey(
            nameof(FollowingEntity.FollowedUserEmailAddress), 
            nameof(FollowingEntity.FollowerUserEmailAddress));

        builder.HasOne(_ => _.FollowedUser)
            .WithMany(_ => _.Followers)
            .HasForeignKey(_ => _.FollowedUserEmailAddress)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(_ => _.FollowerUser)
            .WithMany(_ => _.Followings)
            .HasForeignKey(_ => _.FollowerUserEmailAddress)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
