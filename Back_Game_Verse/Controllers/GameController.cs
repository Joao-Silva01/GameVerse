using BackGameVerse.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackGameVerse.Controllers
{

    [ApiController]
    [Route("/game")]
    public class GameController(GameService service) : ControllerBase
    {
        private readonly GameService _gameService = service;

        [HttpGet]
        public async Task<IActionResult> GetAllGames()
        {
            var result = await _gameService.FindAllGameAsync();

            if (result is null) 
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpGet("/game/{gameId}")]
        public async Task<IActionResult> GetGame(int gameId)
        {
            var result = await _gameService.FindGameByIdAsync(gameId);

            if(result is null  )
            {
                return NotFound();
            }
            
            return Ok(result);
        }
    }
}
