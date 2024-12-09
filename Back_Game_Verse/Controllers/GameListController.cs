using BackGameVerse.Data;
using BackGameVerse.DTO;
using BackGameVerse.Entities;
using BackGameVerse.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackGameVerse.Controllers
{
    [ApiController]
    [Route("/gameList")]
    public class GameListController : ControllerBase
    {
        private readonly GameListService _gameListService;
        private readonly GameService _gameService;
        private readonly GameVerseContext _context;

        public GameListController(GameListService service, GameService gameService, GameVerseContext conte)
        {
            _gameListService = service;
            _gameService = gameService;
            _context = conte;
        }

        [HttpGet]
        public async Task<IActionResult> GetListAll()
        {
            var result = await _gameListService.FindAllAsync();
            return Ok(result);
        }

        [HttpGet("/gameList/{listId}/games")]
        public async Task<IActionResult> findByList(int listId)
        {
            var result = await _gameService.FindByListAsync(listId);
            return Ok(result);
        }

        [HttpGet("/gameList/beg")]
        public List<Belonging> beg()
        {
            List<Belonging> b =  _context.Belongings.ToList();
          

            return b;
        }
    }

    
}
