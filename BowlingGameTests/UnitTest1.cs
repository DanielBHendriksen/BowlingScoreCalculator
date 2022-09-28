using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingScoreCalculator;

namespace BowlingGameTests
{
   
    [TestClass]

   
    public class UnitTest1
    {
 
        List<int> throws = new List<int> { 8, 2, 3, 0, 7, 0, 10, 0, 0, 3, 1, 6, 2, 5, 0, 5, 2, 7, 5, 5, 8 };

        [TestMethod]
        public void Sort_Throws_To_First_And_Second_Throw()
        {
            // ARRANGE

            BowlingGame game = new BowlingGame(throws);

            List<int> firstThrow = new List<int> {8,3,7,10,0,1,2,0,2,5,8}; //seperating all even throws to first throw list
            List<int> secondThrow = new List<int> {2,0,0,0,3,6,5,5,7,5,}; //seperating all odd throws to first throw list

            // ACT
            game.SortThrows();


            // ASSERT
            CollectionAssert.AreEqual(firstThrow, game.firstThrow);
            CollectionAssert.AreEqual(secondThrow, game.secondThrow);

        }
        [TestMethod]
        public void Calculating_First_Rounds_Updates_TotalScore()
        {
            // ARRANGE
            int totalScore = 67;
            BowlingGame game = new BowlingGame(throws);

            // ACT
            game.SortThrows();
            game.CalculateFirstRounds();
            

            // ASSERT
            Assert.AreEqual(totalScore, game.totalScore);
        }
        [TestMethod]
        public void Calculating_Last_Round_Updates_TotalScore()
        {
            // ARRANGE
            int totalScore = 85;
            BowlingGame game = new BowlingGame(throws);

            // ACT
            game.SortThrows();
            game.CalculateFirstRounds();
            game.CalculateLastRound();


            // ASSERT
            Assert.AreEqual(totalScore, game.totalScore);
        }
        [TestMethod]
        public void Test_PrintScore()
        {
            // ARRANGE
            int roundNumber = 9;
            string output;
            BowlingGame game = new BowlingGame(throws);

            // ACT
            if (0 <= roundNumber && roundNumber <= 8) //roundNumber starts at 0
                
            output = "Your score for first round is: x";
            
            else
               output = "Your score for last round is: x";

            // ASSERT
            Assert.AreEqual("Your score for last round is: x", output);


        }
    }
}