# [949. Largest Time for Given Digits][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    private int ans;
    
    public String largestTimeFromDigits(int[] A) {
        ans = -1;
        
        permute(A, 0);
        if (ans < 0) return "";
        
        return String.format("%02d:%02d", ans / 60, ans % 60);
    }
    
    private void swap(int[] A, int i, int j) {
        int t = A[i];
        A[i] = A[j];
        A[j] = t;
    }
    
    private void permute(int[] A, int index) {
        if (index >= A.length) {
            int h = A[0] * 10 + A[1];
            int m = A[2] * 10 + A[3];
            int minutes = h * 60 + m;
            
            if (h < 24 && m < 60) {
                ans = Math.max(ans, minutes);
            }
            
            return;
        }
        for (int start = index; start < A.length; start++) {
            swap(A, start, index);
            permute(A, index + 1);
            swap(A, start, index);
        }
    }
}
```

### C#

```c#
public class Solution {
    private int ans;

    public string LargestTimeFromDigits(int[] A) {
        ans = -1;
        Permute(A, 0);
        if (ans < 0) return "";
        return String.Format("{0:00}:{1:00}", ans / 60, ans % 60);
    }

    private void Swap(int[] A, int i, int j) {
        int t = A[i];
        A[i] = A[j];
        A[j] = t;
    }

    private void Permute(int[] A, int index) {
        if (index >= A.Length) {
            int h = A[0] * 10 + A[1];
            int m = A[2] * 10 + A[3];
            int minutes = h * 60 + m;
            if (h < 24 && m < 60) {
                ans = Math.Max(ans, minutes);
            }
            return;
        }
        for (int start = index; start < A.Length; start++) {
            Swap(A, start, index);
            Permute(A, index + 1);
            Swap(A, start, index);
        }
    }
}
```

### Visual Basic

```vb
Class Solution 
	Private ans As Integer

	Public Function LargestTimeFromDigits(A As Integer()) As String
		ans = -1
		Permute(A, 0)
		If ans < 0 Then
			Return ""
		End If
		Return String.Format("{0:00}:{1:00}", ans \ 60, ans Mod 60) ' \ is integer division
	End Function

	Private Sub Swap (A As Integer(), i As Integer, j As Integer)
		Dim t = A(i)
		A(i) = A(j)
		A(j) = t
	End Sub

	Private Sub Permute(A As Integer(), index As Integer)
		If index >= A.Length
			Dim h = A(0) * 10 + A(1)
			Dim m = A(2) * 10 + A(3)
			Dim minutes = h * 60 + m

			If h < 24 AndAlso m < 60 Then
				ans = Math.Max(ans, minutes)
			End If
		End If
		For start = index To A.Length - 1
			Swap(A, start, index)
			Permute(A, index + 1)
			Swap(A, start, index)
		Next
	End Sub
End Class
```

## Test

### Java

Compile with `javac Driver.java` and run with `java Driver`.

### C#

Compile with `csc Solution.cs` and run with `Solution.exe`.

### Visual Basic

Compile with `vbc Solution.vb` and run with `Solution.exe`.

[title]: https://leetcode.com/problems/largest-time-for-given-digits/