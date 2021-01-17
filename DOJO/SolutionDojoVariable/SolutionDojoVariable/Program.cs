using System;

namespace SolutionDojoVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------Multiples ou premier-----------------
            Int32 entier1 = Convert.ToInt32(Console.ReadLine());
            Int32 entier2 = Convert.ToInt32(Console.ReadLine());
            Int32 entierMax = Math.Max(entier1, entier2);
            Int32 entierMin = Math.Min(entier1, entier2);
            //------------------------------------------------------
            if IsMultipleOf(entierMax,entierMin)
            {
                Console.WriteLine(entierMax + "est multiple" + entierMin);
            }
            else
            {
                Console.WriteLine(entierMax + " est entier avec " + entierMin);
            }
        }
        static bool IsMultipleOf (Int32 x, Int32 y)
        {
            //si x%y=0
                //retourner vrai
            //sinon
                //retourner faux
            if ((x % y == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
