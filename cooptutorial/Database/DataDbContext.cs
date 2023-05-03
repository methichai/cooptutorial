using Microsoft.EntityFrameworkCore; // Import EF
using cooptutorial.Models; // Import Model

namespace cooptutorial.Database
{
    public class DataDbContext:DbContext
    {
        // Constructure Method
        public DataDbContext(DbContextOptions<DataDbContext> options):base(options) { }

        // Table Manufacturers
        public DbSet<manufacturers> manufacturers { get; set; }

        // Table Device
        public DbSet<devices> devices { get; set; }

    }
}
