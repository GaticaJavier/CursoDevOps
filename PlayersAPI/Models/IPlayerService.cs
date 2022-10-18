using PlayersAPI.DTOs;
using System.Collections.Generic;

namespace PlayersAPI.Models
{
    public interface IPlayerService
    {
        IEnumerable<PlayerDTO> GetPlayers();
    }
}
