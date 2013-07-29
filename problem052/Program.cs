using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem052
{
	/// <summary>
	/// It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.
	/// Find the smallest positive integer, x, such that 2x, 3x, 4x, 5x, and 6x, contain the same digits.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			long x = 1;
			while (!HaveSameDigits(2 * x, 3 * x) || !HaveSameDigits(2 * x, 4 * x) || !HaveSameDigits(2 * x, 5 * x) || !HaveSameDigits(2 * x, 6 * x))
			{
				x++;
			}
			Console.WriteLine(x);
			Console.ReadLine();
		}

		static bool HaveSameDigits(long n1,long n2)
		{
			string str_n1 = n1.ToString();
			string str_n2 = n2.ToString();
			if (str_n1.Length != str_n2.Length)
			{
				return false;
			}

			List<string> digits_n1 = new List<string>();
			List<string> digits_n2 = new List<string>();

			for (int i = 0; i < str_n1.Length; i++)
			{
				digits_n1.Add(str_n1.Substring(i, 1));
				digits_n2.Add(str_n2.Substring(i, 1));
			}
			digits_n1.Sort();
			digits_n2.Sort();
			
			for (int i = 0; i < digits_n1.Count; i++)
			{
				if (digits_n1[i] != digits_n2[i])
				{
					return false;
				}
			}
			return true;
		}
	}
}
