using Microsoft.EntityFrameworkCore;
using Sunibpolis_backend.Models;

namespace Sunibpolis_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CinemaLocation> CinemaLocation { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieShowTime> MovieShowTime { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }
        public DbSet<Seat> Seat { get; set; }
        public DbSet<Theater> Theater { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<User> User { get; set; }
    }
}
