using System;
using System.Web;

namespace Dojo_UnitTest_241120
{
    public class CalculatorFact
    {
        public int integer;

        public int CalculateFactorielle()
        {
            int factorielle = 1;
            for(int index=1; index<=integer; index++)
            {
                factorielle = factorielle * index;
            }
            return factorielle;
        }
    }
}
