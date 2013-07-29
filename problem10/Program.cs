using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem010
{
	/// <summary>
	/// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
	/// Find the sum of all the primes below two million.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			List<long> prime = Eratosthenes(1999999);
			long sum=0;
			foreach (long i in prime)
			{
				sum += i;
			}
			Console.WriteLine(sum);
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
