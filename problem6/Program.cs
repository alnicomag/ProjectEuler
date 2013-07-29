using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem6
{
	/// <summary>
	/// The sum of the squares of the first ten natural numbers is,
	/// 1^2 + 2^2 + ... + 10^2 = 385
	/// The square of the sum of the first ten natural numbers is,
	/// (1 + 2 + ... + 10)^2 = 55^2 = 3025
	/// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
	/// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int n = 100;
			int sum = 0;
			for (int i = 1; i <= n; i++)
			{
				for (int j = i+1; j <= n; j++)
				{
					sum += i * j;
				}
			}
			Console.WriteLine(sum*2);
			Console.ReadLine();
		}
	}
}
