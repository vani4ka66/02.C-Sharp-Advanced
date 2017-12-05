using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(numbers, Compare);
            Console.WriteLine(string.Join(" ", numbers));
        }
        public static int Compare(int x, int y)
        {
            var first = Math.Abs(x) % 2;
            var second = Math.Abs(y) % 2;

            if (first != second)
            {
                return first.CompareTo(second);
            }
            return x.CompareTo(y);
        }

    }
}

