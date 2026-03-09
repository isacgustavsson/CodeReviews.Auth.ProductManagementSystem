using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
{
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Potato",
                Price = 9,
                DateAdded = new DateTime(2026, 3, 8)
            },
              new Product
              {
                  Id = 2,
                  Name = "Tomato",
                  Price = 9,
                  DateAdded = new DateTime(2026, 3, 8)
              }
        );

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "1",
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "00000000-0000-0000-0000-000000000001"
            },
            new IdentityRole
            {
                Id = "2",
                Name = "Staff",
                NormalizedName = "STAFF",
                ConcurrencyStamp = "00000000-0000-0000-0000-000000000002"
            }
        );
    }

}
