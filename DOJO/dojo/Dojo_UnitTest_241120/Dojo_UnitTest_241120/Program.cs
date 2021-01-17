using NUnitTest_Dojo241120;
using System;

namespace Dojo_UnitTest_241120
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string entry = "ZQVIGRmmOAWOmmo";
            string entry2 = "abcdefg";
            string[] result_entry = { "ab", "cd", "e_" };
            string[] result_entry2 = { "ab", "cd", "ef" };
            
            var codewar = new Codewar();
            codewar.SplitString(entry);
            codewar.SplitString(entry2);
            
            string[] resultat_expected = codewar.SplitString(entry);
            string[] resultat_expected2 = codewar.SplitString(entry2);
            foreach(string value in resultat_expected2)
            {
                Console.WriteLine(value);
            }

            foreach (string value2 in resultat_expected)
            {
                Console.WriteLine(value2);
            }

        }
    }
}
