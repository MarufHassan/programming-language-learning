# [969. Pancake Sorting][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    public List<Integer> pancakeSort(int[] A) {
        List<Integer> flips = new ArrayList<>();
        
        for (int i = A.length; i >= 1; i--) {
            if (A[i - 1] == i)  continue;
            int index = indexOf(A, i);
            reverse(A, 0, index);
            reverse(A, 0, i - 1);
            flips.add(index + 1);
            flips.add(i);
        }
        return flips;
    }
    
    private int indexOf(int[] nums, int key) {
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == key)
                return i;
        }
        return -1;
    }
    
    private void reverse(int[] nums, int start, int end) {
        while (start < end) {
            int temp = nums[start];
            nums[start++] = nums[end];
            nums[end--] = temp;
        }
    }
}
```

### C#

```c#
public class Solution {
    public IList<int> PancakeSort(int[] A) {
        IList<int> flips = new List<int>();

        for (int i = A.Length; i >= 1; i--) {
            if (A[i - 1] == i) continue;
            int index = IndexOf(A, i);
            Reverse(A, 0, index);
            Reverse(A, 0, i - 1);
            flips.Add(index + 1);
            flips.Add(i);
        }
        return flips;
    }
    private int IndexOf(int[] nums, int key) {
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == key)
                return i;
        }
        return -1;
    }
    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            int temp = nums[start];
            nums[start++] = nums[end];
            nums[end--] = temp;
        }
    }
}
```

### Visual Basic

```vb
Class Solution 
	Public Function PancakeSort(A As Integer()) As IList(Of Integer)
		Dim flips As IList(Of Integer) = New List(Of Integer)()
		For i As Integer = A.Length To 1 Step -1
			If A(i - 1) = i 
				Continue For
			End If
			Dim index = IndexOf(A, i)
			Reverse(A, 0, index)
			Reverse(A, 0, i - 1)
			flips.Add(index + 1)
			flips.Add(i)
		Next
		Return flips
	End Function

	Private Function IndexOf(nums As Integer(), key As Integer) As Integer
		For i As Integer = 0 To nums.Length - 1
			If nums(i) = key Then
				Return i
			End If
		Next
		Return -1
	End Function

	Private Sub Reverse(nums As Integer(), low As Integer, high As Integer)
		While low < high
			Dim temp = nums(low)
			nums(low) = nums(high)
			nums(high) = temp
			low += 1
			high -= 1
		End While
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

[title]: https://leetcode.com/problems/pancake-sorting/