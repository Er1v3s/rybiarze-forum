using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Forum.Data
{
    public class AppDbContext : IdentityDbContext<ForumUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Comment>()
                .HasOne(c => c.ForumUser)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.ForumUserId)
                .IsRequired();

            builder.Entity<Comment>()
                .HasOne(c => c.Post)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.PostId)
                .IsRequired();
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
