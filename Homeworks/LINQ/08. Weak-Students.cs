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
            Dictionary<string, List<int>> map = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] commandArgs = input.Split();
                string name = commandArgs[0] + " " + commandArgs[1];
                List<int> list = new List<int>();
                list.Add(int.Parse(commandArgs[2]));
                list.Add(int.Parse(commandArgs[3]));
                list.Add(int.Parse(commandArgs[4]));
                list.Add(int.Parse(commandArgs[5]));

                if (!map.ContainsKey(name))
                {
                    map.Add(name, list);
                }

                input = Console.ReadLine();
            }

            var result = map.Where(x => x.Value.Count(y => y <= 3) >= 2);

            foreach (var pair in result)
            {
                Console.WriteLine(pair.Key);
            }

        }
    }
}
