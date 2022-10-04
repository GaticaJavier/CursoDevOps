using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayersAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : ControllerBase
    {
        public List<Player> Players;
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(ILogger<PlayerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Player> Get()
        {
            Players = new List<Player>()
            {
                new Player("Guillermo", "Ferreira", 19880609),
                new Player("Juan", "Gonzalez", 19901006),
                new Player("Carlos", "Perez", 20000112),
                new Player("Fernando", "Ramirez", 19740730)
            };

            return Players;
        }        
    }
}
