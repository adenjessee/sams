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
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerCard> CustomerCards { get; set; }
        public DbSet<DaySchedule> DaySchedules { get; set; }
        public DbSet<Executive> Executives { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Point> Point { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<TimeSet> TimeSets { get; set; }
        #endregion
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SamsContext>
    {
        public SamsContext CreateDbContext(string[] args)
        {
            string jsonPath = Directory.GetCurrentDirectory() + "/../Sams.Api/appsettings.json";
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(jsonPath).Build();
            var builder = new DbContextOptionsBuilder<SamsContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new SamsContext(builder.Options);
        }
    }
}
