using System;

namespace NUnitTest_Dojo241120
{
    public class Calculator
    {
        public int integer;

        public Calculator()
        {
        }

        public double CalculateCircleSurface(int radius)
        {
           return Math.Round(Math.PI*Math.Pow(radius,2),2);
        }

        public class CalculateFactorielle
        {
            public CalculateFactorielle()
            {
            }
        }
    }
}