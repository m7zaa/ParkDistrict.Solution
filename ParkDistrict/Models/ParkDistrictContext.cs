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
    }
}