using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem067
{
	/// <summary>
	/// By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.
	/// 3
	/// 7 4
	/// 2 4 6
	///  5 9 3
	/// That is, 3 + 7 + 4 + 9 = 23.
	/// Find the maximum total from top to bottom in triangle.txt (right click and 'Save Link/Target As...'),
	/// a 15K text file containing a triangle with one-hundred rows.
	/// 
	/// NOTE: This is a much more difficult version of Problem 18.
	/// It is not possible to try every route to solve this problem, as there are 299 altogether!
	/// If you could check one trillion (1012) routes every second it would take over twenty billion years to check them all.
	/// There is an efficient algorithm to solve it. ;o)
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			const int N = 100;
			int[][] triangle = new int[N][];
			for (int i = 0; i < triangle.GetLength(0); i++)
			{
				triangle[i] = new int[i + 1];
			}

			using (StreamReader r = new StreamReader(@"triangle.txt"))
			{
				int count = 0;
				string line;
				while ((line = r.ReadLine()) != null)
				{
					string[] temp = line.Split(' ');
					for (int i = 0; i < temp.Length; i++)
					{
						triangle[count][i] = int.Parse(temp[i]);
					}
					count++;
				}
			}

			for (int i = N - 2; i >= 0; i--)
			{
				for (int j = 0; j <= i; j++)
				{
					triangle[i][j] += Math.Max(triangle[i + 1][j], triangle[i + 1][j + 1]);
				}
			}

			Console.WriteLine(triangle[0][0]);
			Console.ReadLine();
		}
	}
}
