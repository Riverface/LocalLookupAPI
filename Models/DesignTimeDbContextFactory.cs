using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LocalLookupAPI.Solution.Models
{
    public class LocalLookupAPIContextFactory : IDesignTimeDbContextFactory<LocalLookupAPIContext>
    {
        LocalLookupAPIContext IDesignTimeDbContextFactory<LocalLookupAPIContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            var builder = new DbContextOptionsBuilder<LocalLookupAPIContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseMySql(connectionString);

            return new LocalLookupAPIContext(builder.Options);
        }
    }
}