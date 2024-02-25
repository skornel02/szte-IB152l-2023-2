using Backend.Persistance.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.Persistance.Configuration;

public class EmailQueueEntityConfiguration : IEntityTypeConfiguration<EmailQueueEntity>
{
    public void Configure(EntityTypeBuilder<EmailQueueEntity> builder)
    {
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();

        builder.HasOne(_ => _.RecipientUser)
            .WithMany(_ => _.Emails)
            .HasForeignKey(_ => _.RecipientUserEmailAddress)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);


    }
}
