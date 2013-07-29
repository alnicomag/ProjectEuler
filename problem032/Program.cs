using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem032
{
	/// <summary>
	/// We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.
	/// The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.
	/// Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.
	/// HINT: Some products can be obtained in more than one way so be sure to only include it once in your sum.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			var sw = new Stopwatch();
			sw.Start();

			var list = new List<int>();

			for (int i = 123456789; i <= 987654321; i++)
			{
				
			}



			sw.Stop();
			Console.WriteLine(sw.Elapsed);
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
