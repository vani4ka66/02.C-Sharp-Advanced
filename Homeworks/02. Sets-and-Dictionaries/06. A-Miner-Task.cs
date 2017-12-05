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
            Dictionary<string, int> map = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }

                int n = int.Parse(Console.ReadLine());


                if (!map.ContainsKey(input))
                {
                    map.Add(input, n);
                }
                else
                {
                    int count = map[input];
                    map[input] = (count + n);
                }
            }

            foreach (var pair in map)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }



    }
}

