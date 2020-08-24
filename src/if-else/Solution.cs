using System;

class Solution {
    public static void Main(string[] args) {
        int N = Convert.ToInt32(Console.Read());

        if (N % 2 == 1) {
            Console.WriteLine("Weird");
        } else {
            if (N < 6) {
                Console.WriteLine("Not Weird");
            } else if (N <= 20) {
                Console.WriteLine("Weird");
            } else {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
