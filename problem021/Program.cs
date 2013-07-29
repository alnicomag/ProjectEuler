using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem021
{
	/// <summary>
	/// Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
	/// If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
	/// For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284.
	/// The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
	/// Evaluate the sum of all the amicable numbers under 10000.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			for (int i = 1; i <= 10000; i++)
			{
				if (IsAmicable(i))
				{
					sum += i;
				}
			}
			Console.WriteLine(sum);
			Console.ReadLine();
		}

		static bool IsAmicable(int n)
		{
			int m = ProperDivisorsSum(n);
			return (n != m) && (n == ProperDivisorsSum(m));
		}

		static int ProperDivisorsSum(int n)
		{
			int sum = 0;
			int first_half_max = 0;
			for (int i = 1; i * i < n; i++)
			{
				if (n % i == 0)
				{
					sum += (i + n / i);
				}
				first_half_max = i;
			}
			if ((first_half_max + 1) * (first_half_max + 1) == n)
			{
				sum += first_half_max + 1;
			}
			return sum-n;
		}
	}
}
