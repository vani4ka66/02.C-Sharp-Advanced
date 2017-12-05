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
            string[] names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = Print;
            print(names);

        }

        public static void Print(string[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine("Sir " + item);
            }
        }

    }
}

