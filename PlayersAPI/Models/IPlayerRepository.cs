using System.Collections.Generic;

namespace PlayersAPI.Models
{
    public interface IPlayerRepository
    {
        IEnumerable<Player> ListPlayers();
    }
}
