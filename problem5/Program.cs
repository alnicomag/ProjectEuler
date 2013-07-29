using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem5
{
	/// <summary>
	/// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
	/// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(2*2*2*2*3*3*5*7*11*13*17*19);

			int n = 10;
			List<int> list = new List<int>();
			for (int i = 2; i <= n; i++)
			{
				list.Add(i);
			}
			List<int> prime = Eratosthenes(n);
			int prime_count = 0;

			
		}

		static int[] PrimeFactorization(int subject, int max)
		{

			return null;
		}

		static List<int> Eratosthenes(int n)
		{
			List<int> list = new List<int>();
			for (int i = 2; i <= n; ++i)
			{
				list.Add(i);
			}
			List<int> prime = new List<int>();

			do
			{
				int new_prime = list[0];
				list.RemoveAll(ln => ln % new_prime == 0);
				prime.Add(new_prime);
			}
			while (prime[prime.Count - 1] * prime[prime.Count - 1] < list[list.Count - 1]);
			prime.AddRange(list);

			return prime;
		}
	}
}
