using System;

namespace rolldice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro / Get the numbers of times dice will be rolled
            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.Write("How many dice rolls would you like to emulate? ");
            int numberOfRolls = int.Parse(Console.ReadLine());


            // Create an array to keep track of the number of times each total number is thrown
            int[] sums = new int[13];

            // Foor loop to get the die to get rolled
 
            for (int i = 0; i < numberOfRolls; i++)
            {
                // Roll the dice
                int die1 = RollDie();
                int die2 = RollDie();

                int total = die1 + die2;

                // Increment the total in the array
                sums[total]++;
            }

            // Print the Histogram of the percentage
            for (int i = 2; i < 13; i++)
            {
                Console.Write("Total {0}: ", i);
                for (int j = 0; j < ((sums[i] * 100) / numberOfRolls); j++) // Grab the Percentage of the Numbers rolled and times rolled
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Thank you for playing!  Goodbye");
        }

        // Method to simulate rolling a single die
        static int RollDie()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

    }
}
