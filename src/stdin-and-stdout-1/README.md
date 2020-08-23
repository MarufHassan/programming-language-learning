# [Stdin and Stdout I][title]

[Problem statement](/../../tree/master/src/stdin-and-stdout-1/stdin-and-stdout-1.pdf)

## Solution

### Java

```java
import java.util.*;

public class Solution {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int a = scan.nextInt();
        int b = scan.nextInt();
        int c = scan.nextInt();

        System.out.println(a);
        System.out.println(b);
        System.out.println(c);
    }
}
```

### C#

```c#
using System;

class Solution {
    public static void Main(string[] args) {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
```

### Visual Basic

```vb
Imports System

Module Solution
    Public Sub Main()
        Dim a As Integer = Convert.ToInt32(Console.ReadLine())
        Dim b As Integer = Convert.ToInt32(Console.ReadLine())
        Dim c As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine(a)
        Console.WriteLine(b)
        Console.WriteLine(c)
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

[title]: https://www.hackerrank.com/challenges/java-stdin-and-stdout-1/problem