using NUnitTestProject1;
using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {          
            RollMany(20,1);
        }
        public static void RollMany(int rolls, int pints)
        {
            BowlingGame Game = new BowlingGame();
            for (int i = 0; i < rolls; i++)
            {
                Game.Roll(pints);
            }
            Console.WriteLine(Game.Score());

        }
    }
}
