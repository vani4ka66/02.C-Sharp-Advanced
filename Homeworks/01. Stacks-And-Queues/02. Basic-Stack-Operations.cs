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
            Stack<int> numbers = new Stack<int>();

            int[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            int n = command[0];
            int sToPop = command[1];
            int x = command[2];

            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            for (int i = 0; i < n; i++)
            {
                numbers.Push(input[i]);
            }

            for (int i = 0; i < sToPop; i++)
            {
                numbers.Pop();
            }

            bool contains = numbers.Contains(x);

            if (contains == true)
            {
                Console.WriteLine("true");
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
                if (numbers.ToArray().Length > 0)
                {
                    Console.WriteLine(min);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }

        }
    }
}
