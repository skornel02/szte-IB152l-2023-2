using Backend.Persistance.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Backend.Persistance;

public class ApplicationDbContext : DbContext
{
    public DbSet<Entities.UserEntity> Users { get; set; }
    public DbSet<Entities.PostEntity> Posts { get; set; }
    public DbSet<Entities.PoetryEntity> Poetries { get; set; }
    public DbSet<Entities.WatchListEntity> WatchList { get; set; }
    public DbSet<Entities.CommentEntity> Comments { get; set; }
    public DbSet<Entities.EngagementEntity> Engagements { get; set; }
    public DbSet<Entities.FollowingEntity> Followings { get; set; }
    public DbSet<Entities.EmailQueueEntity> Emails { get; set; }

    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserEntityConfiguration).Assembly);
    }
}
