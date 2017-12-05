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
            string[] bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();

            foreach (var pair in bannedWords)
            {
                string replacement = new string('*', pair.Length);
                input = input.Replace(pair, replacement);
            }

            Console.WriteLine(input);

        }
    }
}
