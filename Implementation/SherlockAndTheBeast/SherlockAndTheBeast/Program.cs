using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockAndTheBeast
{
    class Program
    {
        static void Main(string[] args)
        {
            uint testCases = Convert.ToUInt16(Console.ReadLine());
            StringBuilder[] results = new StringBuilder[testCases];

            for (int i = 0; i < testCases; ++i)
            {
                uint number = Convert.ToUInt32(Console.ReadLine());

                uint threeNumber = 5 * (2 * number % 3);
                var str = new StringBuilder();

                if (threeNumber > number) str.Append("-1");

                else
                {
                    for (int j = 0; j < number; ++j)
                    {
                        if (number - threeNumber - j > 0) str.Append("5");
                        else str.Append("3");
                    }
                }

                results[i] = str;
            }

            foreach(StringBuilder result in results)
            {
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
