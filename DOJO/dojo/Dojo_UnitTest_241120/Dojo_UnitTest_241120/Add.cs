using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo_UnitTest_241120
{
    public class Add
    {
        public int[] ValueSet;

        public int[] AddCalculator()
        {
            for(int i=1; i<=ValueSet.Length-1; i++)
            {
                ValueSet[i] = ValueSet[i] + ValueSet[i - 1];
            }
            return ValueSet;
        }
    }
}
