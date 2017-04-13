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
            bool askToContinue = false;
            do
            {
                int input;
                Console.WriteLine("enter the number of sides for a pair of dice");
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("input is not an integer, please enter an integer!");

                }
                Random random = new Random();
                int randomNumber = random.Next(1, 6);
                int randomNumber1 = random.Next(1, 6);
                Console.WriteLine(randomNumber);
                Console.WriteLine(randomNumber1);

                Console.WriteLine("do you want to try again, ?" + " " + "(Y/N)"); // add user input if they want to try again
                if (Console.ReadLine().ToUpper() == "Y")
                    askToContinue = true;
                else
                {
                    Console.WriteLine("thanks for trying!");
                    return;




                }
            } while (askToContinue);

        }
    }
}