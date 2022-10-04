using PlayersAPI.DTOs;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;

namespace PlayersAPI.Models
{
    public class PlayerService : IPlayerService
    {
        private IPlayerRepository _repository;

        public PlayerService(IPlayerRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<PlayerDTO> ListPlayers()
        {
            return _repository.ListPlayers().AsQueryable().Select(asPlayerDTO);            
        }

        private static Expression<Func<Player, PlayerDTO>> asPlayerDTO =
        x => new PlayerDTO
        {
            Name = x.Name,
            LastName = x.LastName,
            Birthday = DateTime.ParseExact(x.Birthday.ToString(), "yyyyMMdd", CultureInfo.InvariantCulture)
        };
    }
}
