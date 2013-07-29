using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem3
{
	/// <summary>
	/// The prime factors of 13195 are 5, 7, 13 and 29.
	/// What is the largest prime factor of the number 600851475143 ?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			long number = 600851475143;
			List<long> prime = Eratosthenes((long)Math.Sqrt(number));

			for (int i = prime.Count - 1; i >= 0; --i)
			{
				if (number % prime[i] == 0)
				{
					Console.WriteLine(prime[i]);
				}
			}
			Console.ReadLine();
		}

		static List<long> Eratosthenes(long n)
		{
			List<long> list = new List<long>();
			for (int i = 2; i <= n; ++i)
			{
				list.Add(i);
			}
			List<long> prime = new List<long>();

			do
			{
				long new_prime = list[0];
				list.RemoveAll(ln => ln % new_prime == 0);
				prime.Add(new_prime);
			}
			while (prime[prime.Count - 1] * prime[prime.Count - 1] < list[list.Count - 1]);
			prime.AddRange(list);

			return prime;
		}
	}
}
