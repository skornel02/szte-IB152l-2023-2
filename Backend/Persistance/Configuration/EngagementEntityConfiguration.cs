using Backend.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistance.Configuration;

public class EngagementEntityConfiguration : IEntityTypeConfiguration<EngagementEntity>
{
    public void Configure(EntityTypeBuilder<EngagementEntity> builder)
    {
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();

        builder.HasOne(_ => _.CreatorUser)
            .WithMany(_ => _.Engagements)
            .HasForeignKey(_ => _.CreatorUserEmailAddress)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(_ => _.EngagedWithPost)
            .WithMany(_ => _.Engagements)
            .HasForeignKey(_ => _.EngagedWithPostId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(_ => _.EngagedWithPoetry)
            .WithMany(_ => _.Engagements)
            .HasForeignKey(_ => _.EngagedWithPoetryId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
