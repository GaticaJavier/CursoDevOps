using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayersAPI.Models
{
    public class PlayerRepository : IPlayerRepository
    {
        private List<Player> _entities = new List<Player>()
            {
                new Player("Guillermo", "Ferreira", 19880609),
                new Player("Juan", "Gonzalez", 19901006),
                new Player("Carlos", "Perez", 20000112),
                new Player("Fernando", "Ramirez", 19740730)
            };

        public IEnumerable<Player> ListPlayers()
        {
            return _entities;
        }
    }
}
