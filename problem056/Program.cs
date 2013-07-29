using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem056
{
	/// <summary>
	/// A googol (10^100) is a massive number: one followed by one-hundred zeros;
	/// 100^100 is almost unimaginably large: one followed by two-hundred zeros.
	/// Despite their size, the sum of the digits in each number is only 1.
	/// Considering natural numbers of the form, a^b, where a, b ＜ 100, what is the maximum digital sum?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			BigInteger max = new BigInteger(0);

			for (int a = 1; a < 100; a++)
			{
				for (int b = 1; b < 100; b++)
				{
					BigInteger b_power_of_a = new BigInteger(1);
					for (int i = 0; i < b; i++)
					{
						b_power_of_a *= a;
					}

					int sum = 0;
					char[] digits = b_power_of_a.ToString().ToCharArray();
					foreach (char digit in digits)
					{
						sum += int.Parse(digit.ToString());
					}

					if (sum > max)
					{
						max = sum;
					}
				}
			}

			Console.WriteLine(max);
			Console.ReadLine();
		}
	}
}
