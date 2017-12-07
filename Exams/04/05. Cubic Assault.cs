using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, long>> map = new SortedDictionary<string, SortedDictionary<string, long>>();

            string pattern = @"(.*?) -> (.*?) -> (\d+)";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            while (input != "Count em all")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string region = match.Groups[1].Value;
                    string color = match.Groups[2].Value;
                    int number = int.Parse(match.Groups[3].Value);

                    if (!map.ContainsKey(region))
                    {
                        map.Add(region, new SortedDictionary<string, long>());
                        map[region].Add("Red", 0);
                        map[region].Add("Green", 0);
                        map[region].Add("Black", 0);
                    }
                    map[region][color] += number;

                    if (color == "Red")
                    {
                        if (map[region][color] >= 1000000)
                        {
                            while (map[region][color] >= 1000000)
                            {
                                map[region][color] -= 1000000;
                                map[region]["Black"] += 1; ;
                            }

                        }
                    }
                    else if (color == "Green")
                    {
                        if (map[region][color] >= 1000000)
                        {
                            while (map[region][color] >= 1000000)
                            {
                                map[region][color] -= 1000000;
                                map[region]["Red"] += 1;
                            }
                        }
                    }

                    foreach (var item in map)
                    {
                        if (map[item.Key]["Green"] >= 1000000)
                        {
                            //while (map[region]["Green"] >= 1000000)
                            //{
                            map[region]["Green"] -= (map[region]["Green"] % 1000000) * 1000000;
                                map[region]["Red"] += map[region]["Green"] % 1000000; 
                           // }
                        }
                        if (map[item.Key]["Red"] >= 1000000)
                        {
                            while (map[region]["Red"] >= 1000000)
                            {
                                map[region]["Red"] -= 1000000;
                                map[region]["Black"] += 1; ;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in map.OrderByDescending(x => x.Value.First().Value))
            {
                bool isGreen = false;
                bool isRed = false;
                bool isBlack = false;

                Console.WriteLine(item.Key);

                foreach (var inner in item.Value.OrderByDescending(x=> x.Value))
                {
                    if (inner.Key == "Red")
                    {
                        if (inner.Value != 0)
                        {
                            Console.WriteLine("-> " + inner.Key + " : " + inner.Value);
                            isRed = true;
                        }
                    }
                    else if (inner.Key == "Black")
                    {
                        if (inner.Value != 0)
                        {
                            Console.WriteLine("-> " + inner.Key + " : " + inner.Value);
                            isBlack = true;
                        }
                    }
                    else if (inner.Key == "Green")
                    {
                        if (inner.Value != 0)
                        {
                            Console.WriteLine("-> " + inner.Key + " : " + inner.Value);
                            isGreen = true;
                        }
                    }
                }

                List<string> list = new List<string>();
                if (isBlack == false)
                {
                    list.Add("-> Black : 0");
                }
                if (isGreen == false)
                {
                    list.Add("-> Green : 0");
                }
                if (isRed == false)
                {
                    list.Add("-> Red : 0");
                }
                foreach (var a in list)
                {
                    Console.WriteLine(a);
                }
            }

        }
    }
}
