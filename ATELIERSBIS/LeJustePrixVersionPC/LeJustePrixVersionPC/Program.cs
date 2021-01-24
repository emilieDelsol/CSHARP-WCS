using System;

namespace LeJustePrixVersionPC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number: ");
            Int32 userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a limit: ");
            Int32 limit = Convert.ToInt32(Console.ReadLine());
            Int32 computerGuess = limit / 2;
            Int32 increment = computerGuess;
            bool finished = false;
            Int32 turn = 0;
            while (!finished)
            {
                Console.WriteLine("Computer guess is: {0}", computerGuess);
                Console.WriteLine("+ or -? ");
                string userHint = Console.ReadLine();
                if (userHint == "+")
                {
                    increment = increment / 2;
                    if (increment <= 1)
                    {
                        increment = 1;
                    }
                    computerGuess = computerGuess + increment;
                    turn++;
                }
                else if (userHint == "-")
                {
                    increment = increment / 2;
                    if (increment <= 1)
                    {
                        increment = 1;
                    }
                    computerGuess = computerGuess - increment;
                    turn++;
                }
                else
                {
                    Console.WriteLine("Enter a valid argument! ");
                }
                if (computerGuess == userChoice)
                {
                    finished = true;
                }
            }
            Console.WriteLine("Computer win!! In {0} turns. It was {1} !", turn, computerGuess);
        }
    
    }
}
