using System;

namespace problem036
{
	/// <summary>
	/// The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
	/// Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
	/// (Please note that the palindromic number, in either base, may not include leading zeros.)
	/// </summary>
	class MainClass
	{
		public static void Main (string[] args)
		{
            int sum = 0;
            for(int i=1;i<=1000000;i++){
                if (IsPalindromic(i.ToString()) && IsPalindromic(Convert.ToString(i, 2)))
                {
                    sum += i;
                }
            }

			Console.WriteLine (sum);
			Console.ReadLine();
		}
		
		static bool IsPalindromic(string str)
        {
			for (int i=0,j=str.Length-1; i<j; i++,j--)
			{
                if (str[i] != str[j])
                {
                    return false;
                }
			}
            return true;
		}
	}
}
