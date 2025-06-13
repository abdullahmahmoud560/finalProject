using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.ApplicationDbContext
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<DB>
    {
        public DB CreateDbContext(string[] args)
        {
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "finalProject");

            var configuration = new ConfigurationBuilder()
                 .SetBasePath(basePath)
                 .AddJsonFile("appsettings.json", optional: false)
                 .Build();

            var builder = new DbContextOptionsBuilder<DB>()
                .UseMySql(
                configuration.GetConnectionString("Connection"),
                ServerVersion.AutoDetect(configuration.GetConnectionString("Connection")),
                options => options.MigrationsAssembly("Infrastructure"));

            return new DB(builder.Options);
        }
    }
}
