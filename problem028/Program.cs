using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace problem028
{
	/// <summary>
	/// Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:
	/// 21 22 23 24 25
	/// 20  7  8  9 10
	/// 19  6  1  2 11
	/// 18  5  4  3 12
	/// 17 16 15 14 13
	/// It can be verified that the sum of the numbers on the diagonals is 101.
	/// What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			var sw = new Stopwatch();
			sw.Start();

			const int N = 1001;

			int sum = 1;
			for (int i = 1; i <= (N - 1) / 2; i++)
			{
				sum += (2 * i - 1) * (2 * i - 1) + 2 * i;
				sum += (2 * i - 1) * (2 * i - 1) + 4 * i;
				sum += (2 * i - 1) * (2 * i - 1) + 6 * i;
				sum += (2 * i - 1) * (2 * i - 1) + 8 * i;
			}

			sw.Stop();
			Console.WriteLine(sw.Elapsed);
			Console.WriteLine(sum);
			Console.ReadLine();
		}
	}
}