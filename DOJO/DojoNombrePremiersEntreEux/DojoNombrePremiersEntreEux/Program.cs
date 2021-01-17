using System;

namespace DojoNombrePremiersEntreEux
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entrez un entier");
            int entier1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez un deuxième entier");
            int entier2 = Convert.ToInt32(Console.ReadLine());

            Int32 entierMax = Math.Max(entier1, entier2);
            Int32 entierMin = Math.Min(entier1, entier2);
            
           
            if (entierMax % entierMin != 0)
            {
                Console.WriteLine("PREMIERS");
            }
            else
            {
                Console.WriteLine("MULTIPLES");
            }
        }
    }
}
