using System;

namespace Csharp2_LesBoucles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] moves = new string[32];
            int i = 0;
            string move;
            while (i < 32)
            {
                Console.WriteLine("Enter a move:");
                move = Console.ReadLine();
                if (move != "done")
                {
                    moves[i] = move;
                    i++;
                }
                else
                {
                    break;
                }
                Console.WriteLine("Chose how many times you want to repeat ");
                int nb = Convert.ToInt32(Console.ReadLine());
                for (int it = 0; it < nb; it++)
                {
                    foreach (string iteration in moves)
                    {
                        Console.WriteLine(iteration);
                    }
                }
            }
        }
    }
}
