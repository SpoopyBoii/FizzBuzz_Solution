using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("====================================");
			for (int n = 1; n <= 100; n++)
			{
				if (n % 3 == 0 && n % 5 == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (n % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (n % 5 == 0)
				{
					Console.WriteLine(n + " Buzz");
				}
				else
				{
					Console.WriteLine(n);
				}
			}
			Console.WriteLine("====================================");
			Console.WriteLine("Press any key to exit the program...");
			Console.WriteLine("====================================");
			Console.ReadLine();
		}
    }
}
