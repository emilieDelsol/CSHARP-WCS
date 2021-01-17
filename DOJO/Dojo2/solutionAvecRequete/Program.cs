using System;
using System.Collections.Generic;
using System.Linq;


namespace solutionAvecRequete
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "3", "4", "2", "1" };

            IEnumerable<string> query = from word in words orderby word.Substring(0, 1) ascending select word;

            foreach (string str in query)
                Console.WriteLine(str);
        }
    }
}