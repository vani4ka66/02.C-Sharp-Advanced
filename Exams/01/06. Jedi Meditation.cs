using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace uini09
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> allItems = new List<string>();
            List<string> masters = new List<string>();
            List<string> knights = new List<string>();
            List<string> padawans = new List<string>();
            List<string> slavAndToshko = new List<string>();
            bool isYoga = false;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                foreach (var item in input)
                {
                    allItems.Add(item);
                    if (item.Contains("y"))
                    {
                        isYoga = true;
                    }
                }
            }

            //if (allItems.Contains("y"))
            //{
            //    isYoga = true;
            //}
            //else
            //{
            //    isYoga = false;
            //}

                for (int j = 0; j < allItems.Count; j++)
                {
                    if (allItems[j].Contains("t"))
                    {
                        slavAndToshko.Add(allItems[j]);
                    }
                    else if (allItems[j].Contains("s"))
                    {
                        slavAndToshko.Add(allItems[j]);
                    }
                    else if (allItems[j].Contains("m"))
                    {
                        masters.Add(allItems[j]);
                    }
                    else if (allItems[j].Contains("p"))
                    {
                        padawans.Add(allItems[j]);
                    }
                    else if (allItems[j].Contains("k"))
                    {
                        knights.Add(allItems[j]);
                    }
                }
            
            List<string> result = new List<string>();

            if (isYoga == false)
            {
                foreach (var item in slavAndToshko)
                {
                    result.Add(item);
                }
                foreach (var item in masters)
                {
                    result.Add(item);
                }
                foreach (var item in knights)
                {
                    result.Add(item);
                }
                foreach (var item in padawans)
                {
                    result.Add(item);
                }

                foreach (var item in result)
                {
                    Console.Write(item + " ");
                }
            }
            else if (isYoga == true)
            {
                 foreach (var item in masters)
                {
                    result.Add(item);
                }
                foreach (var item in knights)
                {
                    result.Add(item);
                }
                foreach (var item in slavAndToshko)
                {
                    result.Add(item);
                }
                foreach (var item in padawans)
                {
                    result.Add(item);
                }

                foreach (var item in result)
                {
                    Console.Write(item + " ");
                }
            }

        }
    }
}
