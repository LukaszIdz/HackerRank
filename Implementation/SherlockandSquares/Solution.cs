using System;


namespace SherlockandSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            uint T = Convert.ToUInt16(Console.ReadLine());
            for (int i = 0 ; i < T; ++i)
            {
                string[] input = Console.ReadLine().Split(' ');
                ulong leftRange = Convert.ToUInt64(Math.Ceiling(Math.Sqrt(Convert.ToUInt64(input[0]))));
                ulong rightRange = Convert.ToUInt64(Math.Floor(Math.Sqrt(Convert.ToUInt64(input[1]))));

                ulong counter = rightRange - leftRange + 1;

                Console.WriteLine(counter);
            }
        }
    }
}
