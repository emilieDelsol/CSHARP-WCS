using System;

namespace DojoSolution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            Int32 n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("version itérative");
            Console.WriteLine(n + "!=" + IterativeFactorial(n));
            Console.WriteLine("version récursive");
            Console.WriteLine(n + "!=" + RecursiveFactorial(n));
        }

        static Int32 IterativeFactorial(Int32 n)
        {
            //resultat = 1
            
            Int32 resultat = 1;
            //Pour i allant de n a 1 par pas de -1
           
            for (Int32 i = n; i > 0; i--)
            { 
            //resultat= resultat*i
                resultat = resultat * i;
            }
            //retourner resultat
            return resultat;
        }

        static Int32 RecursiveFactorial(Int32 n)
        {
            //Si n==1 ou n==0 
            if ((n==1)||(n==0)) //Condition de terminaison
                {
                    //retourne1
                    return 1;
                }
                
            //sinon
            else
            {
                //retourne n*RecursiveFactorial(n-1)
                return n*RecursiveFactorial(n-1);
            }
                
        }
    }
}
