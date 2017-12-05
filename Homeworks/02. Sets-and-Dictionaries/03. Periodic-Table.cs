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
            SortedSet<string> set = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();
                for (int j = 0; j < elements.Length; j++)
                {
                    set.Add(elements[j]);

                }
            }

            foreach (var item in set)
            {
                Console.Write(item + " ");
            }

        }
    }
}
