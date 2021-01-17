using System;

namespace Csharp2_LesNombresDecimaux
{
    class Program
    {
        static void Main(string[] args)
        {
            float piFloat = (float)Math.PI;
            double piDouble = (double)Math.PI;
            decimal piDec = (decimal)Math.Round(Math.PI,10);

            Console.WriteLine("affichage de la valeur de Pi la moins précise: " + piFloat);
            Console.WriteLine("affichage de la valeur de Pi un peu plus précise: " + piDec);
            Console.WriteLine("affichage de la valeur de Pi la plus précise: " + piDouble + " l'affichage de Math.PI est la plus précise car Math.PI est un double");
            decimal myPi = (decimal)Math.Round(Math.PI, 10);
            Console.WriteLine(myPi);
        }
    }
}
