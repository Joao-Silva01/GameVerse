using BackGameVerse.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackGameVerse.Controllers
{
    [ApiController]
    [Route("/gameList")]
    public class GameListController : ControllerBase
    {
        private readonly GameListService _gameListService;

        public GameListController(GameListService service)
        {
            _gameListService = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetListAll()
        {
            var result = await _gameListService.FindAllAsync();
            return Ok(result);
        }
    }

    
}
