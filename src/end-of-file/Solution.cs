using System;

class Solution {
    public static void Main(string[] args) {
        int lineno = 1;
        String line;
        while ((line = Console.ReadLine()) != null) {
            Console.WriteLine(lineno + " " + line);
            lineno++;
        }
    }
}