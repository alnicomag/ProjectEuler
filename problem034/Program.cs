using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem034
{
	/// <summary>
	/// 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
	/// Find the sum of all numbers which are equal to the sum of the factorial of their digits.
	/// 
	/// Note: as 1! = 1 and 2! = 2 are not sums they are not included.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;

			for (int i = 3; i < 999999; i++)
			{
				List<int> factorials = new List<int>();
				int num_of_digits = i.ToString().Length;
				for (int j = 0; j < num_of_digits; j++)
				{
					factorials.Add(Factorial(int.Parse(i.ToString().Substring(j, 1))));
				}
				if (i == factorials.Sum())
				{
					sum += i;
				}
			}

			Console.WriteLine(sum);
			Console.ReadLine();
		}

		static int Factorial(int n)
		{
			if (n >= 2)
			{
				int ret = 1;
				for (int i = 1; i <= n; i++)
				{
					ret *= i;
				}
				return ret;
			}
			else if ((n == 1) || (n == 0))
			{
				return 1;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}
}
