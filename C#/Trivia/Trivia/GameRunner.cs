using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UglyTrivia;

namespace Trivia
{
    public class GameRunner
    {

        private static bool notAWinner;

        public static void Main(String[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Game aGame = new Game();

                aGame.AddPlayer(new Player("Chet"));
                aGame.AddPlayer(new Player("Pat"));
                aGame.AddPlayer(new Player("Sue"));

                Random rand = new Random(i);

                do
                {

                    aGame.roll(rand.Next(5) + 1);

                    if (rand.Next(9) == 7)
                    {
                        notAWinner = aGame.wrongAnswer();
                    }
                    else
                    {
                        notAWinner = aGame.wasCorrectlyAnswered();
                    }

                } while (notAWinner);

                // Adding end of game (for verification purposes in GoldenMaster :
                Console.WriteLine("\nEND OF GAME\n");

            }

        }


    }

}

