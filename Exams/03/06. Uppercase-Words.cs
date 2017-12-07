using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Methods
{
    class Methods

    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line!="END")
            {
                Regex regex = new Regex(@"(?<![a-zA-Z])[A-Z]+(?![a-zA-Z])");

                MatchCollection matches = regex.Matches(line);

                int offset = 0;
                foreach (Match match in matches)
                {
                    string word = match.Value;
                    string reversed = Reverse(word);

                    if (reversed==word)
                    {
                        reversed = DoubleEachLetter(reversed);
                    }

                    int index = match.Index;
                    line = line.Remove(index + offset, word.Length);
                    line = line.Insert(index + offset, reversed);
                    offset += reversed.Length - word.Length;
                }
                
                Console.WriteLine(SecurityElement.Escape(line));
                line = Console.ReadLine();
            }
        }

        private static string DoubleEachLetter(string reversed)
        {
            StringBuilder doubled = new StringBuilder();

            for (int i = 0; i < reversed.Length; i++)
            {
                doubled.Append(new string(reversed[i], 2));
            }

            return doubled.ToString();
        }

        static string Reverse(string value)
        {
            StringBuilder reversed = new StringBuilder();

            //var r = value.Reverse();
            //return string.Join("", r);

            for (int i = value.Length - 1; i >= 0; i--)
            {
                reversed.Append(value[i]);
            }

            return reversed.ToString();
        }
    }
}
