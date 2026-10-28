using Microsoft.EntityFrameworkCore;

namespace Trip.Models;

    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options)
                   : base(options)
        {
        }

        public DbSet<Trip> Trips { get; set; } = null!;
        public DbSet<Member> Members { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>()
                .HasMany(t => t.Members)
                .WithMany(m => m.Trips);
        }
    }


   
    

