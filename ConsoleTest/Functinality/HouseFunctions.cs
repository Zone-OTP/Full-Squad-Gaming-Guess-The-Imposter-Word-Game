using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ConsoleTest.Classes;


namespace ConsoleTest.Functionality
{
    internal class HouseFunctions
    {
        public static int? RandomImposter(int number)
        {
            int? impostersNumber = null;
            number++; //idk just wanted the player in the end to also be able to to be the imposter, easy solution

            for (int i = 1; number >= i; i++)
            {

                if (i == new Random().Next(1, number))
                {
                    impostersNumber = i;
                    break;
                }
                if (i == number) i = 1;

            }
            return impostersNumber;
        }

        public static List<Player> CreatePlayerList(int playerCount)
        {
            var players = new List<Player>();
            for (int i = 1; playerCount >= i; i++)
            {
                Console.WriteLine($"player {i} name");
                var playerName = Console.ReadLine();
                while (playerName == null)
                {
                    Console.WriteLine("please actually enter a name");
                    playerName = Console.ReadLine();
                    if (playerName != null) { players.Add(new Player(playerName)); }
                }
                players.Add(new Player(playerName));
                Console.Clear();

            }
            return players;
        }

        public static void TellWord(List<Player> players,string word)
        {
            foreach(Player player in players)
            {
                Console.WriteLine($"Player {player.Name} it's your turn ,please come to the Console\nplease press enter after arrival ");
                Console.ReadLine();
                Console.Clear();
                if (player.Imposter)
                {
                    Console.WriteLine("You're the Imposter shhhhhhhh.....\nafter reading press enter");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                Console.WriteLine($"the word is '{word}'\nafter reading press enter");
                Console.ReadLine();
                Console.Clear();
            }
        }

    }
}
