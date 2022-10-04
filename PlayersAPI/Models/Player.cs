using System;

namespace PlayersAPI.Models
{
    public class Player
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public int Birthday { get; set; }

        public Player(string name, string lastName, int birthDay) 
        {
            Name = name;
            LastName = lastName;
            Birthday = birthDay;
        }
    }
}
