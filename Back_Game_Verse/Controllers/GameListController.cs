using BackGameVerse.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackGameVerse.Controllers
{
    [ApiController]
    [Route("/gameList")]
    public class GameListController(GameListService service) : ControllerBase
    {
        private readonly GameListService _gameListService = service;
    }
}
