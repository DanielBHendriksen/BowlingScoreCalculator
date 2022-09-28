using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingScoreCalculator
{
    public class BowlingGame
    {
        public List<int> throws = new List<int>();

        public List<int> firstThrow = new List<int>();
        public List<int> secondThrow = new List<int>();

        public int totalScore = 0;
        int Strike = 10;
        int Spare = 10;
        int roundNumber = 0;
        public BowlingGame(List<int> list)
        {
            this.throws = list;
        }
        
        public void RunGame() //collected method that will execute the bowling game when run in Main
        {
            SortThrows();
            CalculateFirstRounds();
            CalculateLastRound();
        }
        public void SortThrows()
        {
            for (int i = 0; i < throws.Count; i++) //uses modulo to assign all even throws to firstThrow list and all odd throws to secondThrow list
            {
                if (i % 2 == 0)
                {
                    firstThrow.Add(throws[i]);
                }
                else
                {
                    secondThrow.Add(throws[i]);
                }
            }
            
        }
        public void CalculateFirstRounds() //first rounds consist of round 1-9
        {
            for (int i = 0; i < secondThrow.Count - 1; i++)
            {
                roundNumber = i;
                if (firstThrow[i] == Strike) // if first throw is a strike
                {
                    if (firstThrow[i + 1] == Strike) //if the following throw is also a strike
                    {
                        totalScore = totalScore + firstThrow[i] + firstThrow[i + 1] + firstThrow[i + 2];
                    }
                    else
                    {
                        totalScore = totalScore + firstThrow[i] + firstThrow[i + 1] + secondThrow[i + 1];
                    }

                }
                else if (firstThrow[i] + secondThrow[i] == Spare) //if first throw + second throw yields a spare
                {
                    totalScore = totalScore + firstThrow[i] + secondThrow[i] + firstThrow[i + 1];
                }
                else
                {
                    totalScore = totalScore + firstThrow[i] + secondThrow[i];
                }
                PrintScore();
                
            }
            
        }
        public void CalculateLastRound() // Last round consist of 10th round and special rules apply to this round
        {
            roundNumber++;
            if (throws.Count == 21) // if last round includes a strike or spare
            {
                if (throws[18] == Strike) // if first throw in last round was a strike
                {
                    totalScore = totalScore + firstThrow[9] + firstThrow[10] + secondThrow[9];
                }


                else // if second throw in last round yields a spare
                {
                    totalScore = totalScore + firstThrow[9] + firstThrow[10] + secondThrow[9];
                }

                PrintScore();

            }
            else // if last round does not include a strike or spare
            {
                totalScore = totalScore + firstThrow[9] + secondThrow[9];
                PrintScore();

            }
        }
        public void PrintScore() //prints the score
        {
            if (0 <= roundNumber && roundNumber <= 8) //if we are within round 1-9 print the round number, else print last round
                Console.WriteLine("Your score for round {0} is: {1}",roundNumber + 1, totalScore);
            else
                Console.WriteLine("Your score for the last round is: " + totalScore);
        }
    }
}
