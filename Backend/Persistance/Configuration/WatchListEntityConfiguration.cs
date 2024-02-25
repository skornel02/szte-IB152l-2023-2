using Backend.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistance.Configuration;

public class WatchListEntityConfiguration : IEntityTypeConfiguration<WatchListEntity>
{
    public void Configure(EntityTypeBuilder<WatchListEntity> builder)
    {
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();

        builder.HasOne(_ => _.StalkedUser)
            .WithMany(_ => _.StalkedBy)
            .HasForeignKey(_ => _.StalkedEmailAddress)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(_ => _.StalkerUser)
            .WithMany(_ => _.StalkedUsers)
            .HasForeignKey(_ => _.StalkerEmailAddress)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
