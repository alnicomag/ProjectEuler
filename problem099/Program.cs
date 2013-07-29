using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Numerics;

namespace problem099
{
	/// <summary>
	/// Comparing two numbers written in index form like 2^11 and 3^7 is not difficult, as any calculator would confirm that 2^11 = 2048 ＜ 3^7 = 2187.
	/// However, confirming that 632382^518061 ＞ 519432^525806 would be much more difficult, as both numbers contain over three million digits.
	/// Using base_exp.txt (right click and 'Save Link/Target As...'), a 22K text file containing one thousand lines with a base/exponent pair on each line, determine which line number has the greatest numerical value.
	/// NOTE: The first two lines in the file represent the numbers in the example given above.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			var sw = new Stopwatch();
			sw.Start();

			var given = new List<int[]>();
			using(StreamReader sr = new StreamReader(@"base_exp.txt")){
				while (!sr.EndOfStream)
				{
					var temp = sr.ReadLine().Split(',');
					given.Add(new int[2] { int.Parse(temp[0]), int.Parse(temp[1]) });
				}
			}

			var list = new List<BigInteger>();
			foreach (var item in given)
			{
				list.Add(Power(item[0], item[1]));
			}

			

			sw.Stop();
			Console.WriteLine(sw.Elapsed);
			Console.WriteLine();
			Console.ReadLine();
		}

		static BigInteger Power(int a, int b)
		{
			BigInteger ret = 1;
			for (int i = 0; i < b; i++)
			{
				ret *= a;
			}
			return ret;
		}

		static Dictionary<int, int> PrimeDecomp(int n)
		{
			var primedecomp = new Dictionary<int, int>();
			var primes = Eratosthenes(n).ToList();

			int prime_index = 0;
			while (n != 1)
			{
				int a = primes[prime_index];
				int count = 0;
				while (n % a == 0)
				{
					count++;
					n /= a;
				}
				primedecomp[a] = count;
				prime_index++;
			}

			return primedecomp;
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
