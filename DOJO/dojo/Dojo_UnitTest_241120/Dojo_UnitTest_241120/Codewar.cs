using System;

namespace NUnitTest_Dojo241120
{
    public class Codewar
    {
        public Codewar()
        {
        }
        // charrarray = ['a','b','c','d','e','f']
        public string[] SplitString(string str)
        {

            int strLenght = str.Length;
            Console.WriteLine($"La longueur de {str} est {strLenght}");


            if (str.Length % 2 == 0) //It is odd
            {
                string[] result = new string[Math.Abs(str.Length / 2)];
                int j = 0;
                if (result.Length % 2 == 0)
                {
                    for (int i = 0; i <= result.Length + 2; i = i + 2)
                    {
                        result[j] = String.Concat(str[i], str[i + 1]);
                        j++;
                    }
                    result[j] = String.Concat(str[str.Length - 2], str[str.Length - 1]);
                }
                else
                {
                    for (int i = 0; i <= result.Length; i = i + 2)
                    {
                        result[j] = String.Concat(str[i], str[i + 1]);
                        j++;
                    }
                }
                return result;


            }

            else
            {
                string[] result = new string[(str.Length + 1) / 2];
                int j = 0;
                Console.WriteLine($"La longueur de result.Lenght pour {str} est {result.Length}");
                if (result.Length % 2 == 0)
                {
                    for (int i = 0; i < result.Length+3 ; i = i + 2) // It is even
                    {
						if (str.Length == 3)
						{
                            result[0] = String.Concat(str[0], str[1]);
                            result[1] = String.Concat(str[2], "_");
                            return result;
						}
                        result[j] = String.Concat(str[i], str[i + 1]);
                        j++;
                    }
                    result[j] = String.Concat(str[str.Length - 1], "_");
                    return result;
                }
                else
                {
                    for (int i = 0; i <= result.Length+1; i = i + 2) // It is even
                    {
                        result[j] = String.Concat(str[i], str[i + 1]);
                        j++;
                    }
                    result[j] = String.Concat(str[str.Length - 1], "_");
                    return result;
                }
            }

            


        }
    }
}