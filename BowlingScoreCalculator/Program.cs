using System.Collections.Generic;

namespace BowlingScoreCalculator
{


    public class BowlingScoreCalculator
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Daniels bowling game 2022, press any key to begin the game");
            Console.Read();

            List<int> tempName = new List<int> { 8, 2, 3, 0, 7, 0, 10, 0, 0, 3, 1, 6, 2, 5, 0, 5, 2, 7, 5, 5, 8 };
            BowlingGame game = new BowlingGame(tempName);

            game.RunGame();

        }

    }
}


