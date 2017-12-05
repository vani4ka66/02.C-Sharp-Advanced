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
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(1);

            while (list.Count < n)
            {
                int l = 0;
                l = list[list.Count - 1] + list[list.Count - 2];

                list.Add(l);

            }

            Console.WriteLine(list[list.Count - 1]);

        }
    }
}
