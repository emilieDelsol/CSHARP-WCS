using System;

namespace Csharp1_UnTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table1 = new int[3];
            int[] table2 = new int[3];
            int lenthTable = (table1.Length + table2.Length);
            int[] table3 = new int[lenthTable];


            // initialisation des valeurs
            table1 = new int[] { 1, 2, 3 };
            table2 = new int[] { 4, 5, 6 };


            for (int i = 0; i < 3; i++)
            {
                table3[i] = table1[i];
            }
            for (int i2 = 0; i2 < table2.Length; i2++)
            {
                table3[(table1.Length + i2)] = table2[i2];
            }

            foreach (int valueTable in table3)
            {
                Console.WriteLine(valueTable);
            }
        }
    }
}
