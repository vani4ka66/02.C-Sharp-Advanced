using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace uini09
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder list = new StringBuilder();
            List<string> resultNames = new List<string>();
            List<string> result2 = new List<string>();
            string output = "";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                list.Append(input);
            }
            string namePattern = Console.ReadLine();
            string secondPattern = Console.ReadLine();
            int[] dimentions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int lengthNamePattern = namePattern.Length;
            int lengthSecondPattern = secondPattern.Length;

            string pat1 = namePattern + @"([a-zA-Z]+)";
            string pat2 = secondPattern + @"([a-zA-Z0-9]+)";

            Regex regex = new Regex(pat1);
            Regex regex2 = new Regex(pat2);

            MatchCollection matches = regex.Matches(list.ToString());

            foreach (Match item in matches)
            {
                string current = item.Groups[1].Value;
                int l = item.Groups[1].Value.Length;
                if (item.Groups[1].Value.Length == lengthNamePattern)
                    {
                        resultNames.Add(item.Groups[1].Value);
                    }
                }

            MatchCollection match = regex2.Matches(list.ToString());

            foreach (Match item in match)
            {
                string current = item.Groups[1].Value;
                int l = item.Groups[1].Value.Length;

                if (item.Groups[1].Value.Length == lengthSecondPattern)
                {
                    output += current + " ";
                }
            }

            string[] total = output.Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < dimentions.Length; i++)
            {
                if (i <= total.Length)
                {
                    int index = dimentions[i];
                    result2.Add(total[index - 1]);
                }
            }
            for (int i = 0; i < resultNames.Count; i++)
            {
                if (i < result2.Count)
                {
                    Console.WriteLine(resultNames[i] + " - " + result2[i]);

                }
            }

        }
    }
}
