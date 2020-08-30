# [1566. Detect Pattern of Length M Repeated K or More Times][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    public boolean containsPattern(int[] arr, int m, int k) {
        int n = arr.length;
        int pattern = m * k;        
        if (pattern > n) return false;
        
        for (int i = 0; i + pattern <= n; i++) {
            boolean ans = true;
            for (int j = 1; j <= k - 1; j++) {
                int window = j * m;
                for (int a = i + window; a < i + window + m; a++) {
                    if (arr[a] != arr[a - m]) {
                        ans = false;
                    }
                }
            }
            if (ans) return true;
        }
        return false;
    }
}
```

### C#

```c#
public class Solution {
    public bool ContainsPattern(int[] arr, int m, int k) {
        int n = arr.Length;
        int pattern = m * k;        
        if (pattern > n) return false;
        
        for (int i = 0; i + pattern <= n; i++) {
            bool ans = true;
            for (int j = 1; j <= k - 1; j++) {
                int window = j * m;
                for (int a = i + window; a < i + window + m; a++) {
                    if (arr[a] != arr[a - m]) {
                        ans = false;
                    }
                }
            }
            if (ans) return true;
        }
        return false;
    }
}
```

### Visual Basic

```vb
Class Solution 
	Public Function ContainsPattern(arr As Integer(), m As Integer, k As Integer) As Boolean 
		Dim n = arr.Length
		Dim pattern = m * k
		If pattern > n Then
			Return False
		End If 
		For i = 0 To n - pattern
			Dim ans = True
			For j = 1 To k - 1
				Dim window = j * m 
				For a = i + window To i + window + m - 1
					If arr(a) <> arr(a - m) Then
						ans = False
					End If
				Next
			Next
			If ans Then
				Return true
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

[title]: https://leetcode.com/problems/detect-pattern-of-length-m-repeated-k-or-more-times/