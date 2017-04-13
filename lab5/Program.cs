using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Continue Loop
            bool askToContinue = false;

            // Game Loop
            do
            {
                Console.WriteLine("Welcome to the Grand Circus Casino!");
                Console.WriteLine();


                //Declare Variable and Call Methods
                int input = GetValidInteger();
                int randomNumber = GetRandom();
                Console.WriteLine();
                Console.WriteLine(randomNumber);
                int randomNumber1 = GetRandom1();
                Console.WriteLine();
                Console.WriteLine(randomNumber1);


                // Determine Dice Rolled
                if (randomNumber == 1 && randomNumber1 == 1)
                {
                    Console.WriteLine("SNAKE EYES AND YOU'RE A LOSER!!!");

                }
                else if (randomNumber + randomNumber1 == 7 || randomNumber + randomNumber1 == 11)

                {
                    Console.WriteLine("WINNER!!");
                }

                else if (randomNumber + randomNumber1 == 2 || randomNumber + randomNumber1 == 3|| randomNumber+randomNumber1==12 )
                {
                    Console.WriteLine("YOU ARE A LOSER!!");

                }

                else if ( randomNumber == 6 && randomNumber1 == 6)
                {
                    Console.WriteLine("BOX CARS");

                }


                // Try Again?
                Console.WriteLine("Do You Want to Try Again?" + " " + "(Y/N)"); // add user input if they want to try again
                Console.WriteLine();
                if (Console.ReadLine().ToUpper() == "Y")
                    askToContinue = true;
                else
                {
                    Console.WriteLine("Thanks for Playing!");
                    return;
                  }
                }


                // Continue Loop
                while (askToContinue);
                }


                // Method get Valid Int
                public static int GetValidInteger()
                {
                int input;
                Console.WriteLine("Please Enter the Number of Sides for a Pair of Dice: ");
                Console.WriteLine();
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                Console.WriteLine("Invalid Entry!  Please Enter an Integer!");

                }
                return input;
                }

                public static int GetRandom()
                {

                Random random = new Random(Guid.NewGuid().GetHashCode());
                int randomNumber = random.Next(1, 6);
                return randomNumber;
                }

                public static int GetRandom1()
                {

                Random random1 = new Random();
                int randomNumber1 = random1.Next(1, 6);
                return randomNumber1;
        }
    }
}