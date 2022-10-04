using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayersAPI.DTOs
{
    public class PlayerDTO
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }
    }
}
