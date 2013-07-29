using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace problem022
{
	/// <summary>
	/// Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names,
	/// begin by sorting it into alphabetical order.
	/// Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
	/// For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
	/// So, COLIN would obtain a score of 938 × 53 = 49714.
	/// What is the total of all the name scores in the file?
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = new List<string>();

			using(StreamReader sr = new StreamReader(@"names.txt"))
			{
				string[] line = sr.ReadLine().Split(',');
				foreach (string i in line)
				{
					names.Add(i.Substring(1, i.Length - 2));
				}
			}
			names.Sort();

			int total_name_score = 0;
			for (int i = 0; i < names.Count; i++)
			{
				char[] alphabets = names[i].ToCharArray();
				int worth = 0;
				foreach (char alphabet in alphabets)
				{
					worth += (int)(AlphabeticalValue)Enum.Parse(typeof(AlphabeticalValue), alphabet.ToString());
				}
				total_name_score += (i + 1) * worth;
			}

			Console.WriteLine(total_name_score);
			Console.ReadLine();
		}
	}

	enum AlphabeticalValue : int
	{
		A = 1,
		B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z
	}
}
