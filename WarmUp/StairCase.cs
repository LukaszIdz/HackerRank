using System;

namespace StairCase
{
    class Program
    {
        static void Main(string[] args)
        {
            uint height = Convert.ToUInt16(Console.ReadLine());

            for(int i = 0; i < height; ++i)
            {
                for(int j = 0; j < height; ++j)
                {
                    if (height - i - j - 1 > 0) Console.Write(" ");
                    else Console.Write("#");
                }
  
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
