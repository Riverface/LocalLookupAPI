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
            for (int i = 30; i < 200; i+=2)
            {   
            builder.Entity<Business>()
                .HasData(
                    new Business
                    {
                        BusinessId = i,
                        Name = "aNd tHey dOnT sToP cOMiNg",
                        CityId = i,
                        Blurb = "All that glitters is gold",
                        PhoneNumber = "Nothing",
                        Address = "Nothing"
                    },
                    new Business
                    {
                        BusinessId = i+1,
                        Name = "AnD ThEY DoNt StOp ComInG",
                        CityId = i+1,
                        Blurb = "Only shooting stars break the mold",
                        PhoneNumber = "Nothing",
                        Address = "Nothing"
                    }
                );
            }
            for (int i = 30; i < 200; i++)
            {   
                builder.Entity<City>()
                    .HasData(new City { CityId = i, Name = "It's a cool place", ZipCode = 94829 });
            }
            }
        }
    }
