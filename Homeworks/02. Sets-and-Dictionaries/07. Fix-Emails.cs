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
            Dictionary<string, string> listEmails = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();

                if (!email.EndsWith(".us") && !email.EndsWith(".uk"))
                {
                    listEmails.Add(name, email);
                }
            }
            foreach (var pair in listEmails)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }

        }
    }
}
