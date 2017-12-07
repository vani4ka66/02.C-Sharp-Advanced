using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NatureProphet2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            BigInteger[,] matrix = new BigInteger[rows, cols];

            //create matrix 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 0;
                }
            }

            string plantArgs = Console.ReadLine();
            while (plantArgs != "Bloom Bloom Plow")
            {
                string[] plant = plantArgs.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int plantRow = int.Parse(plant[0]);
                int plantCol = int.Parse(plant[1]);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (i == plantRow)
                        {
                            matrix[i, j] += 1;
                        }
                        else if (j == plantCol)
                        {
                            matrix[i, j] += 1;
                        }
                    }
                }

                plantArgs = Console.ReadLine();
            }

            //print matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

