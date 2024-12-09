using BackGameVerse.Data;
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
    }
}
