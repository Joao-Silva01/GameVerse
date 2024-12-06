using Microsoft.EntityFrameworkCore;

namespace BackGameVerse.Data
{
    public class GameVerseContext : DbContext
    {
        public GameVerseContext(DbContextOptions options) : base(options)
        {
        }


    }
}
