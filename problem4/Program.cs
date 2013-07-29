using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem004
{
	/// <summary>
	/// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
	/// Find the largest palindrome made from the product of two 3-digit numbers.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int max = 0;
			for (int i = 100; i < 1000; i++)
			{
				for (int j = i; j < 1000; j++)
				{
					int temp = i * j;
					if (isPalindrome(temp) && (temp > max))
					{
						max = temp;
					}
				}
			}
			Console.WriteLine(max);
			Console.ReadLine();
		}

		static bool isPalindrome(int n)
		{
			char[] str = n.ToString().ToCharArray();
			int length = str.Length;
			bool ret = true;
			for (int i = 0, j = length - 1; i < j; i++, j--)
			{
				ret &= str[i] == str[j];
			}

			return ret;
		}
	}
}
