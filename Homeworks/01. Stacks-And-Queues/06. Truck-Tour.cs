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
            Queue<GasPump> pumps = new Queue<GasPump>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] pumpInfo = Console.ReadLine().Split();
                int distanceToNext = int.Parse(pumpInfo[1]);
                int amountOfGas = int.Parse(pumpInfo[0]);

                GasPump pump = new GasPump(distanceToNext, amountOfGas, i);

                pumps.Enqueue(pump);
            }

            GasPump starterPump = null;
            bool completeJourney = false;
            while (true)
            {
                GasPump current = pumps.Dequeue();
                pumps.Enqueue(current);
                starterPump = current;
                int gasInTank = current.amountOfGas;

                while (gasInTank >= current.distanceToNext)
                {
                    gasInTank -= current.distanceToNext;
                    current = pumps.Dequeue();
                    pumps.Enqueue(current);
                    if (current == starterPump)
                    {
                        completeJourney = true;
                        break;
                    }
                    gasInTank += current.amountOfGas;
                }
                if (completeJourney)
                {
                    Console.WriteLine(starterPump.index);
                    break;
                }
            }
        }

        public class GasPump
        {
            public int distanceToNext;
            public int amountOfGas;
            public int index;

            public GasPump(int distanceToNext, int amountOfGas, int index)
            {
                this.distanceToNext = distanceToNext;
                this.amountOfGas = amountOfGas;
                this.index = index;
            }

        }
    }
}
