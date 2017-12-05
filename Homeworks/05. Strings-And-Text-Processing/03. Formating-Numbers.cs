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
            
            //60% solved
            
            string[] input = Console.ReadLine().Split();

            int a = int.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);

            string hex = (a).ToString("X");
            string binary = Convert.ToString(a, 2);

            Console.WriteLine("|{0, -10}|{1}|{2, 10:f2}|{3, -10:F3}|", hex, binary.PadLeft(10, '0'), b, c);

        }
    }
}
