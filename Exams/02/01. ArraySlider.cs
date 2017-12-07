using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Numerics;


namespace Text
{
    class Text
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Trim()
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .Select(BigInteger.Parse)
                .ToArray();

            string line = Console.ReadLine();
            int currentIndex = 0;

            while (line!= "stop")
            {
                var lineArg = line
                    .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int offset = int.Parse(lineArg[0]) % arr.Length;
                string operation = lineArg[1];
                int operand = int.Parse(lineArg[2]);

                if (offset < 0)
                {
                    currentIndex = (currentIndex + offset + arr.Length) % arr.Length;
                }
                else
                {
                    currentIndex = (currentIndex + offset) % arr.Length;
                }

                ProcessCommand(arr, currentIndex, operation, operand);


                line = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", arr));



        }

        private static void ProcessCommand(BigInteger[] arr, int currentIndex, string operation, int operand)
        {
            switch (operation)
            {
                case "&":
                    arr[currentIndex] &= operand;
                    break;
                case "|":
                    arr[currentIndex] |= operand;
                    break;
                case "^":
                    arr[currentIndex] ^= operand;
                    break;
                case "+":
                    arr[currentIndex] += operand;
                    break;
                case "-":
                    arr[currentIndex] -= operand;
                    if (arr[currentIndex] <0)
                    {
                        arr[currentIndex] = 0;
                    }
                    break;
                case "*":
                    arr[currentIndex] *= operand;
                    break;
                case "/":
                    arr[currentIndex] /= operand;
                    break;



            }
        }
    }
}


    





