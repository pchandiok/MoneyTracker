using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Money.Models;

namespace Money.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Bank> Banks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Bank>()
            .ToTable("Banks")
            .HasKey( b => b.AccountNumber);

        builder.Entity<ApplicationUser>()
            .HasMany(u => u.Banks)
            .WithOne(b => b.ApplicationUser)
            .HasForeignKey(b => b.ApplicationUserId);
    }
}
