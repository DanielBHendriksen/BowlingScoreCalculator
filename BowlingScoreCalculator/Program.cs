using System.Collections.Generic;

namespace BowlingScoreCalculator
{


    public class BowlingScoreCalculator
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Daniels bowling game 2022, press any key to begin the game");
            Console.Read();

            List<int> throwsList = new List<int> { 2, 7, 1, 5, 7, 2, 9, 0, 3, 4, 4, 4, 9, 0, 8, 1, 6, 4, 6, 4, 2 };
           
            BowlingGame game = new BowlingGame(throwsList);

            game.RunGame();

        }

    }
}


