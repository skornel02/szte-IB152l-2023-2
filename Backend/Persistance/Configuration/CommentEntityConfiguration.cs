using Backend.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistance.Configuration;

public class CommentEntityConfiguration : IEntityTypeConfiguration<CommentEntity>
{
    public void Configure(EntityTypeBuilder<CommentEntity> builder)
    {
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();

        builder.HasOne(_ => _.CreatorUser)
            .WithMany(_ => _.Comments)
            .HasForeignKey(_ => _.CreatorUserEmailAddress)
            .IsRequired(true)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(_ => _.CommentedOnPoetry)
            .WithMany(_ => _.Comments)
            .HasForeignKey(_ => _.CommentedOnPoetryId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(_ => _.CommentedOnPost)
            .WithMany(_ => _.Comments)
            .HasForeignKey(_ => _.CommentedOnPoetryId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
