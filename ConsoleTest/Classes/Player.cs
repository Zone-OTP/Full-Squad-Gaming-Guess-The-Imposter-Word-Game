using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Classes
{
    public class Player
    {
        public int PlayerId { get; set; } 
        public string Name { get; set; }
        public bool Imposter { get; set; } = false;
        public string? Role { get; set; }

        private static int playerId = 1;
        public Player(string name)
        {
            PlayerId = playerId++;
            Name = name;
        }

    }
}
