using System;

class Solution {
    public static void Main(string[] args) {
        Console.WriteLine("================================");
        for (int i = 0; i < 3; i++) {
            String line = Console.ReadLine();
            String[] tokens = line.Split(' ');
            String s1 = tokens[0];
            int x = int.Parse(tokens[1]);

            Console.WriteLine(String.Format("{0,-15}{1:000}", s1, x));
        }
        Console.WriteLine("================================");

    }
}
