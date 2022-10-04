using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlayersAPI.DTOs;
using PlayersAPI.Models;
using System;
using System.Collections.Generic;

namespace PlayersAPI.Controllers
{
    [ApiController]
    [Route("Player")]
    public class PlayerController : ControllerBase
    {
        public List<Player> Players;
        private readonly ILogger<PlayerController> _logger;
        private IPlayerService _service;

        public PlayerController(ILogger<PlayerController> logger, IPlayerService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("players")]
        public IEnumerable<PlayerDTO> GetPlayers()
        {
            return _service.ListPlayers();
        }
    }
}
