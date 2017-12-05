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
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 20; i++)
            {
                if (input.Length >= 20)
                {
                    sb.Append(input[i]);
                }
                else
                {
                    if (i > input.Length - 1)
                    {
                        sb.Append('*');
                    }
                    else
                    {
                        sb.Append(input[i]);
                    }
                }
            }
            Console.WriteLine(sb.ToString());

        }
    }
}
