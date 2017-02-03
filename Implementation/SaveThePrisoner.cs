using System;
using System.Data;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < t; i++)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int n = Convert.ToInt32(arr[0]);
            int m = Convert.ToInt32(arr[1]);
            int s = Convert.ToInt32(arr[2]);         
            int res = (m + s -1)%n;
            if(res == 0) Console.WriteLine(n);
            else Console.WriteLine(res);
        }
    }
}