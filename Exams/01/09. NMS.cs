using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nms3
{
    class Program
    {
        static void Main()
        {
            StringBuilder command = new StringBuilder();
            string sb = "";
            
            string input = Console.ReadLine();
            while (input != "---NMS SEND---")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char current = input[i];

                    if (char.IsLetterOrDigit(current))
                    {
                        sb += (current);
                        command.Append(current);
                    }
                }
                input = Console.ReadLine();
            }
            string delimeter = Console.ReadLine();

            StringBuilder result = new StringBuilder();
            result.Append(sb[0]);
            sb = sb.ToLower();

            for (int i = 0; i < sb.Length - 1; i++)
            {
                char current = sb[i];
                char currentNext = sb[i + 1];

                if (current <= currentNext)
                {
                    result.Append(command[i+1]);
                }
                else
                {
                    result.Append(delimeter);
                    result.Append(command[i+1]);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}

