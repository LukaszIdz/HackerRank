using System;

namespace VeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            Console.ReadLine();
			
            foreach (string input in Console.ReadLine().Split(' '))
                sum += Convert.ToInt64(input);
			
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
