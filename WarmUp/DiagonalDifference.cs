using System;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = Convert.ToInt16(Console.ReadLine());
            int[,] array = new int[L, L];

            for(int i = 0; i < L; ++i)
            {
                string[] input = Console.ReadLine().Split(' ');
                for(int j = 0 ; j < L; ++j)
                {
                    array[i, j] = Convert.ToInt16(input[j]);
                }
            }

            int left = 0, right = L - 1, leftSum = 0, rightSum = 0;
            while(L-- > 0)
            {
                leftSum += array[left, left];
                rightSum += array[left++, right--];
            }
            Console.WriteLine(Math.Abs(leftSum - rightSum));
        }
    }
}
