using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondNature1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] flowers = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] buckets = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int result = 0;
            int n = 0;
            List<int> listBuckets = new List<int>();
            List<int> listFlowers = new List<int>();

            if (flowers.Length <= buckets.Length)
            {
                for (int i = buckets.Length - 1; i >= 0; i--)
                {
                    if (n < flowers.Length)
                    {
                        int currentFlower = flowers[n++];
                        int currentBucket = buckets[i];
                        result += currentBucket;
                        result = result - currentFlower;
                        if (result <= 0)
                        {
                            listFlowers.Add(currentFlower);
                     
                        }
                    }
                    else
                    {
                        int currentBucket = buckets[i];
                        result += currentBucket;
                        for (int j = i; j > 0; j--)
                        {
                            listBuckets.Add(buckets[i-1]);
                        }
                        break;

                    }
                }
                if (listBuckets.Count > 0)
                {
                    Console.Write(result + " ");
                    foreach (var item in listBuckets)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                    if (listFlowers.Count == 0)
                    {
                        Console.WriteLine("None");
                    }
                    else
                    {
                        foreach (var item in listFlowers)
                        {
                            Console.WriteLine(item + " ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine(result);
                    if (listFlowers.Count == 0)
                    {
                        Console.WriteLine("None");
                    }
                    else
                    {
                        foreach (var item in listFlowers)
                        {
                            Console.WriteLine(item + " ");
                        }
                    }

                }
            }
            else
            {
                for (int i = 0; i < flowers.Length; i++)
                {
                    int m = buckets.Length - 1;
                    if (m < flowers.Length)
                    {
                        int currentFlower = flowers[i];
                        int currentBucket = buckets[m--];
                        result += currentBucket;
                        result = result - currentFlower;
                        if (result <= 0)
                        {
                            listFlowers.Add(currentFlower);

                        }
                    }
                    else
                    {
                        int currentBucket = buckets[i];
                        result += currentBucket;
                        listBuckets.Add(result);
                        for (int j = i; j > 0; j--)
                        {
                            listBuckets.Add(buckets[i - 1]);
                        }
                        break;

                    }
                }

                        //new
                        foreach (var item in listFlowers)
                        {
                            Console.WriteLine(item + " ");
                        }
                        if (listBuckets.Count > 0)
                        {
                            Console.Write(result + " ");
                            foreach (var item in listBuckets)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("None");
                        }
                    }
                }
               

            }

        }
    

