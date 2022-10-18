using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace PlayersAPI.Models
{
    public class Player
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public string LastName { get; set; }
        [BsonElement]
        public int Birthday { get; set; }

        public Player(string id, string name, string lastName, int birthDay) 
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Birthday = birthDay;
        }
    }
}
