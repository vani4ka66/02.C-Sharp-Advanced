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
            Stack<char> input = new Stack<char>();
            Queue<char> line = new Queue<char>();

            string skobi = Console.ReadLine();

            if (skobi.Length < 2 && skobi.Length >= 1000)
            {
                Console.WriteLine("NO");
            }
            else if (!(skobi.Length % 2 == 0))
            {
                Console.WriteLine("NO");
            }
            else
            {
                for (int i = 0; i < skobi.Length; i++)
                {
                    input.Push(skobi[i]);
                    line.Enqueue(skobi[i]);
                }
                bool isTrue = true;
                for (int i = 0; i < skobi.Length / 2; i++)
                {
                    char currentStart = line.Dequeue();
                    char currentEnd = input.Pop();
                    if (currentStart.Equals("{"))
                    {
                        if (!currentEnd.Equals("}"))
                        {
                            isTrue = false;
                            break;
                        }
                    }
                    else if (currentStart.Equals("["))
                    {
                        if (!currentEnd.Equals("]"))
                        {
                            isTrue = false;
                            break;
                        }
                    }
                    else if (currentStart.Equals("("))
                    {
                        if (!currentEnd.Equals(")"))
                        {
                            isTrue = false;
                            break;
                        }
                    }

                }
                if (isTrue)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

        }
    }
}
