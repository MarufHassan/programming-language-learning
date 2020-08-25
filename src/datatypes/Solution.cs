using System;

class Solution {
    public static void Main(string[] args) {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++) {
            String line = Console.ReadLine();
            long x;
            if (!long.TryParse(line, out x)) {
                Console.WriteLine(line + " can't be fitted anywhere.");
                break;
            }
            Console.WriteLine(line + " can be fitted in:");
            if (x >= byte.MinValue && x <= byte.MaxValue)
                Console.WriteLine("* byte");
            if (x >= short.MinValue && x <= short.MaxValue)
                Console.WriteLine("* short");
            if (x >= int.MinValue && x <= int.MaxValue)
                Console.WriteLine("* int");
            if (x >= long.MinValue && x <= long.MaxValue)
                Console.WriteLine("* long");
        }
    }
}