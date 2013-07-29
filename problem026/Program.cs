using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem026
{
	/// <summary>
	/// A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:
	/// 1/2	= 	0.5
	/// 1/3	= 	0.(3)
	/// 1/4	= 	0.25
	/// 1/5	= 	0.2
	/// 1/6	= 	0.1(6)
	/// 1/7	= 	0.(142857)
	/// 1/8	= 	0.125
	/// 1/9	= 	0.(1)
	/// 1/10	= 	0.1
	/// Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle. It can be seen that 1/7 has a 6-digit recurring cycle.
	/// Find the value of d ＜ 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int max_length = 0;
			int max_d = 0;
			for (int d = 2; d < 1000; d++)
			{
				var remainders = new List<int>() { 1 };
				bool find = false;
				int exponent = 1;
				while (!((remainders[remainders.Count - 1] == 0) || (find)))
				{
					int remainder = (int)(Power(10, exponent) % d);
					if (find = remainders.Exists(n => n == remainder))
					{
						int recurring = remainders.Count - remainders.FindIndex(n => n == remainder);
						if (recurring > max_length)
						{
							max_length = recurring;
							max_d = d;
						}
					}
					remainders.Add(remainder);
					exponent++;
				}
			}
			Console.WriteLine(max_d);
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
	}
}
