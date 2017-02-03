using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        var l = new List<int>();
        var f = new List<int>();
		
        foreach(var x in c)
        {
            if(!f.Contains(x))
            {
                 int size = 0;
                 foreach(var xi in c)
                    if(xi == x) size++; 
                 l.Add(size);
                 f.Add(x);               
            }
        }
		
        int sum = 0;
        foreach(var x in l)
            sum += x/2;
        Console.WriteLine(sum);
    }
}