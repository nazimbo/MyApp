using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    // AppDbContext
    // This class is used to query and save instances of the User class.
    // It is derived from the DbContext class in the EntityFrameworkCore namespace.
    public class AppDbContext : DbContext
    {
        // Constructor
        // This constructor is used to inject the DbContextOptions object into the AppDbContext class.
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet
        // This property is used to query and save instances of the User class.
        public DbSet<User> Users { get; set; }
    }
}

