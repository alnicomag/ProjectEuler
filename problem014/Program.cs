using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem014
{
	/// <summary>
	/// The following iterative sequence is defined for the set of positive integers:
	/// n → n/2 (n is even)
	/// n → 3n + 1 (n is odd)
	/// Using the rule above and starting with 13, we generate the following sequence:
	/// 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
	/// It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
	/// Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
	/// Which starting number, under one million, produces the longest chain?
	/// NOTE: Once the chain starts the terms are allowed to go above one million.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			const int N = 1000000;
			int[] chain_length = new int[N];
			for (int i = 0; i < N; i++)
			{
				long temp= i+1;
				int length = 1;
				while (temp != 1)
				{
					temp = Collatz(temp);
					length++;
				}
				chain_length[i] = length;
			}

			int max_value = 0;
			int max_index = 0;
			for (int i = 0; i < chain_length.Length; i++)
			{
				if (chain_length[i] > max_value)
				{
					max_value = chain_length[i];
					max_index = i;
				}
			}

			Console.WriteLine(max_index + 1);
			Console.ReadLine();
		}

		static long Collatz(long i)
		{
			try
			{
				checked
				{
					return i % 2 == 0 ? i / 2 : i * 3 + 1;
				}
			}
			catch(OverflowException)
			{
				throw;
			}
		}
	}
}
