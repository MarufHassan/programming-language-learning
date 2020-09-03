# [459. Repeated Substring Pattern][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    public boolean repeatedSubstringPattern(String s) {
        int len = s.length();
        for (int i = len / 2; i >= 1; i--) {
            if (len % i == 0) {
                String sub = s.substring(0, i);
                StringBuilder pattern = new StringBuilder(sub);
                for (int j = 1; j < len / i; j++) {
                    pattern.append(sub);
                }
                if (s.equals(pattern.toString())) {
                    return true;
                }
            }
        }
        return false;
    }
}
```

### C#

```c#
class Solution {
    public bool RepeatedSubstringPattern(string s) {
        int len = s.Length;
        for (int i = len / 2; i >= 1; i--) {
            if (len % i == 0) {
                String sub = s.Substring(0, i);
                StringBuilder pattern = new StringBuilder(sub);
                for (int j = 1; j < len / i; j++) {
                    pattern.Append(sub);
                }
                if (s.Equals(pattern.ToString())) {
                    return true;
                }
            }
        }
        return false;
    }
}
```

### Visual Basic

```vb
Class Solution 
	Public Function RepeatedSubstringPattern(s As String) As Boolean
		Dim len = s.Length
		For i = len / 2 To 1 Step -1
			If len MOD i = 0 Then
				Dim substring = s.Substring(0, i)
				Dim pattern = New StringBuilder(substring)
				For j = 1 To len / i - 1
					pattern.Append(substring)
				Next
				If s.Equals(pattern.ToString())
					Return True
				End If
			End If
		Next
		Return False
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

[title]: https://leetcode.com/problems/repeated-substring-pattern/