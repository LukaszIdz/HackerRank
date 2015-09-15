using System;

namespace Find_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort T = Convert.ToUInt16(Console.ReadLine());

            for (ushort i = 0; i < T; ++i)
            {
                ulong N = Convert.ToUInt64(Console.ReadLine());
                ulong tempN = N;
                ulong counter = 0;


                while (tempN > 0)
                {
                    ulong current = Convert.ToUInt64(tempN % 10);

                    if (current != 0)
                    {
                        if (N % current == 0) ++counter;
                    }

                    tempN /= 10;
                }

                Console.WriteLine(counter);
            }
        }

    }
}
