using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem040
{
	/// <summary>
	/// An irrational decimal fraction is created by concatenating the positive integers:
	/// 0.123456789101112131415161718192021...
	/// It can be seen that the 12th digit of the fractional part is 1.
	/// If dn represents the nth digit of the fractional part, find the value of the following expression.
	/// d1 × d10 × d100 × d1000 × d10000 × d100000 × d1000000
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			const int N = 1000000;
			var fraction = new StringBuilder(N);
			for (int i = 1; i < 200000; i++)
			{
				fraction.Append(i.ToString());
			}
			
			int ans = 1;
			for (int i = 0; i < 7; i++)
			{
				ans *= int.Parse(fraction[(int)Math.Pow(10, i) - 1].ToString());
			}

			Console.WriteLine(ans);
			Console.ReadLine();
		}
	}
}
