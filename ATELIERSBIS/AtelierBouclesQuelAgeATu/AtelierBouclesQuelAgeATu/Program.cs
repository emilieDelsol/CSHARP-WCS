using System;

namespace AtelierBouclesQuelAgeATu
{
    class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {
                Console.WriteLine("Quel est ton age?");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 1)
                {
                    Console.WriteLine("Erreur système");
                }
                else if (age < 18)
                {
                    Console.WriteLine("Vous êtes mineur");
                }
                else if (age >= 18 && (age >= 25 && age <= 30))
                {
                    Console.WriteLine("Tu commences ton chemin d'adulte");
                }

                else if (age >= 18 && (age > 30 && age <= 70))
                {
                    Console.WriteLine("Vous êtes un adulte");
                }
                else if ((age >= 18) && age > 70)
                {
                    Console.WriteLine("Vous êtes en béton armé!");
                }
                else
                {
                    Console.WriteLine("Vous êtes majeur");
                }
            }
            
        }
    }
}
