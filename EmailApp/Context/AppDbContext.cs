using EmailApp.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmailApp.Context;

public class AppDbContext : IdentityDbContext<AppUser,AppRole,int>
{
    public AppDbContext(DbContextOptions options) : base(options){ }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<AppUser>()
            .HasMany(m => m.SentMessage)
            .WithOne(s=>s.Sender).HasForeignKey(m => m.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<AppUser>()
            .HasMany(m => m.RecievedMessage)
            .WithOne(r => r.Reciever).HasForeignKey(m => m.RecieverId)
            .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(builder);
    }
    public DbSet<Message> Messages { get; set; }
}
