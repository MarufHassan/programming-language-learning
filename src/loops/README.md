# [Loops II][title]

[Problem statement](/../../tree/master/src/loops/loops/loops.pdf)

## Solution

### Java

```java
import java.util.Scanner;

public class Solution{
    public static void main(String []argh){
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();

        for(int i = 0; i < t; i++){
            int a = in.nextInt();
            int b = in.nextInt();
            int n = in.nextInt();

            int sum = a, powerOfTwo = 1;
            for (int j = 0; j < n; j++) {
                sum += (powerOfTwo * b);
                System.out.printf("%d ", sum);
                powerOfTwo *= 2;
            }
            System.out.println();
        }
        in.close();
    }
}
```

### C#

```c#
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
```

### Visual Basic

```vb
Imports System

Module Solution
	Public Sub Main()
		Dim t As Integer = Integer.Parse(Console.ReadLine())

        For i = 1 To t
            Dim line As String = Console.ReadLine()
            Dim tokens As String() = line.Split(" "c)
            Dim a As Integer = Integer.Parse(tokens(0))
            Dim b As Integer = Integer.Parse(tokens(1))
            Dim n As Integer = Integer.Parse(tokens(2))

            Dim sum As Integer = a
            Dim powerOfTwo As Integer = 1
            For j = 0 To n - 1
                sum += (powerOfTwo * b)
                Console.Write(String.Format("{0} ", sum))
                powerOfTwo *= 2
            Next
            Console.WriteLine()
        Next 
	End Sub
End Module
```

## Test

### Java

Compile with `javac Solution.java` and run with `java Solution`.

### C#

Compile with `csc Solution.cs` and run with `Solution.exe`.

### Visual Basic

Compile with `vbc Solution.vb` and run with `Solution.exe`.

[title]: https://www.hackerrank.com/challenges/java-loops/problem