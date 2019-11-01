using Microsoft.EntityFrameworkCore;

namespace ParkDistrict.Models
{
    public class ParkDistrictContext : DbContext
    {
        public ParkDistrictContext(DbContextOptions<ParkDistrictContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, Name = "Cathedral Park", Location = "N Edison St. and Pittsburg Ave.", Playground = true, PicnicArea = true, Bathroom = true },
                    
                    new Park { ParkId = 2, Name = "Columbia Park", Location = "9360 N Columbia Blvd.", Playground = true, PicnicArea = true, Bathroom = true },

                    new Park { ParkId = 3, Name = "Overlook Park", Location = "N Fremont St. and Interstate Ave.", Playground = true, PicnicArea = true, Bathroom = true },

                    new Park { ParkId = 4, Name = "Kelley Point Park", Location = "N Marine Dr. and Lombard St.", Playground = true, PicnicArea = true, Bathroom = true },

                    new Park { ParkId = 5, Name = "Peninsula Park", Location = "700 N Rosa Parks Way", Playground = true, PicnicArea = true, Bathroom = true }
                );
        }
    }
}