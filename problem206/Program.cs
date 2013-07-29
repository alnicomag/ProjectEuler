using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem206
{
	/// <summary>
	/// Find the unique positive integer whose square has the form 1_2_3_4_5_6_7_8_9_0,
	/// where each “_” is a single digit.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			long unique = 0;
			for (long i = 1000000000; i <= 1500000000; i += 10)
			{
				long square = i * i;
				string str = square.ToString();
				if ((str[0] == '1') && (str[2] == '2') && (str[4] == '3') && (str[6] == '4') && (str[8] == '5') && (str[10] == '6') && (str[12] == '7') && (str[14] == '8') && (str[16] == '9'))
				{
					unique = i;
				}
			}

			Console.WriteLine(unique);
			Console.ReadLine();
		}
	}
}
