using System;
using System.Globalization;

namespace AtelierBouclesConditionsEtBoucles
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "start";

            while (n != "stop")
            {
                Console.WriteLine("Entrez un nombre flottant:");
                n = Console.ReadLine();
                double nFloat = double.Parse(n,CultureInfo.InvariantCulture);
                Console.WriteLine("nFloat est egal à :" + nFloat);
                if (nFloat < 0.0 || nFloat > 100.999999)
                {   
                    Console.WriteLine("Erreur!");
                    Console.WriteLine("Entrez un autre nombre flottant:");
                }


            }

        }
    }
}
