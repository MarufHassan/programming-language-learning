# [End-of-file][title]

[Problem statement](/../../tree/master/src/end-of-file/end-of-file/end-of-file.pdf)

## Solution

### Java

```java
import java.util.Scanner;

public class Solution{
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int lineno = 1;
        while (scanner.hasNextLine()) {
            System.out.println(lineno + " " + scanner.nextLine());
            lineno++;
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
        int lineno = 1;
        String line;
        while ((line = Console.ReadLine()) != null) {
            Console.WriteLine(lineno + " " + line);
            lineno++;
        }
    }
}
```

### Visual Basic

```vb
Imports System

Module Solution
	Public Sub Main()
		Dim lineno As Integer = 1
        Dim line As String = Nothing
        While True 
            line = Console.ReadLine()
            If IsNothing(line) Then
                Exit While
            End If
            
            Console.WriteLine(String.Format("{0} {1}", lineno, line))
            lineno += 1
        End While
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

[title]: https://www.hackerrank.com/challenges/java-end-of-file/problem