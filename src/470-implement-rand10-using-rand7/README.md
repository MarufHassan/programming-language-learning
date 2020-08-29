# [470. Implement Rand10() Using Rand7()][title]

[Problem statement][title]

## Solution

### Java

```java
class SolBase {
    private Random random;

    public SolBase() {
        random = new Random();
    }

    public int rand7() {
        return 1 + random.nextInt(7);
    }
}

class Solution extends SolBase {
    public int rand10() {
        int val1 = rand7(), val2 = rand7();
        while (val1 > 5) val1 = rand7();
        while (val2 == 7) val2 = rand7();
        return val2 <= 3 ? val1 : val1 + 5;
    }
}
```

### C#

```c#
class SolBase {
    private Random Random;
    public SolBase() {
        Random = new Random();
    }

    public int Rand7() {
        return Random.Next(1, 8);
    }
}

class Solution : SolBase
{
    public int Rand10() 
    {
        int val1 = Rand7(), val2 = Rand7();
        while (val1 > 5) val1 = Rand7();
        while (val2 == 8) val2 = Rand7();
        return val2 <= 3 ? val1 : val1 + 5;
    }
}
```

### Visual Basic

```vb
Class SolBase
	Private Random As Random

	Public Sub New() 
		Random = new Random()
	End Sub

	Public Function Rand7()
		Return Random.Next(1, 8)
	End Function
End Class

Class Solution 
	Inherits SolBase
	Public Function Rand10() As Integer
		Dim val1, val2 As Integer
		val1 = Rand7()
		val2 = Rand7()
		While val1 > 5
			val1 = Rand7()
		End While
		While val2 = 8
			val2 = Rand7()
		End While
		Return IF(val2 <= 3, val1, val1 + 5)
	End Function
End Class
```

## Test

### Java

Compile with `javac Driver.java` and run with `java Driver`.

### C#

Compile with `csc Solution.cs` and run with `Solution.exe`.

### Visual Basic

Compile with `vbc Solution.vb` and run with `Solution.exe`.

[title]: https://leetcode.com/problems/implement-rand10-using-rand7/