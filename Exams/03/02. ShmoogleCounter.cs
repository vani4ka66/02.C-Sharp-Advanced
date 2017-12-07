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
            var sb = new List<string>();
            var copy = new List<string>();

            while (input!= "//END_OF_CODE")
            {
                string pattern = @"double\s+([a-z][a-zA-z]*)";
                string pattern2 = @"int\s+([a-z][a-zA-Z]*)";
                Regex regex = new Regex(pattern);
                Regex rgx = new Regex(pattern2);

                MatchCollection matches = regex.Matches(input);
                MatchCollection matcheses = rgx.Matches(input);



                foreach (Match item in matches)
                {
                    string extracted = item.Groups[1].Value;
                    sb.Add(extracted);

                }
                sb.Sort();

                foreach (Match items in matcheses)
                {
                    string extracted = items.Groups[1].Value;
                    copy.Add(extracted);
                }
                copy.Sort();
                input = Console.ReadLine();
               
            }
            if (sb.Count == 0)
            {
                Console.WriteLine("Doubles: None");
            }
            else
            {
                Console.WriteLine("Doubles: {0}", string.Join(", ", sb));

            }
            if (copy.Count == 0)
            {
                Console.WriteLine("Ints: None");
            }
            else
            {
                Console.WriteLine("Ints: {0}", string.Join(", ", copy));

            }

        }
          

        }

    }


    





