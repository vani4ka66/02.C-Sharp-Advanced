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
            Queue<long> numbers = new Queue<long>();
            List<long> list = new List<long>();
            long n = long.Parse(Console.ReadLine());
            numbers.Enqueue(n);
            list.Add(n);
            while (list.Count <= 50)
            {
                long current = numbers.Dequeue();

                long s1 = current + 1;
                numbers.Enqueue(s1);
                list.Add(s1);

                long s2 = (2 * current) + 1;
                numbers.Enqueue(s2);
                list.Add(s2);

                long s3 = current + 2;
                numbers.Enqueue(s3);
                list.Add(s3);
            }
            for (int i = 0; i < 50; i++)
            {
                Console.Write(list[i] + " ");
            }

        }
    }
}
