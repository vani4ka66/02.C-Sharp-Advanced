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
            Queue<int> numbers = new Queue<int>();

            int[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] line = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int n = input[0];
            int s = input[1];
            int x = input[2];

            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(line[i]);
            }

            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbers.ToArray().Length == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    int min = int.MaxValue;
                    for (int i = 0; i < numbers.ToArray().Length; i++)
                    {

                        if (min > numbers.ToArray()[i])
                        {
                            min = numbers.ToArray()[i];
                        }
                    }
                    Console.WriteLine(min);
                }

            }
        }
    }
}
