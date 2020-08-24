# [Output Formatting][title]

[Problem statement](/../../tree/master/src/output-formatting/output-formatting/output-formatting.pdf)

## Solution

### Java

```java
import java.util.Scanner;

public class Solution {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("================================");
        for (int i = 0; i < 3; i++) {
            String s1 = sc.next();
            int x = sc.nextInt();

            System.out.printf("%-15s%03d%n", s1, x);
        }
        System.out.println("================================");

        sc.close();
    }
}
```

### C#

```c#
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
```

### Visual Basic

```vb
Imports System

Module Solution
	Public Sub Main()
		Console.WriteLine("================================")
        For i = 1 To 3
            Dim line As String = Console.ReadLine()
            Dim tokens() As String = line.Split(" "c)
            Dim s1 As String = tokens(0)
            Dim x As Integer = Integer.Parse(tokens(1))

            Console.WriteLine(String.Format("{0,-15}{1:000}", s1, x))
        Next 
        Console.WriteLine("================================")
	End Sub
End Module
```

## Test

### Java

Compile with `javac Solution.java` and run with `java Solution`.

### C#

Compile with `csc Solution.cs` and run with `./Solution.exe`.

### Visual Basic

Compile with `vbc Solution.vb` and run with `./Solution.exe`.

[title]: https://www.hackerrank.com/challenges/java-output-formatting/problem