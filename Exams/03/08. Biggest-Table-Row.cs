using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexes
{
    class regex
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = Console.ReadLine();
            var regex = new Regex(@"(-?[0-9\.]+)"); 
            double sum = double.MinValue;
            double maxSum = double.MinValue;
            var list = new List<string>();
            var maxList = new List<string>();

            while (input != "</table>")
            {
                var matches = regex.Matches(input);
                
                foreach (Match match in matches)
                {
                    sum += Convert.ToDouble(match.ToString());
                    list.Add(match.ToString());
                }
                input = Console.ReadLine();
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxList = list.ToList();
                }
                sum = 0;
                list.Clear();
            }

            if (maxList.Count == 0)
            {
                Console.WriteLine("no data");
            }
            else
            {
                Console.Write("{0} = ", maxSum);
                Console.WriteLine(string.Join(" + ", maxList));
            }
        }
    }
    
}
