using Microsoft.EntityFrameworkCore;
using NackademinHotel.Model;

namespace NackademinHotel.Data
{
    class HotelContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;;Database=Hotel;Trusted_Connection=True;");
        }
    }
}
