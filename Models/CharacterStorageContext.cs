using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LocalLookupAPI.Solution.Models
{
    public class LocalLookupAPIContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Business> Businesses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public LocalLookupAPIContext(DbContextOptions<LocalLookupAPIContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Business>()
              .HasData(

            );
            builder.Entity<City>()
            .HasData(
           );

        }
    }
}
