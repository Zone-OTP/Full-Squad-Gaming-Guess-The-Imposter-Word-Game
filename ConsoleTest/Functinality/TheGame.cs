using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTest.Classes;

namespace ConsoleTest.Functionality
{
    public class TheGame
    {
        private static List<Player> players;

        public static void StartGame()
        {
            Console.WriteLine("How Many players");
            try
            {
               var word = WordsForGame.WordChosen();

                int playerCount = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                players = HouseFunctions.CreatePlayerList(playerCount);
                var imposterNumber = HouseFunctions.RandomImposter(playerCount);
                foreach (Player player in players)
                {
                    if (player.PlayerId == imposterNumber)
                    {
                        player.Imposter = true;
                    }
                }
                HouseFunctions.TellWord(players, word);
                Console.WriteLine("when you want to see the player who was the Imposter press enter");
                Console.ReadLine();
                Console.WriteLine("are you sure you want to see the imposter?");
                Console.ReadLine();
                var imposterPlayer = players.FirstOrDefault(p => p.Imposter == true);
                Console.WriteLine($"The imposter was {imposterPlayer.Name} The word was {word}");

            }
            catch (Exception ex)
            {
                Console.WriteLine("you probably fucked up the number of players");
                StartGame();
            }
            
        }
    }
}
