using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MvcMovie.Data
{
    // This factory is used by EF tools (migrations / scaffolding) at design time
    public class MvcMovieContextFactory : IDesignTimeDbContextFactory<MvcMovieContext>
    {
        public MvcMovieContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MvcMovieContext>();

            // load connection string from appsettings.json in project folder
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("MvcMovieContext");

            // use SQL Server (LocalDB) connection string
            builder.UseSqlServer(connectionString);

            return new MvcMovieContext(builder.Options);
        }
    }
}
