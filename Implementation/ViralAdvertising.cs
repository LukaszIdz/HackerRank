using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static private int GetViral(int days, int last) {
        if(days == 1) return last;
        else{
            int newLast = 3 * last/2;
            return last + GetViral(days - 1, newLast);
        } 
    }
	
    static public int GetViral(int days) {
        return GetViral(days,2);
    }
	
    static void Main(String[] args) {
       int days = Convert.ToInt32(Console.ReadLine());
       int result = GetViral(days);
       Console.WriteLine(result);
    }
}