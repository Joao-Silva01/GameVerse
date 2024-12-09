using BackGameVerse.Entities;
using BackGameVerse.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackGameVerse.Controllers
{
    [ApiController]
    [Route("/gameList")]
    public class GameListController : ControllerBase
    {
        private readonly GameListService _gameListService;
        private readonly GameService _gameService;

        public GameListController(GameListService service, GameService gameService)
        {
            _gameListService = service;
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> GetListAll()
        {
            var result = await _gameListService.FindAllAsync();
            return Ok(result);
        }

        [HttpGet("{listId}")]
        public async Task<IActionResult> GetByList(int listId)
        {
            var result = await _gameService.FindByListAsync(listId);
            return Ok(result);
        }

        [HttpPost("{listId}")]
        public async Task UpdateGamePosition(int listId, [FromBody] Replacement body)
        {
            await _gameListService.GameMoveAsync(listId, body.Source, body.Destination);
        }
    }

    
}
