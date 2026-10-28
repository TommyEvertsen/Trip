using Microsoft.EntityFrameworkCore;

namespace Trip.Models;

public class MemberContext : DbContext
{
   public MemberContext(DbContextOptions<MemberContext> options)
        : base(options)
    {
    }

    public DbSet<Member> Members { get; set; } = null!;
    public DbSet<Trip> Trips { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>()
            .HasMany(m => m.Trips)
            .WithMany(t => t.Members);
    }
}

