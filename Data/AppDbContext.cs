using Microsoft.EntityFrameworkCore;
using Smusic.Models;

namespace Smusic.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<Song> Songs  { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
}
