using System;

class Solution {
    public static void Main(string[] args) {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++) {
            String line = Console.ReadLine();
            String[] tokens = line.Split(' ');
            int a = int.Parse(tokens[0]);
            int b = int.Parse(tokens[1]);
            int n = int.Parse(tokens[2]);

            int sum = a, powerOfTwo = 1;
            for (int j = 0; j < n; j++) {
                sum += (powerOfTwo * b);
                Console.Write(sum + " ");
                powerOfTwo *= 2;
            }
            Console.WriteLine();
        }
    }
}