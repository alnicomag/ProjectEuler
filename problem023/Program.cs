using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem023
{
	/// <summary>
	/// A perfect number is a number for which the sum of its proper divisors is exactly equal to the number.
	/// For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
	/// A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.
	/// As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24.
	/// By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers.
	/// However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.
	/// Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			List<int> abundant = new List<int>();

			for (int i = 1; i <= 28113; i++)
			{
				if (IsAbundant(i))
				{
					abundant.Add(i);
				}
			}

			int sum = 0;
			for (int i = 1; i <= 28113; i++)
			{
				bool find = false;
				int count = 0;
				while ((!find)&&(count<abundant.Count)&&(i>abundant[count]))
				{
					if (abundant.Exists(ls => ls == i - abundant[count]))
					{
						sum += i;
						find = true;
					}
					count++;
				}
			}

			Console.WriteLine((1+28113)*28113/2-sum);
			Console.ReadLine();
		}

		/// <summary>
		/// 過剰数かどうか
		/// </summary>
		/// <param name="n"></param>
		/// <returns></returns>
		static bool IsAbundant(int n)
		{
			List<int> divisors = new List<int>();
			int first_half_max = 0;
			for (int i = 1; i * i < n; i++)
			{
				if (n % i == 0)
				{
					divisors.Add(i);
					divisors.Add(n / i);
				}
				first_half_max = i;
			}
			if ((first_half_max + 1) * (first_half_max + 1) == n)
			{
				divisors.Add(first_half_max + 1);
			}
			return divisors.Sum() > 2 * n;
		}
	}
}
