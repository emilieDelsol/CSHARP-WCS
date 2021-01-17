using System;

namespace deuxiemeMethodeTri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Entrer une taille de Tableau :");
            int sizeTable = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sizeTable; i++)
                Console.WriteLine("Entrer un nombre :");
                int number = Convert.ToInt32(Console.ReadLine());
            {
                int arr[i] = number;
            }*/
            int[] integer = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
            
            ArraySorter arraySorter = new ArraySorter();


            
            arraySorter.Ecriture(integer);
            Console.WriteLine("First table: ");
            arraySorter.Lecture();
            Console.WriteLine("Insertion Sort :");
            arraySorter.InsertionSort(integer);
            arraySorter.Lecture();
           
            int[] integer2 = new int[5] { 78, 55, 45, 98, 13 };

            arraySorter.Ecriture(integer2);
            Console.WriteLine("Second table: ");
            arraySorter.Lecture();
            Console.WriteLine("Bubble Sort :");
            arraySorter.BubbleSort(integer2);
            arraySorter.Lecture();

        }
        class ArraySorter
        {
            private int[] _integerTable;
            public void Lecture()
            {
                foreach (int value in _integerTable)
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine();
            }
            public void Ecriture(int[] integer)
            {
                _integerTable = integer;
            }

            public int[] InsertionSort(int[] _integerTable)
            {

                for (int i = 1; i < _integerTable.Length; i++)
                {
                    int val = _integerTable[i];
                    int flag = 0;
                    for (int j = i - 1; j >= 0 && flag != 1;)
                    {
                        if (val < _integerTable[j])
                        {
                            _integerTable[j + 1] = _integerTable[j];
                            j--;
                            _integerTable[j + 1] = val;
                        }
                        else
                        {
                            flag = 1;
                        }
                    }

                }

                return _integerTable;

            }

            public int[] BubbleSort(int[] _integerTable)
            {
                for (int j = 0; j <= _integerTable.Length - 2; j++)
                {
                    for (int i = 0; i <= _integerTable.Length - 2; i++)
                    {
                        if (_integerTable[i] > _integerTable[i + 1])
                        {
                            int temp = _integerTable[i + 1];
                            _integerTable[i + 1] = _integerTable[i];
                            _integerTable[i] = temp;
                        }
                    }
                }
                return _integerTable;
            }
        }
    }
}
