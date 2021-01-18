using System;

namespace AtelierBouclesTableDeMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true) 
            {
                Console.WriteLine("Entrez un nombre:");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i=1; i<10; i++)
                {
                    Console.WriteLine(n+ " * "+ i +" = " + n * i);
                }
            }
        }
    }
}
