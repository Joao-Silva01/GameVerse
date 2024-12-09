using BackGameVerse.Data;
using BackGameVerse.DTO;
using BackGameVerse.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackGameVerse.Services
{

    public class GameService
    {
        private readonly GameVerseContext _context;

        public GameService(GameVerseContext context)
        {
            _context = context;
        }


        //Retorna todos os jogos com a descrição curta
        public async Task<List<GameMinDTO>> FindAllGameAsync()
        {
            List<Game> allGames = await _context.TGames.ToListAsync();
            List<GameMinDTO> allGamesDTO = allGames.Select(x => new GameMinDTO(x)).ToList();

            return allGamesDTO;
        }

        //Retorna o jogo com descrição longa com base no id 
        public async Task<GameDTO> FindGameByIdAsync(int gameId)
        {
            Game? gameResult = await _context.TGames.FirstOrDefaultAsync(x => x.Id == gameId);

            if (gameResult is null)
            {
                return null;
            }


            GameDTO gameDTO = new GameDTO(gameResult);

            return gameDTO;

        }


        // Retonar os jogos de acordo com Id da lista
        public async Task<List<GameMinDTO>> FindByListAsync(int listId)
        {
            return await _context.SearchByListAsync(listId);
        }
    }
}
