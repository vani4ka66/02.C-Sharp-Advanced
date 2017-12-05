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
            string input = Console.ReadLine();
            foreach (char ch in input)
            {
                Console.Write(@"\u{0}", ((int)ch).ToString("x4"));
            }
            Console.WriteLine();

        }
    }
}
