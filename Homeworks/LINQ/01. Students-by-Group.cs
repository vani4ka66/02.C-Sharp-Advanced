using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace August2017
{
    public static class Predicates
    {
        public static List<Func<int, bool>> predicates = new List<Func<int, bool>>();

        public static void AddPredicate(Func<int, bool> predicate)
        {
            predicates.Add(predicate);
        }

        public static List<int> ApplyPredicates(List<int> numbers)
        {
            List<int> result = new List<int>();
            bool legal = true;

            for (int i = 0; i < numbers.Count; i++)
            {
                int curretNum = numbers[i];
                foreach (var predicate in predicates)
                {
                    if (!predicate(curretNum))
                    {
                        legal = false;
                        break;
                    }
                }
                if (legal)
                {
                    result.Add(curretNum);
                }
                legal = true;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<string>> map = new Dictionary<int, List<string>>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] arr = input.Split();
                int number = int.Parse(arr[2]);
                string name = arr[0] + " " + arr[1];

                if (!map.ContainsKey(number))
                {
                    map.Add(number, new List<string>());
                }
                map[number].Add(name);

                input = Console.ReadLine();
            }
            var sorted = map[2].OrderBy(x => x.Split()[0]).ToList();

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }

        }
    }
}
