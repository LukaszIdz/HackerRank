using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string input = Console.ReadLine();
        string[] inputTab = input.Split(' ');
        int[] tab = Array.ConvertAll(inputTab, Int32.Parse);
        int maxRep = tab.GroupBy(x => x)
                        .Max(g => g.Count());
        Console.WriteLine(tab.Count() - maxRep);
    }
}