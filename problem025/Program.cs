using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace problem025
{
	/// <summary>
	/// The Fibonacci sequence is defined by the recurrence relation:
	/// Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
	/// Hence the first 12 terms will be:
	/// F1 = 1
	/// F2 = 1
	/// F3 = 2
	/// F4 = 3
	/// F5 = 5
	/// F6 = 8
	/// F7 = 13
	/// F8 = 21
	/// F9 = 34
	/// F10 = 55
	/// F11 = 89
	/// F12 = 144
	/// The 12th term, F12, is the first term to contain three digits.
	/// What is the first term in the Fibonacci sequence to contain 1000 digits?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			BigInteger fibonacci_buffer = new BigInteger(1);
			BigInteger fibonacci = new BigInteger(1);
			int count = 2;

			while (fibonacci.ToString().Length < 1000)
			{
				BigInteger temp = fibonacci_buffer + fibonacci;
				fibonacci_buffer = fibonacci;
				fibonacci = temp;
				count++;
			}

			Console.WriteLine(count);
			Console.ReadLine();
		}
	}
}
