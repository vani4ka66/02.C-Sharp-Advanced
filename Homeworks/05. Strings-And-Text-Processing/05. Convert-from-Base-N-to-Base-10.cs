using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Numerics;


namespace August2017
{
    class Program
    {
        static void Main(string[] args)
        {
        //60% solved
        
            string[] line = Console.ReadLine().Split();

            long fromBase = long.Parse(line[0]);
            BigInteger value = BigInteger.Parse(line[1]);

            Console.WriteLine(ConvertFromBase(value, fromBase));
        }
        static int ConvertFromBase(BigInteger num, long bases)
        {
            return num.ToString().Reverse()
                .Select((c, index) => (int)Char.GetNumericValue(c) * (int)Math.Pow(bases, index)).Sum();
        }

    }
}

