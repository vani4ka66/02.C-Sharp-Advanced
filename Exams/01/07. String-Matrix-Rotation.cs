using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Text.RegularExpressions;

namespace Matrix
{
    class Matrix

    {
        static void Main(string[] args)
        {
            string[] rotate = Console.ReadLine()
                .Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
            int rotateIndex = int.Parse(rotate[1]) % 360;

            string line = Console.ReadLine();
            int max = int.MinValue;
            int count = 0;
            List<char[]> list = new List<char[]>();

            while (line != "END")
            {
                count++;
                list.Add(line.ToCharArray());
                if (max < line.Length)
                {
                    max = line.Length;
                }

                line = Console.ReadLine();
            }

            char[,] matrix = new char[count, max];

            for (int row = 0; row < count; row++)
            {
                for (int col = 0; col < max; col++)
                {
                    if (col < list[row].Length)
                    {
                        matrix[row, col] = list[row][col];

                    }
                    else
                    {
                        matrix[row, col] = ' ';

                    }
                }
            }

            if (rotateIndex == 90)
            {
                for (int i = 0; i < max; i++)
                {
                    for (int j = count-1; j >=0; j--)
                    {
                        Console.Write(matrix[j, i]);
                    }
                    Console.WriteLine();
                }
            }
            else if (rotateIndex == 180)
            {
                for (int i = count - 1; i >=0; i--)
                {
                    for (int j = max - 1; j >= 0; j--)
                    {
                        Console.Write(matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else if (rotateIndex == 270)
            {
                for (int i = max - 1; i >= 0; i--)
                {
                    for (int j = 0; j < count; j++)
                    {
                        Console.Write(matrix[j, i]);
                    }
                    Console.WriteLine();
                }
            }
            else if (rotateIndex == 0)
            {
                for (int row = 0; row < count; row++)
                {
                    for (int col = 0; col < max; col++)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }   
}
