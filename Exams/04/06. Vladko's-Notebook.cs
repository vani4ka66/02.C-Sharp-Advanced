using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Methods
{
    class Methods

    {
        static void Main(string[] args)
        {
            string entry = Console.ReadLine();

            Dictionary<string, Player> pageByColor = new Dictionary<string, Player>();


            while (entry!="END")
            {
                string[] data = entry.Split('|');
                string color = data[0];

                if (!pageByColor.ContainsKey(color))
                {
                    pageByColor[color] = new Player();
                    pageByColor[color].Opponents = new List<string>();
                }

                Player currentPlayer = pageByColor[color];

                if (data[1]== "age")
                {
                    int age = int.Parse(data[2]);
                    currentPlayer.Age = age;
                }
                else if (data[1] == "name")
                {
                    currentPlayer.Name = data[2];
                }
                else if (data[1] == "win")
                {
                    currentPlayer.WinCount++;
                    currentPlayer.Opponents.Add(data[2]);
                }
                else if (data[1] == "loss")
                {
                    currentPlayer.LossCount++;
                    currentPlayer.Opponents.Add(data[2]);

                }

                entry = Console.ReadLine();
            }

            var validPages = pageByColor
                .Where(p => p.Value.Age != 0 && p.Value.Name != null)
                .OrderBy(p => p.Key);

            if (validPages.Count() ==0)
            {
                Console.WriteLine("No data recovered.");
            }

            StringBuilder output = new StringBuilder(); 
            foreach (var page in validPages)
            {
                output.AppendLine(string.Format("Color: {0}", page.Key));
                output.AppendLine(string.Format("-age: {0}", page.Value.Age));
                output.AppendLine(string.Format("-name: {0}", page.Value.Name));

                string opponentsOutput = "(empty)";
                if (page.Value.Opponents.Count>0)
                {
                    var sortedOpponents = page.Value.Opponents
                   .OrderBy(o => o, StringComparer.Ordinal);
                    opponentsOutput = string.Join(", ", sortedOpponents);
                }


                output.AppendLine(string.Format("-opponents: {0}", opponentsOutput));

                double rank = (page.Value.WinCount + 1) /(double)(page.Value.LossCount + 1);

                output.AppendLine(string.Format("-rank: {0:F2}", rank));


            }
            Console.WriteLine(output.ToString());

        }
    }

    class Player
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public List<string> Opponents { get; set; }

        public int WinCount { get; set; }

        public int LossCount { get; set; }

    }
}






