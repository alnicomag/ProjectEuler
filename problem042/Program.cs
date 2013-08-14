using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace problem042
{
    /// <summary>
    /// The nth term of the sequence of triangle numbers is given by, tn = ½n(n+1); so the first ten triangle numbers are:
    /// 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
    /// By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value. For example, the word value for SKY is 19 + 11 + 25 = 55 = t10. If the word value is a triangle number then we shall call the word a triangle word.
    /// Using words.txt (right click and 'Save Link/Target As...'), a 16K text file containing nearly two-thousand common English words, how many are triangle words?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string>();
            using (StreamReader sr = new StreamReader(@"words.txt")) 
            {
                var temp_words = sr.ReadLine().Split(',');
                foreach (string i in temp_words)
                {
                    words.Add(i.Substring(1,i.Length-2));
                }
            }

            int count = 0;
            foreach (var word in words)
            {
                int word_value = 0;
                var chars = word.ToCharArray();
                foreach (var i in chars)
                {
                    word_value += (int)(AlphabeticalValue)Enum.Parse(typeof(AlphabeticalValue), i.ToString());
                }
				if (IsTriangleNumber(word_value))
				{
					count++;
				}
            }

			Console.WriteLine(count);
			Console.ReadLine();
        }

		static bool IsTriangleNumber(int n)
		{
			double sqrt = Math.Sqrt(2 * n);
			int floor = (int)Math.Floor(sqrt);
			int ceiling = (int)Math.Ceiling(sqrt);

			return (floor != ceiling) && (floor * ceiling == 2 * n);
		}
    }

    enum AlphabeticalValue : int
    {
        A = 1,
        B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z
    }
}
