using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static bool sameLand(int x1, int v1, int x2, int v2) {
        if(x1 == x2) return true;
        else if(x1 > x2 && v1 >= v2) return false;
        else if(x2 > x1 && v2 >= v1) return false;
        else return sameLand(x1 + v1, v1, x2 + v2, v2);
    }
	
    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        int x1 = Convert.ToInt32(tokens_x1[0]);
        int v1 = Convert.ToInt32(tokens_x1[1]);
        int x2 = Convert.ToInt32(tokens_x1[2]);
        int v2 = Convert.ToInt32(tokens_x1[3]);
        bool result = sameLand(x1,v1,x2,v2);
        if(result) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
}