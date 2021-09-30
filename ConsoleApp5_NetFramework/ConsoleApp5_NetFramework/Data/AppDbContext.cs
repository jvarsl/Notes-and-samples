using ConsoleApp5_NetFramework.Models;
using System.Data.Entity;

namespace ConsoleApp5_NetFramework.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<PostGenre> PostGenres { get; set; }
    }
}
