using Microsoft.EntityFrameworkCore;
using Moive_finder.Models;

namespace Moive_finder.Data_Layer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options)
        {

        }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, DisplayOrder = 1, Name = "x-men", Genre = "Action" },
                new Movie { Id = 2, DisplayOrder = 2, Name = "My Hero Academia", Genre = "Action" },
                new Movie { Id = 3, DisplayOrder = 3, Name = "The wall", Genre = "Documentary" }



                );
        }
    }
}
//add-migration SeedMovieTable
