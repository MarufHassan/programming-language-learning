using System;

class Solution {
    public static void Main(string[] args) {
        int N = Console.Read() - '0';
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine(String.Format("{0} x {1} = {2}", N, i, N * i));
        }
    }
}