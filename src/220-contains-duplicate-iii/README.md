# [220. Contains Duplicate III][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    public boolean containsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        TreeSet<Long> set = new TreeSet<>();
        for (int i = 0; i < nums.length; i++) {
            Long floor = set.floor((long) nums[i]);
            if (floor != null && nums[i] - floor <= t) {
                return true;
            }
            Long ceil = set.ceiling((long) nums[i]);
            if (ceil != null && ceil - nums[i] <= t) {
                return true;
            }
            set.add((long) nums[i]);
            if (set.size() > k) {
                set.remove((long) nums[i - k]);
            }
        }
        
        return false;
    }
}
```

### C#

```c#
class Solution {
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (t < 0) return false;
        
        SortedSet<long> set = new SortedSet<long>();
        for (int i = 0; i < nums.Length; i++) {
            var lower = (long) nums[i] - t;
            var higher = (long) nums[i] + t;
            
            var view = set.GetViewBetween(lower, higher);
            if (view.Count > 0)
            {
                return true;
            }
            set.Add((long) nums[i]);
            if (set.Count > k) {
                set.Remove((long) nums[i - k]);
            }
        }
        return false;
    }
}
```

### Visual Basic

```vb
Class Solution 
	Public Function ContainsNearbyAlmostDuplicate(nums As Integer(), k As Integer, t As Integer) As Boolean
		If t < 0 Then
			Return False
		End If
		Dim sortedset = New SortedSet(Of Long)()
		For i = 0 To nums.Length - 1
			Dim lower = CLng(nums(i)) - t
			Dim higher = CLng(nums(i)) + t

			Dim view = sortedset.GetViewBetween(lower, higher)
			If view.Count > 0 Then
				Return True
			End If
			sortedset.Add(CLng(nums(i)))
			If sortedset.Count > k Then
				sortedset.Remove(CLng(nums(i - k)))
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

[title]: https://leetcode.com/problems/contains-duplicate-iii/