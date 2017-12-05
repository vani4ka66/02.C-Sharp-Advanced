using System;
using System.Collections.Generic;
using System.Numerics;


namespace August2017
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger m = BigInteger.Parse(Console.ReadLine());

            BigInteger sum = n + m;
            Console.WriteLine(sum);

        }
    }
}
