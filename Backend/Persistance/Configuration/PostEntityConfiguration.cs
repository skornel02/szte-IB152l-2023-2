using Backend.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistance.Configuration;

public class PostEntityConfiguration : IEntityTypeConfiguration<PostEntity>
{
    public void Configure(EntityTypeBuilder<PostEntity> builder)
    {
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();

        builder.HasOne(_ => _.CreatorUser)
            .WithMany(_ => _.Posts)
            .HasForeignKey(_ => _.CreatorUserEmailAddress)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
