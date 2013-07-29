using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem092
{
	/// <summary>
	/// A number chain is created by continuously adding the square of the digits in a number to form a new number until it has been seen before.
	/// For example,
	/// 44 → 32 → 13 → 10 → 1 → 1
	/// 85 → 89 → 145 → 42 → 20 → 4 → 16 → 37 → 58 → 89
	/// Therefore any chain that arrives at 1 or 89 will become stuck in an endless loop.
	/// What is most amazing is that EVERY starting number will eventually arrive at 1 or 89.
	/// How many starting numbers below ten million will arrive at 89?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int count = 0;
			for (int i = 1; i < 10000000; i++)
			{
				var chain = SquareDigitNumberChain(i).ToList();
				if (chain[chain.Count - 1] == 89)
				{
					count++;
				}
			}
			Console.WriteLine(count);
			Console.ReadLine();
		}

		static IEnumerable<int> SquareDigitNumberChain(int n)
		{
			int next = n;
			while ((next != 89) && (next != 1))
			{
				yield return next;
				next = next.ToString().ToCharArray().Sum(ln => int.Parse(ln.ToString()) * int.Parse(ln.ToString()));
			}
			yield return next;
		}
	}
}
