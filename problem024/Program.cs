using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem024
{
	/// <summary>
	/// A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4.
	/// If all of the permutations are listed numerically or alphabetically, we call it lexicographic order.
	/// The lexicographic permutations of 0, 1 and 2 are:
	/// 012   021   102   120   201   210
	/// What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			int[] factorials = new int[9] { 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };

			int order = 999999;
			List<int> digits= new List<int>();
			for (int i = 8; i >= 0; i--)
			{
				digits.Add(order / factorials[i]);
				order -= factorials[i] * (order / factorials[i]);
			}

			List<int> digit_number = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			string answer = "";
			for (int i = 0; i < digits.Count; i++)
			{
				answer += digit_number[digits[i]].ToString();
				digit_number.RemoveAt(digits[i]);
			}
			answer += digit_number[0].ToString();

			Console.WriteLine(answer);
			Console.ReadLine();
		}
	}
}
