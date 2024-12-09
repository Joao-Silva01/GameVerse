using BackGameVerse.Data;
using BackGameVerse.DTO;
using BackGameVerse.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackGameVerse.Services
{
    public class GameListService
    {
        private readonly GameVerseContext _context;

        public GameListService(GameVerseContext context)
        {
            _context = context;
        }

        public async Task<List<GameList>> FindAllAsync()
        {
            return await _context.TGamesList.ToListAsync();
        }


        // Faz a mudança de posição do game
        public async Task GameMoveAsync(int listId, int source, int destination)
        {
            List<GameMinDTO> listDTO = await _context.SearchByListAsync(listId);

            GameMinDTO gameDTO = listDTO[source];
            listDTO.RemoveAt(source);
            listDTO.Insert(destination, gameDTO);

            int min = source < destination ? source : destination;
            int max = source > destination ? source : destination;

            for (int i = min; i <= max; i++) 
            {
                await _context.UpdateBelongingPositionAsync(listId, listDTO[i].Id, i);
            }

        }
    }
}
