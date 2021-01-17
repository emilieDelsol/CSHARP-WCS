using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo_UnitTest_241120
{

    public class Transformator
    {
        public string Strings { get; set; }

        public char[] ToCharAndUppercase()
        {
            char[] stringToCharArray = Strings.ToCharArray();

            for (int index = 0; index < stringToCharArray.Length; index++)
            {
                stringToCharArray[index] = Char.ToUpper(stringToCharArray[index]);
            }

            return stringToCharArray;
        }
    }
}
