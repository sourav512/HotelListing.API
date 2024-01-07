using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "IND",
                },
                new Country
                {
                    Id = 2,
                    Name = "United States Of America",
                    ShortName = "USA",
                },
                new Country
                {
                    Id = 3,
                    Name = "Russia",
                    ShortName = "USSR",
                });
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Taj Exotica",
                    Rating = 4.3,
                    Address = "Goa",
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hyatt",
                    Rating = 4.4,
                    Address = "New York",
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "JW Marriot",
                    Rating = 4.8,
                    Address = "Moscow",
                    CountryId = 3
                });
        }
    }
}
