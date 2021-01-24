using System;
using System.Linq;

namespace factorielleNombreEntier
{
    class Program
    {

        static void Main(string[] args)
        {

            bool binaire = false;

            while (binaire==false)
            {
                double somme = 0;
                Console.WriteLine("Entrer chaine de caractères composée de 0 et de 1");
                char[] chaine = Console.ReadLine().ToCharArray();
                Array.Reverse(chaine);

                int present = 0;
                for (int n = 0; n < chaine.Length; n++)
                {
                    Console.WriteLine(chaine[n]);
                    if (chaine[n] != '0' || chaine[n] != '1')
                    {
                        present++;
                    }
                    
                }
                Console.WriteLine(present);
                if (present == 0)
                {
                    for (int n = 0; n < chaine.Length; n++)
                    {
                        if (chaine[n] == '1')
                        {
                            //Console.WriteLine("{0} ^ {1} = {2}", 2, n, Math.Pow(2, n));
                            somme = somme + Math.Pow(2, n);
                        }
                        Console.WriteLine(somme);
                        binaire = true;
                    }
                }
                else
                {
                    Console.WriteLine("Vous n'avez pas entré un nombre binaire!");
                    binaire = false;

                }
                
                
            }
        }
    }
}

                /*double somme = 0;
                Console.WriteLine("Entrer chaine de caractères composée de 0 et de 1");
                char[] chaine = Console.ReadLine().ToCharArray();
                Array.Reverse(chaine);*/

                /*foreach (int value in chaine)
            {
                int present = 0;
                if(value!='0' || value!='1')
                {
                    present++;
                }
                
            }
            
            for (int n = 0; n < chaine.Length; n++)
            {
                if (chaine[n] == '1')
                {
                    Console.WriteLine("{0} ^ {1} = {2}", 2, n, Math.Pow(2, n));
                    somme = somme + Math.Pow(2, n);
                }
            }
            Console.WriteLine(somme);
        }

        }
    }*/
       
    

