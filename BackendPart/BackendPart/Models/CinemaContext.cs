using System.Data.Entity;

namespace BackendPart.Models
{
    public class CinemaContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

    }
}