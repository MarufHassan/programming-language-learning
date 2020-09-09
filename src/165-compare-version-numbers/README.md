# [165. Compare Version Numbers][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    public int compareVersion(String version1, String version2) {
        String[] tokens1 = version1.split("\\.");
        String[] tokens2 = version2.split("\\.");
        
        int num1, num2;
        for (int i = 0; i < Math.max(tokens1.length, tokens2.length); i++) {
            num1 = 0; num2 = 0;
            if (i < tokens1.length) {
                num1 = Integer.valueOf(tokens1[i]);
            }
            if (i < tokens2.length) {
                num2 = Integer.valueOf(tokens2[i]);
            }
            if (num1 < num2) {
                return -1;
            } else if (num1 > num2) {
                return 1;
            }
        }
        return 0;
    }
}
```

### C#

```c#
public class Solution {
    public int CompareVersion(String version1, String version2) {
        String[] tokens1 = version1.Split('.');
        String[] tokens2 = version2.Split('.');
        
        int num1, num2;
        int len = Math.Max(tokens1.Length, tokens2.Length);
        for (int i = 0; i < len; i++) {
            num1 = (i < tokens1.Length) ? int.Parse(tokens1[i]) : 0;
            num2 = (i < tokens2.Length) ? int.Parse(tokens2[i]) : 0;
            int cmp = num1.CompareTo(num2);
            if (cmp != 0) {
                return cmp;
            }
        }
        return 0;
    }
}
```

### Visual Basic

```vb
Class Solution 
	Public Function CompareVersion(version1 As String, version2 As String) As Integer
		Dim tokens1 = version1.Split("."c)
		Dim tokens2 = version2.Split("."c)
		Dim len = Math.Max(tokens1.Length, tokens2.Length)
		
		For i = 0 To len - 1
			Dim num1 As Integer = 0
			Dim num2 As Integer = 0
			If i < tokens1.Length Then
				num1 = tokens1(i)
			End If
			If i < tokens2.Length Then
				num2 = tokens2(i)
			End If
			
			Dim cmp = num1.CompareTo(num2)
			If cmp <> 0
				Return cmp
			End If
		Next
		Return 0
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

[title]: https://leetcode.com/problems/compare-version-numbers/