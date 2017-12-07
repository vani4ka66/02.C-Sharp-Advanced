using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zada4a1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char[]> inputMatrix = new List<char[]>();

            string inputRow = Console.ReadLine();
            List<char[]> outputMatrix = new List<char[]>();

            while (inputRow!="END")
            {
                char[] charArray = inputRow.ToCharArray();

                outputMatrix.Add(charArray);
                char[] lowerChars = inputRow.ToLower().ToCharArray();
                inputMatrix.Add(lowerChars);

                inputRow = Console.ReadLine();
            }

            for (int row = 0; row < inputMatrix.Count - 2; row++)
            {
                int maxLength = Math.Min(inputMatrix[row].Length - 2,
                    Math.Min(inputMatrix[row + 1].Length - 1, inputMatrix[row + 2].Length - 2));

                for (int col = 0; col < maxLength; col++)
                {
                    var first = inputMatrix[row][col];
                    var second = inputMatrix[row][col + 2];
                    var third = inputMatrix[row + 1][col + 1];
                    var fourth = inputMatrix[row + 2][col];
                    var fifth = inputMatrix[row + 2][col + 2];

                    if (first==second && second==third && third==fourth && fourth==fifth)
                    {
                        outputMatrix[row][col] = '\0';
                        outputMatrix[row][col + 2] = '\0';
                        outputMatrix[row + 1][col+ 1] = '\0';
                        outputMatrix[row + 2][col] = '\0';
                        outputMatrix[row + 2][col + 2] = '\0';
                    }

                } 
            }
            
            foreach (var result in outputMatrix)
            {
                foreach (var ch in result)
                {
                    if (ch!='\0')
                    {
                        Console.Write(ch);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
