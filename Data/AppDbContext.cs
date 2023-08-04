using Microsoft.EntityFrameworkCore;
using Smusic.Models;

namespace Smusic.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album_Actor>().HasKey(aa => new { aa.AlbumId,aa.ActorId }) ;

            modelBuilder.Entity<Album_Actor>().HasOne(a => a.Actor).WithMany(aa => aa.Albums_Actors).HasForeignKey(a => a.ActorId);
            modelBuilder.Entity<Album_Actor>().HasOne(a => a.Album).WithMany(aa => aa.Albums_Actors).HasForeignKey(a => a.AlbumId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Album_Actor> Album_Actor { get; set; }
    }
}
