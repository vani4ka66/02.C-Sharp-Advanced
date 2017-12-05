using System;
using System.Numerics;

namespace August2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split();
            int toBase = int.Parse(line[0]);
            BigInteger value = BigInteger.Parse(line[1]);

            string result = "";

            do
            {
                result = (value % toBase) + result;
                value /= toBase;

            } while (value > 0);

            Console.WriteLine(result);

        }
    }
}
