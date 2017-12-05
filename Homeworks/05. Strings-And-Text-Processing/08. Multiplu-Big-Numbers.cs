using System;
using System.Numerics;

namespace August2017
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger m = BigInteger.Parse(Console.ReadLine());

            BigInteger product = n * m;
            Console.WriteLine(product);

        }
    }
}
