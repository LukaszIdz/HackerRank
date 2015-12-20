using System;
using System.Collections.Generic;
using System.Text;

class Solution {
    static void Main(String[] args) {
        uint n = Convert.ToUInt32(Console.ReadLine());
        string str = Console.ReadLine();
        uint k = Convert.ToUInt32(Console.ReadLine());
        
        StringBuilder newStr = new StringBuilder();
        
        for(int i = 0; i < n; ++i) {
            if(Char.IsLower(str[i])) newStr.Append((char) ( 97  + ((str[i]-97) + k) % 26));
            else if(Char.IsUpper(str[i])) newStr.Append((char) (65 + ((str[i]-65) + k) % 26));
            else newStr.Append(str[i]);
        }
        
        Console.WriteLine(newStr);
    }
}