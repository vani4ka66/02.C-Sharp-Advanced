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
            string input = Console.ReadLine().ToLower();
            string keyWord = Console.ReadLine().ToLower();

            int count = 0;
            while (input.Length > 0)
            {
                if (input.IndexOf(keyWord) >= 0)
                {
                    int index = input.IndexOf(keyWord);
                    count++;
                    input = input.Substring(index + 1);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);

        }
    }
}
