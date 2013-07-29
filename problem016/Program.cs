using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem016
{
	/// <summary>
	/// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
	/// What is the sum of the digits of the number 2^1000?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			const int N = 1000;
			System.Numerics.BigInteger number=1;
			for (int i = 0; i < N; i++)
			{
				number *= 2;
			}
			char[] digits = number.ToString().ToCharArray();
			int digits_sum = 0;
			foreach (char digit in digits)
			{
				digits_sum += int.Parse(digit.ToString());
			}
			Console.WriteLine(digits_sum);
			Console.ReadLine();
		}
	}
}
