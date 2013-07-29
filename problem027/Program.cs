using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem027
{
	/// <summary>
	/// Euler discovered the remarkable quadratic formula:
	/// n² + n + 41
	/// It turns out that the formula will produce 40 primes for the consecutive values n = 0 to 39.
	/// However, when n = 40, 40^2 + 40 + 41 = 40(40 + 1) + 41 is divisible by 41, and certainly when n = 41, 41² + 41 + 41 is clearly divisible by 41.
	/// The incredible formula  n² − 79n + 1601 was discovered, which produces 80 primes for the consecutive values n = 0 to 79.
	/// The product of the coefficients, −79 and 1601, is −126479.
	/// Considering quadratics of the form:
	/// n² + an + b, where |a| ＜ 1000 and |b| ＜ 1000
	/// where |n| is the modulus/absolute value of n
	/// e.g. |11| = 11 and |−4| = 4
	/// Find the product of the coefficients, a and b, for the quadratic expression that produces the maximum number of primes for consecutive values of n, starting with n = 0.
	/// </summary>
	class Program
	{
		/// <summary>
		/// n=|b|の時必ずb,-bで割り切れる.
		/// n=0の時に2次式が素数になるには，bが素数
		/// n=0,1の時に2次式が素数になるには，1+a+bが素数でないと⇛aは奇数
		/// n=0,1,2の時に2次式が素数になるには，4+2a+bが素数でないと
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			var prime = Eratosthenes(2001000).ToList();
			var bs = Eratosthenes(1000).ToList();
			foreach (var item in Eratosthenes(1000))
			{
				bs.Add(-item);
			}
			bs.Sort();

			int max_a = 0;
			int max_b = 0;
			int max_n = 0;
			for (int a = -999; a < 1000; a+=2)
			{
				foreach (int b in bs)
				{
					int n = 0;
					int quadratic = b;
					while (prime.Exists(ln => ln == quadratic))
					{
						n++;
						quadratic = Math.Abs(Func(a,b,n));
					}
					if (n > max_n)
					{
						max_n = n;
						max_a = a;
						max_b = b;
					}
				}
			}

			Console.WriteLine(max_a * max_b);
			Console.ReadLine();
		}


		static int Func(int a,int b,int n)
		{
			return n * n + a * n + b;
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
