
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Sams.Data.DataModels;

namespace Sams.Data
{
    public class SamsContext : DbContext
    {
        public SamsContext(DbContextOptions<SamsContext> options) : base(options) { }
        #region Datasets

        public DbSet<ListItem> ListItems { get; set; }

        #endregion
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SamsContext>
    {
        public SamsContext CreateDbContext(string[] args)
        {
            string jsonPath = Directory.GetCurrentDirectory() + "/../Sams.Api/appsettings.json";
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(jsonPath).Build();
            var builder = new DbContextOptionsBuilder<SamsContext>();
            var connectionString = configuration.GetConnectionString("SamsContext");
            builder.UseSqlServer(connectionString);
            return new SamsContext(builder.Options);
        }
    }
}

