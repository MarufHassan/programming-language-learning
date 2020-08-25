# [Java Loops I][title]

[Problem statement](/../../tree/master/src/loops-i/loops-i/loops-i.pdf)

## Solution

### Java

```java
import java.util.Scanner;

public class Solution {
    private static final Scanner scanner = new Scanner(System.in);
    public static void main(String[] args) {
        int N = scanner.nextInt();
        for (int i = 1; i <= 10; i++) {
            System.out.printf("%d x %d = %d\n", N, i, N * i);
        }

        scanner.close();
    }
}
```

### C#

```c#
using System;

class Solution {
    public static void Main(string[] args) {
        int N = Console.Read() - '0';
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine(String.Format("{0} x {1} = {2}", N, i, N * i));
        }
    }
}
```

### Visual Basic

```vb
Imports System

Module Solution
	Public Sub Main()
		Dim N As Integer = Console.Read()
        N -= 48
        For i = 1 To 10
            Console.WriteLine(String.Format("{0} x {1} = {2}", N, i, N * i))
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

[title]: https://www.hackerrank.com/challenges/java-loops-i/problem