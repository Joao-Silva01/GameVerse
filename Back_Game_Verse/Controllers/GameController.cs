using BackGameVerse.Services;
using Microsoft.AspNetCore.Mvc;

namespace BackGameVerse.Controllers
{

    [ApiController]
    [Route("/game")]
    public class GameController(GameService service) : ControllerBase
    {
        private readonly GameService _gameService = service;
    }
}
