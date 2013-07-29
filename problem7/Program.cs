using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem7
{
	/// <summary>
	/// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
	/// What is the 10 001st prime number?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int number = 10001;
			List<long> prime = new List<long>() { 2 };
			long range = 0;
			while (prime.Count < number)
			{
				range += 10000;
				prime = Eratosthenes(prime, range);
			}
			Console.WriteLine(prime[number - 1]);
			Console.ReadLine();
		}

		static List<long> Eratosthenes(List<long> base_prime, long last)
		{
			if (base_prime[base_prime.Count - 1] >= last)
			{
				throw new ArgumentException();
			}

			List<long> list = new List<long>(base_prime);
			for (long i = base_prime[base_prime.Count - 1] + 1; i <= last; ++i)
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
