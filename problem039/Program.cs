using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem039
{
	/// <summary>
	/// If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120.
	/// {20,48,52}, {24,45,51}, {30,40,50}
	/// For which value of p ≤ 1000, is the number of solutions maximised?
	/// </summary>
	class Program
	{
		/// <summary>
		/// 直角2辺をa,b(a>b)，斜辺をhとすると3角形の成立条件＋直角三角形から
		/// p/(2+sqrt(2)) &lt; a &lt; p/2
		/// a+b &gt; p/2
		/// a>b
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			double sqrt2 = Math.Sqrt(2);

			int max_solution = 0;
			int max_p = 0;
			for (int p = 4; p <= 1000; p++)
			{
				int count = 0;
				for (int a = (int)Math.Ceiling(p / 2.0) - 1; a > p / (2.0 + sqrt2); a--)
				{
					for (int b = a - 1; b > p / 2 - a; b--)
					{
						int h = p - a - b;
						if (h * h == a * a + b * b)
						{
							count++;
						}
					}
				}
				if (count > max_solution)
				{
					max_solution = count;
					max_p = p;
				}
			}

			Console.WriteLine(max_p);
			Console.ReadLine();
		}
	}
}
