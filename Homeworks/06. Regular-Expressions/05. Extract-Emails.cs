using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace August2017
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern =
     @"(?:^|\s)((?:[a-zA-Z0-9]+[.\-_])*[a-zA-Z0-9]+@(?:[a-zA-Z]+-?)+[a-zA-Z](?:\.[a-zA-Z]+)+)(?:\.\s)?";
            string input = Console.ReadLine();

            Regex matcher = new Regex(pattern);
            MatchCollection collection = matcher.Matches(input);

            foreach (Match item in collection)
            {
                Console.WriteLine(item.Groups[1].Value);
            }

        }
    }
}
