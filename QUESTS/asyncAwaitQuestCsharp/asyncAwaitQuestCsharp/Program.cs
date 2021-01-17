using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace asyncAwaitQuestCsharp
{
	class Program
	{
            static async Task<Int32> Main(string[] args)

            {
                var task1 = SomeOpAsync();
                var task2 = SomeOpAsync();

                await Task.WhenAll(task1, task2);

                Console.WriteLine("Main Thread Completed");

                Console.ReadLine();
                 return 0;

            }

		private async static Task SomeOpAsync()
		{
            Random rng = new Random();

            Int32 waitTime = rng.Next(1000, 7000);

            await Task.Delay(waitTime);

            Console.WriteLine("The task has waited " + waitTime);

		}
	}
}
