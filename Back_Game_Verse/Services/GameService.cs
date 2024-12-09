using BackGameVerse.Data;
using BackGameVerse.DTO;
using BackGameVerse.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackGameVerse.Services
{
    
    public class GameService(GameVerseContext context)
    {
        private readonly GameVerseContext _context = context;

        
    }
}
