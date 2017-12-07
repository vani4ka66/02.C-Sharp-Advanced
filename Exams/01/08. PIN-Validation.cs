//solved 30%

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexes
{
    class regex
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string gender = Console.ReadLine();
            string number = (Console.ReadLine());
            int num = 0;
            int sum = 0;


            for (int i = 0; i < 1; i++)
            {
               // num = int.Parse(number[i].ToString());

                sum = ((number[0]-'0') * 2) + ((number[1] - '0')* 4) + ((number[2] - '0') * 8) + ((number[3] - '0') * 5) + ((number[4] - '0' )* 10) +
                ((number[5] -'0')* 9) + ((number[6] - '0') * 7) + ((number[7] - '0') * 3) + ((number[8] - '0') * 6);

                int remainder = sum % 11;

                if (gender== "female")
                {
                    if (number[i]%2 !=0 && remainder == (number[9] - '0'))
                    {
                        Console.WriteLine(@"{""name"":""{0}""gender"":""{1}"",""pin"":""{2}""}", name, gender, number);
                    }
                    else
                    {
                        Console.WriteLine("<h2>Incorrect data</h2>");
                        break;
                    }
                }
                else if (gender == "male")
                {
                    if (number[i] %2 ==0 && remainder == (number[9] - '0'))
                    {
                        Console.WriteLine(@"{""name"":""{0}""gender"":""{1}"",""pin"":""{2}""}", name, gender, number);
                        break;

                    }
                    else
                    {
                        Console.WriteLine("<h2>Incorrect data</h2>");
                        break;
                    }
                }

            }

            //Console.WriteLine(sum);
        }
    }
    
}
