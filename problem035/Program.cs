using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem035
{
    /// <summary>
    /// The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
    /// There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
    /// How many circular primes are there below one million?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var prime = Eratosthenes(1000000-1);
            var circular_prime = new List<int>();

            foreach(int i in prime)
            {
                bool areAllPrime = true;
                int[] circular = GenerateCircularNumber(i);
                foreach(int j in circular)
                {
                    areAllPrime &= IsExist(prime,j);
                }
                if(areAllPrime)
                {
                    circular_prime.Add(i);
                }
            }

            Console.WriteLine(circular_prime.Count);
            Console.ReadLine();
        }

        static bool IsExist(int[] list, int a)
        {
            for (int i=0; i<list.Length; i++)
            {
                if (list[i] == a)
                {
                    return true;
                }
            }
            return false;
        }

        static int[] GenerateCircularNumber(int n)
        {
            char[] chars = n.ToString().ToCharArray();
            int length = chars.Length;

            var ret = new int[length];
            for (int i=0; i<length; i++)
            {
                string number = "";
                for(int j=0;j<length;j++)
                {
                    number += chars[(i + j) % length];
                }
                ret[i] = int.Parse(number);
            }
            return ret;
        }

        static int[] Eratosthenes(int n)
        {
            var list = new List<int>();
            for (int i = 2; i <= n; ++i)
            {
                list.Add(i);
            }
            var prime = new List<int>();

            do
            {
                int new_prime = list[0];
                list.RemoveAll(ln => ln % new_prime == 0);
                prime.Add(new_prime);
            }
            while (prime[prime.Count - 1] * prime[prime.Count - 1] < list[list.Count - 1]);
            prime.AddRange(list);

            var ret = new int[prime.Count];
            for (int i=0; i<ret.Length; i++)
            {
                ret[i] = prime[i];
            }
            return ret;
        }
    }
}