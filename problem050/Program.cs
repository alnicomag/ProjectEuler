using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem050
{
	/// <summary>
	/// The prime 41, can be written as the sum of six consecutive primes:
	/// 41 = 2 + 3 + 5 + 7 + 11 + 13
	/// This is the longest sum of consecutive primes that adds to a prime below one-hundred.
	/// The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.
	/// Which prime, below one-million, can be written as the sum of the most consecutive primes?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			const int N = 1000000;
			var prime = Eratosthenes(N).ToList();
			int count = CountBelowSum(prime, N);
			int sum = 0;
			bool found = false;
			while (!found)
			{
				int start_index = 0;
				sum=0;
				bool is_prime = false;
				do
				{
					sum = prime.Where(ln => (prime[start_index] <= ln) && (ln <= prime[start_index + count - 1])).Sum();
					is_prime = prime.Exists(ln => ln == sum);
					start_index++;
				}
				while (!is_prime && (sum < N));
				if (is_prime && (sum < N))
				{
					found = true;
				}
				count--;
			}

			Console.WriteLine(sum);
			Console.ReadLine();
		}

		/// <summary>
		/// listの最初の要素から順に足していく時，その総和がthresholdを超えない，その要素数を返す
		/// </summary>
		/// <param name="list"></param>
		/// <param name="threshold"></param>
		/// <returns></returns>
		static int CountBelowSum(List<int> list, int threshold)
		{
			int index = 0;
			int sum = 0;
			while ((sum += list[index]) < threshold)
			{
				index++;
			}
			return index;
		}

		static IEnumerable<int> Eratosthenes(int n)
		{
			var list = new List<int>();
			for (int i = 2; i <= n; ++i)
			{
				list.Add(i);
			}

			int new_prime = list[0];
			while (new_prime * new_prime <= list[list.Count - 1])
			{
				yield return new_prime;
				list.RemoveAll(ln => ln % new_prime == 0);
				new_prime = list[0];
			}
			foreach (var item in list)
			{
				yield return item;
			}
		}
	}
}
