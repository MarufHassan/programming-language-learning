# [Stdin and Stdout II][title]

[Problem statement](/../../tree/master/src/stdin-and-stdout-1/stdin-and-stdout-1/stdin-and-stdout-1.pdf)

## Solution

### Java

```java
import java.util.Scanner;

public class Solution {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int i = Integer.parseInt(scan.nextLine());
        double d = Double.parseDouble(scan.nextLine());
        String s = scan.nextLine();

        System.out.println("String: " + s);
        System.out.println("Double: " + d);
        System.out.println("Int: " + i);

        scan.close();
    }
}
```

### C#

```c#
using System;

class Solution {
    public static void Main(string[] args) {
        int i = int.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        Console.WriteLine("String: {0}", s);
        Console.WriteLine("Double: {0}", d);
        Console.WriteLine("Int: {0}", i);
    }
}
```

### Visual Basic

```vb
Imports System

Module Solution
	Public Sub Main()
		Dim i As Integer = Integer.Parse(Console.ReadLine())
        Dim d As Integer = Double.Parse(Console.ReadLine())
        Dim s As String = Console.ReadLine()

        Console.WriteLine("String: {0}", s)
        Console.WriteLine("Double: {0}", d)
        Console.WriteLine("Int: {0}", i)
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

[title]: https://www.hackerrank.com/challenges/java-stdin-stdout/problem