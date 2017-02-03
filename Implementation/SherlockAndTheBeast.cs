using System;
using System.Text;

namespace SherlockAndTheBeast
{
    class Program
    {
        static void Main(string[] args)
        {
            uint testCases = Convert.ToUInt16(Console.ReadLine());

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

                Console.WriteLine(str);
            }
        }
    }
}
