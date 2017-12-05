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
            HashSet<int> set = new HashSet<int>();
            HashSet<int> set1 = new HashSet<int>();

            int[] nm = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set.Add(number);
            }
            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                set1.Add(number);
            }

            Console.WriteLine(string.Join(" ", set.Intersect(set1)));

        }
    }
}
