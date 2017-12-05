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
                string email = commandArgs[2];

                if (!map.ContainsKey(name))
                {
                    map.Add(name, email);
                }

                input = Console.ReadLine();
            }
            var result = map.Where(x => x.Value.Contains("@gmail.com"));

            foreach (var item in result)
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}
