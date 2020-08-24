# [If-Else][title]

[Problem statement](/../../tree/master/src/if-else/if-else/if-else.pdf)

## Solution

### Java

```java
import java.util.*;

public class Solution {
    private static final Scanner scanner = new Scanner(System.in);
    public static void main(String[] args) {
        int N = scanner.nextInt();
        if (N % 2 == 1) {
            System.out.println("Weird");
        } else {
            if (N < 6) {
                System.out.println("Not Weird");
            } else if (N <= 20) {
                System.out.println("Weird");
            } else {
                System.out.println("Not Weird");
            }
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
```

### Visual Basic

```vb
Imports System

Module Solution
	Public Sub Main()
		Dim N As Integer = Convert.ToInt32(Console.Read())
        If N Mod 2 = 1 Then
			Console.WriteLine("Weird")
		Else
			If N < 6 Then
				Console.WriteLine("Not Weird")
			ElseIf N <= 20 Then
				Console.WriteLine("Weird")
			Else
				Console.WriteLine("Weird")
			End If
		End If
		
		
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

[title]: https://www.hackerrank.com/challenges/java-if-else/problem