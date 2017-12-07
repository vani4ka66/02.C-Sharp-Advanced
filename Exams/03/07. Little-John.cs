using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Text.RegularExpressions;

namespace Matrix
{
    class Matrix

    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                sb.AppendFormat(" {0}", Console.ReadLine());
            }

            string arrowPattern = @"(>>>----->>)|(>>----->)|(>----->)";

            Regex arrowMatcher = new Regex(arrowPattern);

            MatchCollection arrows = arrowMatcher.Matches(sb.ToString());

            int largeCount = 0;
            int mediumCount = 0;
            int smallCount = 0;

            foreach (Match arrow in arrows)
            {
                if (!string.IsNullOrEmpty(arrow.Groups[1].Value))
                {
                    largeCount++;
                }
                else if (!string.IsNullOrEmpty(arrow.Groups[2].Value))
                {
                    mediumCount++;
                }
                else if (!string.IsNullOrEmpty(arrow.Groups[3].Value))
                {
                    smallCount++;
                }             
            }
            
            string numberAsString = string.Format("{0}{1}{2}",
                   smallCount, mediumCount, largeCount);

            long number = long.Parse(numberAsString);

            string binaryNum = Convert.ToString(number, 2);

            string reversedNinaryNum = new string(binaryNum.Reverse().ToArray());

            string resultAsString = binaryNum + reversedNinaryNum;

            long result = Convert.ToInt64(resultAsString, 2);

            Console.WriteLine(result);

        }
    }   
}
