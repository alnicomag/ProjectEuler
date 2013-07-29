using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem015
{
	/// <summary>
	/// Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down,
	/// there are exactly 6 routes to the bottom right corner.
	/// How many such routes are there through a 20×20 grid?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			const int N = 20;
			BigInteger temp1 = Factorial(N*2);
			BigInteger temp2 = Factorial(N);
			Console.WriteLine(temp1 / temp2 / temp2);
			Console.ReadLine();
		}

		static BigInteger Factorial(long n)
		{
			if (n >= 1)
			{
				BigInteger ret = 1;
				for (int i = 1; i <= n; i++)
				{
					ret *= i;
				}
				return ret;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}
}
