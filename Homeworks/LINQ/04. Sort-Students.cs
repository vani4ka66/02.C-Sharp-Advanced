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

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] commandArgs = input.Split();
                string name = commandArgs[0] + " " + commandArgs[1];

                if (!map.ContainsKey(name))
                {
                    map.Add(name, 0);
                }

                input = Console.ReadLine();
            }
            var result = map.OrderBy(x => x.Key.Split()[1]).ThenByDescending(y => y.Key.Split()[0]);

            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}
