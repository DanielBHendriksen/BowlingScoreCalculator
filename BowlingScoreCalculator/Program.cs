using System.Collections.Generic;

public class BowlingScoreCalculator
{
    public static void Main(string[] args)
    {


        // List<int> throws = new List<int> {8,2,3,0,7,0,10,0,0,3,1,6,2,5,0,5,2,7,5,5,8};
        // List<int> throws = new List<int> {10,0,10,0,10,0,10,0,10,0,10,0,10,0,10,0,10,0,10,0,0};
        // List<int> throws = new List<int> { 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 0, 10, 10, 10 };
         List<int> throws = new List<int> {10,0,10,0,10,0,10,0,10,0,10,0,10,0,10,0,2,3,10,10,10};
        // List<int> throws = new List<int> { 8, 2, 3, 0, 7, 0, 10, 0, 0, 3, 1, 6, 2, 5, 0, 5, 2, 7, 5, 0 };
        List<int> firstThrow = new List<int>();
        List<int> secondThrow = new List<int>();
        int totalScore = 0;
        // Console.WriteLine(totalScore);
        // List<int> frame = new List<int>();
        // Console.WriteLine(throws.Count);
        // Console.WriteLine(frame.Count);
        bool isStrike = false;
        Console.WriteLine("Welcome to Daniels bowling game 2022, press any key to begin the game");
        Console.Read();
        Console.WriteLine("You can now press any key to begin your first throw");
        Console.Read();
      


        /*foreach (int i in throws)
        {
            Console.WriteLine(i);   
        }*/

        for (int i = 0; i < throws.Count; i++) // assign first throw to all even numbers and second throw to all odd numbers
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

        for (int i = 0; i < secondThrow.Count -1; i++)
        {
            if (firstThrow[i] == 10) // if first throw is a strike
            {
                if (firstThrow[i + 1] == 10) //if the following throw is also a strike
                {
                    totalScore = totalScore + firstThrow[i] + firstThrow[i + 1] + firstThrow[i + 2];
                   
                        
                }
                else
                totalScore = totalScore + firstThrow[i] + firstThrow[i + 1] + secondThrow[i + 1];
                //Console.WriteLine("Total score is: " + totalScore);
                Console.Read();
                Console.WriteLine("WOW! You scored a strike: X. Your score will be updated after the two next throws");
                Console.Read();
                Console.WriteLine("Total score is: {0}, press any key again to start your next throw", totalScore);
                
            }
            else if (firstThrow[i] + secondThrow[i] == 10)
            {
                totalScore = totalScore + firstThrow[i] + secondThrow[i] + firstThrow[i + 1];
                Console.Read();
                //Console.WriteLine("Total score is: {0}, press any key again to start your next throw",totalScore);
                Console.WriteLine("A spare! Great job: /. Your score will be updated after the next throw");
                Console.Read();
                Console.WriteLine("Total score is: {0}, press any key again to start your next throw", totalScore);



            }
            else
            {
                totalScore = totalScore + firstThrow[i] + secondThrow[i];
                Console.Read();
                Console.WriteLine("Total score is: {0}, press any key again to start your next throw", totalScore);
                Console.Read();

            }
            
        }
        
        if (throws.Count == 21) // if last round includes a strike or spare
        {
           // totalScore = totalScore + firstThrow[9] + firstThrow[10] + 10 + secondThrow[9];
          

            if (throws[18] == 10) // if first throw in last round was a strike
            {
                isStrike = true; // need to set this bool true so we do not enter spare statement
                Console.Read();
                Console.WriteLine("You scored a STRIKE in your last round. Give it your all for the next two throws");
                Console.Read();
                totalScore = totalScore + firstThrow[9] + firstThrow[10] + secondThrow[9];
                //Console.WriteLine("Total score is: {0}", totalScore);
            }
            if (throws[19] == 10) // if second throw in last round was a strike
            {
                Console.Read();
                Console.WriteLine("ANOTHER STRIKE in your last round!!");
                Console.Read();
                //totalScore = totalScore + firstThrow[9] + firstThrow[10] + secondThrow[9];
                //Console.WriteLine("Total score is: {0}", totalScore);
            }
            if (throws[20] == 10) // if third throw in last round was a strike
            {
                Console.Read();
                Console.WriteLine("AND ANOTHER ONE! YOU ARE INSANE AT THIS GAME");
                Console.Read();
                //totalScore = totalScore + firstThrow[9] + firstThrow[10] + secondThrow[9];
                //Console.WriteLine("Total score is: {0}", totalScore);
            }

            else if (throws[18] + throws[19] == 10 && !isStrike) // if second throw in last round yields a spare
            {
                Console.Read();
                Console.WriteLine("You scored a SPARE in your last round. Give it your all for the next throw");
                Console.Read();
                totalScore = totalScore + firstThrow[9] + firstThrow[10] + secondThrow[9];
                //Console.WriteLine("Total score is: {0}", totalScore);
            }

            Console.Read();
            Console.WriteLine("Total score is: {0} ", totalScore);
            Console.Read();
        }

        
        else if (throws.Count == 20) // if last round does not include a strike or spare
        {
            totalScore = totalScore + firstThrow[9] + secondThrow[9];
            Console.Read();
            Console.WriteLine("Total score is: " + totalScore);
            Console.Read();
        }

        




    }
  
}


