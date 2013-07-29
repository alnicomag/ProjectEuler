using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem020
{
	/// <summary>
	/// n! means n × (n − 1) × ... × 3 × 2 × 1
	/// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
	/// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
	/// Find the sum of the digits in the number 100!
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			const int N = 100;
			char[] digits = Factorial(N).ToString().ToCharArray();
			int sum=0;
			foreach (char digit in digits)
			{
				sum += int.Parse(digit.ToString());
			}
			Console.WriteLine(sum);
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
