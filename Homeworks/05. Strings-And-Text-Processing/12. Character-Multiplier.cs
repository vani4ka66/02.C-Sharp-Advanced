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
            string[] input = Console.ReadLine().Split();

            string first = input[0];
            string second = input[1];

            int sum = 0;
            int maxLength = Math.Max(first.Length, second.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i <= first.Length - 1 && i <= second.Length - 1)
                {
                    sum += first[i] * second[i];
                }
                else
                {
                    if (i > first.Length - 1)
                    {
                        sum += second[i];
                    }
                    else
                    {
                        sum += first[i];
                    }
                }
            }
            Console.WriteLine(sum);

        }
    }
}
