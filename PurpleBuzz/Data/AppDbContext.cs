using System;
using Microsoft.EntityFrameworkCore;
using PurpleBuzz.Entities;

namespace PurpleBuzz.Data;

public class AppDbContext : DbContext
{
    public DbSet<RecentWorks> RecentWorks { get; set; }
    public DbSet<Priorites> Priorites { get; set; }
    public DbSet<TeamMember> TeamMembers { get; set; }
    public DbSet<Pricing> Pricings { get; set; }
    public DbSet<PricingAdventages> PricingAdventages { get; set; }
    public DbSet<Contact> Contacts { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var datas = ChangeTracker.Entries<BaseEntity>();

        foreach (var data in datas)
        {
            if (data.State == EntityState.Added)
            {
                data.Entity.CreatedAt = DateTime.UtcNow;
                data.Entity.UpdatedAt = DateTime.UtcNow;
            }
            else if (data.State == EntityState.Modified)
                data.Entity.UpdatedAt = DateTime.Now;
        }
        return await base.SaveChangesAsync(cancellationToken);
    }
}
