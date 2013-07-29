using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace util
{
    public class Class1
    {
		static void LCM(string[] args)
		{

			int n = 10;
			List<int> list = new List<int>();
			for (int i = 2; i <= n; i++)
			{
				list.Add(i);
			}
			List<int> prime = Eratosthenes(n);
			int prime_count = 0;

			int lcm = 1;

			while (prime_count < prime.Count)
			{
				while (IsDivisible(list, prime[prime_count]))
				{
					lcm *= prime[prime_count];
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i] % prime[prime_count] == 0)
						{
							list[i] /= prime[prime_count];
						}
					}
					list.RemoveAll(ln => ln == 1);
				}
				prime_count++;
			}
			foreach (int i in list)
			{
				lcm *= i;
			}
			Console.WriteLine(lcm);
			Console.ReadLine();
		}

		static bool IsDivisible(List<int> list, long prime)
		{
			foreach (int i in list)
			{
				if ((i % prime == 0) && (i != prime))
				{
					return true;
				}
			}
			return false;
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
