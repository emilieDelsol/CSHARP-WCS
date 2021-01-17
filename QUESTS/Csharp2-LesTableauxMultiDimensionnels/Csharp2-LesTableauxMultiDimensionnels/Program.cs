using System;
using System.Globalization;

namespace Csharp2_LesTableauxMultiDimensionnels
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tableauBidimention = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
            int[][] tableauIrregulier = new int[3][];
            tableauIrregulier[0] = new int[3];
            tableauIrregulier[1] = new int[2];
            tableauIrregulier[2] = new int[1];

            for (int index = 0; index < tableauIrregulier.Length; index++)
            {
                for (int i = 0; i < tableauIrregulier[index].Length; i++)
                {
                    tableauIrregulier[index][i] = tableauBidimention[index, (i + index)];
                }
            }


            for (int i = 0; i < tableauIrregulier.Length; i++)
            {
                foreach (int value in tableauIrregulier[i])
                {
                    Console.WriteLine(value);
                    
                }
            }

            /***************************************************************************
            *J'ai d'abord écrit le programme ligne par ligne puis l'ai simplifié avec les boucles for:
            *J'ai commencé à ecrire toutes valeurs du tableauBidimention 
            *puis ai créé une boucle for pour 'ranger' les valeur de tableauBidimention[0,i] dans tableauIrregulier[0][i] puis [1,i+1] et enfin [2,i+2]
            *j'ai repéré les similitudes entre les 3 boucles pour en créer une seule. :)
            *
            *Idem pour les 3 boucles foreach, j'ai repéré les similitudes entre mes 3 boucle pour en créer une seule. 
            ***************************************************************************/
            /* 
            for (int i=0; i<tableauIrregulier[0].Length; i++)
            {
              tableauIrregulier[0][i] = tableauBidimention[0, i];
            }

            for (int j=0; j<tableauIrregulier[1].Length; j++)
            {
                tableauIrregulier[1][j] = tableauBidimention[1, (j+1)];
            }

            for (int k=0; k<tableauIrregulier[2].Length; k++)
            {
                tableauIrregulier[2][k] = tableauBidimention[2, (k+2)];
            }


            Console.WriteLine(tableauBidimention[0, 0]);
            Console.WriteLine(tableauBidimention[0, 1]);
            Console.WriteLine(tableauBidimention[0, 2]);
            Console.WriteLine(tableauBidimention[1,0]);
            Console.WriteLine(tableauBidimention[1,1]);
            Console.WriteLine(tableauBidimention[1,2]);
            Console.WriteLine(tableauBidimention[2,0]);
            Console.WriteLine(tableauBidimention[2,1]);
            Console.WriteLine(tableauBidimention[2,2]);
            Console.WriteLine("Et maintenant tableau irregulier index 0:");

        */
            //Simplifié avec une boucle for.. 
            /*foreach (int value in tableauIrregulier[0])
            {
              Console.WriteLine(value);
            }
            foreach (int value in tableauIrregulier[1])
            {
              Console.WriteLine(value);
            }
            foreach (int value in tableauIrregulier[2])
            {
              Console.WriteLine(value);
            }*/
        }
    }
}
