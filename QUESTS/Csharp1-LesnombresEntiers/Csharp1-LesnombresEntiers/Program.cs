using System;

namespace Csharp1_LesnombresEntiers
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = int.MaxValue;
            long y = long.MaxValue;
            short z = short.MaxValue;

            ulong result =(ulong) (x + y + z);

            ulong result2 = (ulong)((ulong)x + (ulong)y + (ulong)z);

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}
