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
            Dictionary<string, string> map = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] commandArgs = input.Split();
                string name = commandArgs[0] + " " + commandArgs[1];
                string mark = commandArgs[2] + commandArgs[3] + commandArgs[4] + commandArgs[5];

                if (!map.ContainsKey(name))
                {
                    map.Add(name, mark);
                }

                input = Console.ReadLine();
            }
            var result = map.Where(x => x.Value.Contains("6"));

            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}
