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
    }
}
