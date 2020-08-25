# [Datatypes][title]

[Problem statement](/../../tree/master/src/datatypes/datatypes/datatypes.pdf)

## Solution

### Java

```java
import java.util.Scanner;

public class Solution {
    public static void main(String[] argh) {
        Scanner sc = new Scanner(System.in);
        int t = sc.nextInt();

        for (int i = 0; i < t; i++) {
            try {
                long x = sc.nextLong();
                System.out.println(x + " can be fitted in:");
                if (x >= Byte.MIN_VALUE && x <= Byte.MAX_VALUE)
                    System.out.println("* byte");
                if (x >= Short.MIN_VALUE && x <= Short.MAX_VALUE)
                    System.out.println("* short");
                if (x >= Integer.MIN_VALUE && x <= Integer.MAX_VALUE)
                    System.out.println("* int");
                if (x >= Long.MIN_VALUE && x <= Long.MAX_VALUE)
                    System.out.println("* long");

            } catch (Exception e) {
                System.out.println(sc.next() + " can't be fitted anywhere.");
            }

        }
        sc.close();
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
```

### Visual Basic

```vb
Imports System

Module Solution
	Public Sub Main()
		Dim t As Integer = Integer.Parse(Console.ReadLine())

        For i = 1 To t
            Dim line As String = Console.ReadLine()
            Dim x As Long
            If Not Long.TryParse(line, x) Then
                Console.WriteLine(line + " can't be fitted anywhere.")
                Exit For
            End If
            If x >= Byte.MinValue AndAlso x <= Byte.MaxValue Then
                Console.WriteLine("* byte")
            End If
            If x >= Short.MinValue AndAlso x <= Short.MaxValue Then
                Console.WriteLine("* short")
            End If
            If x >= Integer.MinValue AndAlso x <= Integer.MaxValue Then
                Console.WriteLine("* int")
            End If
            If x >= Long.MinValue AndAlso x <= Long.MaxValue Then
                Console.WriteLine("* long")
            End If
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

[title]: https://www.hackerrank.com/challenges/java-datatypes/problem