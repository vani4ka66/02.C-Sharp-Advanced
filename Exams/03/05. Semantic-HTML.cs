//solved 28%

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zada4a1
{
    class Program
    {
        static void Main(string[] args)
        {
            var row = Console.ReadLine();
            var openTagPattern = @"<div(.*)(id|class)\s*=\s*""(\w+)""(.*)\s*>";
            var closeTagPattern = @"<\/div>\s*<!--\s*(\w+)\s*-->";
            while (row!="END")
            {
                if (Regex.IsMatch(row, openTagPattern))
                {
                    var matches = Regex.Match(row, openTagPattern);
                    var tagName = matches.Groups[3].Value.Trim();
                    var before = matches.Groups[1].Value.Trim();
                    var after = matches.Groups[4].Value.Trim();

                    var result = "<" + tagName + " " +  before  + " " + after;

                    result.Replace("\\s+", " ");
                    result.Trim();
                    Console.WriteLine(result + ">");
                }
                
                else if (Regex.IsMatch(row, closeTagPattern))
                {
                    var matches = Regex.Match(row, closeTagPattern);
                    var tagName = matches.Groups[1].Value;

                    var result = "</" + tagName + ">";

                    Console.WriteLine(result);

                }
                else
                {
                    Console.WriteLine(row);
                }

                row = Console.ReadLine();
            }
        }
    }
}
