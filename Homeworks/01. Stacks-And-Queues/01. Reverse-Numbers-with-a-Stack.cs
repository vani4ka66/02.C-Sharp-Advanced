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

            int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                numbers.Push(input[i]);
            }

            while (numbers.Count != 0)
            {
                if (numbers.Count != 1)
                {
                    Console.Write(numbers.Pop() + " ");
                }
                else
                {
                    Console.Write(numbers.Pop() + "\n");
                }
            }




        }
    }
}
