using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem048
{
	/// <summary>
	/// The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317.
	/// Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			long last_digit = 0;

			for (int i = 1; i <= 1000; i++)
			{
				long temp = i;
				for (int j = 0; j < i - 1; j++)
				{
					temp *= i;
					temp %= 10000000000;
				}
				last_digit += temp;
				last_digit %= 10000000000;
			}

			Console.WriteLine(last_digit);
			Console.ReadLine();
		}
	}
}
