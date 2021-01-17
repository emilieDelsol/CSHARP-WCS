using System;

namespace CorrectionDojo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool isNotBinary=true;
            string binary = string.Empty;
            while (isNotBinary)
            {
                Console.WriteLine("Entrez une chaine de caractères:");
                binary = Console.ReadLine();
                foreach(char symbol in binary)
                {
                    if (symbol != '1' && symbol!='0')
                    {
                        isNotBinary=true;
                        break;
                    }
                    else
                    {
                        isNotBinary=false;
                    }
                }
            }

            Console.WriteLine("Le resultat de " + ConvertBinaryToInteger(binary));
        }

        static Int32 ConvertBinaryToInteger(string binary)
        {
            
            //Resultat=0;
            Int32 resultat=0;
            //Renverser tableau(binary)
            char[] binariesArray = binary.ToCharArray();
            Array.Reverse(binariesArray);
            // Pour i allant de 0 à binary.taille par pas de 1
            for (Int32 i = 0; i < binary.Length; i++)
            {
                Int32 bit = Convert.ToInt32(binariesArray[i].ToString());
                //resultat= resultat+binary[i]*(2^i)
                resultat = resultat + (bit * (Int32)(Math.Pow(2, i)));
            }
            //Retourner resultat
            return resultat;
        }
    }
}
