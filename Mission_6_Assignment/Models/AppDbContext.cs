using Microsoft.EntityFrameworkCore;

namespace Mission_6_Assignment.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Category = "Comedy", Title = "Get Smart", Year = 2008, Director = "Peter Segal", Rating = "PG-13" },
                new Movie { MovieId = 2, Category = "Romantic Comedy", Title = "Just Friends", Year = 2005, Director = "Roger Kumble", Rating = "PG-13" },
                new Movie { MovieId = 3, Category = "Action", Title = "Spider-Man 2", Year = 2004, Director = "Sam Raimi", Rating = "PG-13" }
            );
        }
    }
}
