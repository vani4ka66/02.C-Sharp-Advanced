using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace Text
{
    class Text
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\D+)(\d+)";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);
            StringBuilder list = new StringBuilder();
            foreach (Match item in matches)
            {
                string str = item.Groups[1].Value;
                int count = int.Parse(item.Groups[2].Value);

                for (int i = 0; i < count; i++)
                {
                    list.Append(str.ToUpper());
                   
                }

            }
            int distinct = list.ToString().Distinct().Count();
            Console.WriteLine("Unique symbols used: {0}", distinct);
            Console.WriteLine(list);
        }

    }
}


    





