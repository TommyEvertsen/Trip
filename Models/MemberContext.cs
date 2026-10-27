using Microsoft.EntityFrameworkCore;

namespace Trip.Models;

public class MemberContext : DbContext
{
   public MemberContext(DbContextOptions<MemberContext> options)
        : base(options)
    {
    }

    public DbSet<Member> Members { get; set; } = null!;
}