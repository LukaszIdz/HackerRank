using System;
using System.Text;

class Solution
{

    static bool IsCavityField(int depth, int[] neighbors)
    {
        if (neighbors[0] < depth && neighbors[1] < depth &&
            neighbors[2] < depth && neighbors[3] < depth)
        {
            return true;
        }
        else return false;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] grid = new string[n];
        StringBuilder[] gridResult = new StringBuilder[n];

        for (int i = 0; i < n; i++)
        {
            grid[i] = Console.ReadLine();
        }

        for(int i = 0; i < n; i++)
        {
            StringBuilder iString = new StringBuilder(n);
            for(int j = 0; j < n; j++)
            {
                if (i == 0 || i == n - 1 || j == 0 || j == n - 1) iString.Append(grid[i][j]);
                else if (IsCavityField(grid[i][j],
                    new int[] {
                        grid[i][j-1],
                        grid[i-1][j],
                        grid[i][j+1],
                        grid[i+1][j]
                })) iString.Append("X");  else iString.Append(grid[i][j]);
            }
            gridResult[i] = iString;
        }

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(gridResult[i]);
        }
    }
}
