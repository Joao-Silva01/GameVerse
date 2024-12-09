using BackGameVerse.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackGameVerse.Data
{
    public class GameVerseContext : DbContext
    {
        public GameVerseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Game> TGames { get; set; }
        public DbSet<GameList> TGamesList { get; set; }
        public DbSet<Belonging> Belongings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Belonging>().HasKey(foreign => new { foreign.GameId, foreign.GameListId });
        }
    }
}
