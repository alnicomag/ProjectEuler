using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem9
{
	/// <summary>
	/// A Pythagorean triplet is a set of three natural numbers, a ＜ b ＜ c, for which,
	/// a2 + b2 = c2
	/// For example, 32 + 42 = 9 + 16 = 25 = 52.
	/// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
	/// Find the product abc.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			for (int a = 1; a <= 332; a++)
			{
				for (int b = a + 1; b <= 499; b++)
				{
					for (int c = b + 1; c <= 997; c++)
					{
						if ((a + b + c == 1000)&&(a*a+b*b==c*c))
						{
							Console.WriteLine(a*b*c);
						}
					}
				}
			}
			Console.ReadLine();
		}
	}
}
