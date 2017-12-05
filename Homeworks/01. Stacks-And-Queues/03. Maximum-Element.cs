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
            Stack<int> maxNumbers = new Stack<int>();

            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "1")
                {
                    int numberToPush = int.Parse(command[1]);
                    numbers.Push(numberToPush);
                    if (max <= numberToPush)
                    {
                        max = numberToPush;
                        maxNumbers.Push(max);
                    }

                }
                else if (command[0].Equals("2"))
                {
                    int element = numbers.Pop();
                    int current = maxNumbers.Peek();
                    if (element == current)
                    {
                        maxNumbers.Pop();
                        if (maxNumbers.Count > 0)
                        {
                            max = maxNumbers.Peek();
                        }
                    }
                    else
                    {
                        max = int.MinValue;
                    }
                }
                else
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }

        }
    }
}
