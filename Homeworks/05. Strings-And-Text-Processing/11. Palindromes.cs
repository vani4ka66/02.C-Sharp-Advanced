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
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);

            SortedSet<string> list = new SortedSet<string>();
            foreach (var item in input)
            {
                string reverced = "";

                for (int i = item.Length - 1; i >= 0; i--)
                {
                    reverced += item[i];
                }
                if (item == reverced)
                {
                    list.Add(item);
                }
            }
            Console.Write("[");
            Console.Write(string.Join(", ", list));
            Console.WriteLine("]");

        }
    }
}
