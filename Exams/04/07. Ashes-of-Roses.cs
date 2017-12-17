using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace AshesOfRoses4
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string,long>> map = new SortedDictionary<string, SortedDictionary<string, long>>();

            string input = Console.ReadLine();
            
            while (input != "Icarus, Ignite!")
            {
                Regex regex = new Regex(@"Grow <([A-Z][a-z]+)> <([A-Za-z0-9]+)> (\d+)");

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string region = match.Groups[1].Value;
                    string color = match.Groups[2].Value;
                    int amount = int.Parse(match.Groups[3].Value);

                    if (!map.ContainsKey(region))
                    {
                        map.Add(region, new SortedDictionary<string, long>());
                    }

                    if (!map[region].ContainsKey(color))
                    {
                        map[region].Add(color, amount);
                    }
                    else
                    {
                        map[region][color] += amount;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pair in map.OrderByDescending(x=> x.Value.Sum(y=> y.Value)))
            {
                Console.WriteLine(pair.Key);
                foreach (var inner in pair.Value.OrderBy(x=> x.Value))
                {
                    Console.WriteLine("*--" + inner.Key + " | " + inner.Value);
                }
            }

        }
    }
}
