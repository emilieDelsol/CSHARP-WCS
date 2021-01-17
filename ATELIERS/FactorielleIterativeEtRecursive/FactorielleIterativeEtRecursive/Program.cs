using System;

namespace FactorielleIterativeEtRecursive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un entier n:");
            int n=Convert.ToInt32(Console.ReadLine());
            //f=1 resultat factorielle
            

            int resultIter= FactorielleIterative(n);
            int resultRecurs = FactorielleRecursive(n);
            Console.WriteLine("resultat de la fonction factorielle itérative: de n = {0}",n);
            Console.WriteLine("\t {0}! = {1}",n,resultIter);
            Console.WriteLine("resultat de la fonction factorielle récursive: de n = {0}", n);
            Console.WriteLine("\t{0}! = {1}", n, resultRecurs);
        }
        static int FactorielleIterative (int n)
        {
            //n!=n*(n-1)!
            int f=1;
            //pour i=1; i<=n-1; i++
            for (int i = 1; i <= n; i++)
            {
                //faire f= f*i
                f = f * i;
            }
            //retourner f
            return f;

        }

        static int FactorielleRecursive(int n)
        {
            //n!=n*(n-1)!
            //3!=3*(3-1)!=3*2*1!
            if ((n==1)||(n==0))
            {
                return 1;
            }
            else
            {
                return n*FactorielleRecursive(n-1);
            }
           
            //5!=5*(5-1)!
            //5*4*(4-1)!
            //5*4*3*(2)!
            //5*4*3*2*(1)!
            //5*4*3*2*1

        }
    }
}
