using System;

namespace Csharp_Encapsulation_beerEncapsulation
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BeerEncapsulator beerEncapsulator = new BeerEncapsulator();

            while (beerEncapsulator.GetAvalaibleBeerVolume() <= 0 || beerEncapsulator.GetAvalaibleBottles() <= 0 || beerEncapsulator.GetAvalaibleCapsules() <= 0)
            {
                Console.WriteLine("Enter beer quantity:");
                beerEncapsulator.SetAvalaibleBeerVolume(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Enter number bottles avalaible: ");
                beerEncapsulator.SetAvalaibleBottles(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Enter number caps avalaible: ");
                beerEncapsulator.SetAvalaibleCapsules(Convert.ToInt32(Console.ReadLine()));

            }
            Console.WriteLine("\nWe have {0} L of beer, {1} bottles and {2} capsules in stock", beerEncapsulator.GetAvalaibleBeerVolume(), beerEncapsulator.GetAvalaibleBottles(), beerEncapsulator.GetAvalaibleCapsules());

            Console.WriteLine("\nHow many bottles do you want? ");
            int nbBottles = (Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("You want {0} bottle(s).", nbBottles);

            Console.WriteLine("\n*********************************\n");
            Console.WriteLine("I have encapsulate {0} bottles", beerEncapsulator.ProduceEncapsulateBeerBottles(nbBottles));


            if (!beerEncapsulator.CanProduce(nbBottles))
            {
                if (beerEncapsulator.GetAvalaibleBeerVolume() < nbBottles * 0.33)
                {

                    Console.WriteLine(" We need {0} L of beer", (nbBottles * 0.33) - beerEncapsulator.GetAvalaibleBeerVolume());
                }
                if (beerEncapsulator.GetAvalaibleBottles() < nbBottles)
                {
                    Console.WriteLine("We need {0} bottles", nbBottles - beerEncapsulator.GetAvalaibleBottles());
                }
                if (beerEncapsulator.GetAvalaibleCapsules() < nbBottles)
                {
                    Console.WriteLine("we need {0} capsules", nbBottles - beerEncapsulator.GetAvalaibleCapsules());
                }
            }

            if (beerEncapsulator.CanProduce(nbBottles))
            {
                for (int i = 1; i <= nbBottles; i++)
                {
                    beerEncapsulator.AddBeer();
                    beerEncapsulator.Encapsulate();
                }
                Console.WriteLine("There is {0} liter of beer, {1} empty bottles and {2} capsules in stock", beerEncapsulator.GetAvalaibleBeerVolume(), beerEncapsulator.GetAvalaibleBottles(), beerEncapsulator.GetAvalaibleCapsules());

            }

        }
    }
}
