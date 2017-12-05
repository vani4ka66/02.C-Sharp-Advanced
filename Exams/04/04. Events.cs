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
            SortedDictionary<string, SortedDictionary<string, List<string>>> map = new SortedDictionary<string, SortedDictionary<string, List<string>>>();

            string pattern = "^#([A-Za-z]+):\\s*@([A-Za-z]+)\\s*(([0-1]?[0-9]|[2][0-3]):([0-5][0-9]))$";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Match matches = regex.Match(input);

                string name = matches.Groups[1].Value;
                string location = matches.Groups[2].Value;
                string time = matches.Groups[3].Value;

                if (!map.ContainsKey(location))
                {
                    map.Add(location, new SortedDictionary<string, List<string>>());
                }
                if (!map[location].ContainsKey(name))
                {
                    map[location].Add(name, new List<string>());
                }
                map[location][name].Add(time);
            }

            string[] command = Console.ReadLine().Split(',');
            Array.Sort(command);

            foreach (var wantedLocation in command)
            {
                if (map.ContainsKey(wantedLocation))
                {
                    Console.WriteLine(wantedLocation + ":");
                    int counter = 1;

                    foreach (var pair in map[wantedLocation])
                    {
                        List<string> list = new List<string>();
                        Console.Write("{0}. {1} -> ", counter, pair.Key);
                        counter++;
                        foreach (var inner in pair.Value.OrderBy(x => x))
                        {
                            list.Add(inner);
                        }
                        Console.WriteLine(string.Join(", ", list));
                    }
                }

            }

        }
    }
}
