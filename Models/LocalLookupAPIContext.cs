using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LocalLookupAPI.Models
{
    public class LocalLookupAPIContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Business> Businesses { get; set; }
        public virtual DbSet<City> Cities { get; set; }

        public LocalLookupAPIContext(DbContextOptions<LocalLookupAPIContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Business>()
                .HasData(
                    new Business
                    {
                        BusinessId = 2,
                            Name = "Nothing",
                            CityId = 1,
                            Blurb = "We buy butts",
                            PhoneNumber = "Nothing",
                            Address = "Nothing"
                    }
                );
            builder.Entity<City>()
                .HasData(new City { CityId = 1, Name = "Nothing", ZipCode = 94829 });

        }
    }
}