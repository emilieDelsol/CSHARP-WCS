using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace justePrixVersionMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number: ");
            Int32 userChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose a limit: ");
            Int32 limit = Convert.ToInt32(Console.ReadLine());
            Int32 increment = limit;
            Int32 computerGuess = limit / 2;

            bool finished = false;

            while (!finished)
            {
                PlayTurn(userChoice, computerGuess, limit, increment);   
            }

            Console.WriteLine("Computer Win!!!");
            /*
            Console.WriteLine("Is it " + computerGuess + " ?");
            Console.WriteLine("+ or -? ");
            string userHint = Console.ReadLine();

            if (userHint == "+")
            {
                increment = increment / 2;
                if (increment < 1)
                {
                    increment = 1;
                }
                computerGuess = computerGuess + increment;

            }
            else if (userHint == "-")
            {
                increment = increment / 2;
                if (increment < 1)
                {
                    increment = 1;
                }
                computerGuess = computerGuess - increment;
            }
            else
            {
                Console.WriteLine("Enter + or - ");
            }*/
        }

        public static bool PlayTurn(int userChoice , int computerGuess, int limit, int increment)
        {
            PrintUserHint(computerGuess, userChoice, limit, increment);
            if (userChoice!=computerGuess)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void PrintUserHint(int computerGuess, int userChoice, int limit, int increment)
        {
            
            Console.WriteLine("Computer Guess:{0} ",computerGuess);
            Console.WriteLine("Is it + or -?");
            string userHint=Console.ReadLine();
            if (userHint=="+")
            {
                Console.WriteLine("Is it more!");
                increment = increment / 2;
                computerGuess = computerGuess + increment;
                Console.WriteLine(computerGuess);
            }
            else if (userHint=="-")
            {
                Console.WriteLine("is it less!");
                increment = increment / 2;
                computerGuess = computerGuess - increment;
            }
            
        }




        
    }
}
    
