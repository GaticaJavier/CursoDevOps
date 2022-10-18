using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace PlayersAPI.Models
{
    public class PlayerRepository : IPlayerRepository
    {
        IMongoClient client;
        IMongoDatabase database;

        public PlayerRepository()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("PlayersStore");
        }

        public IEnumerable<Player> ListPlayers()
        {
            var players = database.GetCollection<Player>("Players");
            
            return players.Find(p => true).ToList();
        }
    }
}
