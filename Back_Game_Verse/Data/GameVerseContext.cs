using BackGameVerse.DTO;
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
            // Faz uma chave estrangeira composta
            modelBuilder.Entity<Belonging>().HasKey(f => new { f.GameId, f.GameListId });
        }


        // Retorna todos os jogos de acordo com o Id da lista
        public async Task<List<GameMinDTO>> SearchByListAsync(int listId)
        {
            var result = await(
                from game in TGames
                join belonging in Belongings on game.Id equals belonging.GameId
                where belonging.GameListId == listId
                orderby belonging.Position
                select new GameMinDTO(game)
                ).ToListAsync();

            return result;
        }


        // Muda a posição do game
        public async Task UpdateBelongingPositionAsync(int listId, int gameId,int newPosition)
        {
            var belonging = await Belongings.FirstOrDefaultAsync(b => b.GameListId == listId && b.GameId == gameId);

            if (belonging != null)
            {
                belonging.Position = newPosition;
                await SaveChangesAsync();
            }

            
        }


    }
}
