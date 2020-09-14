# [57. Insert Interval][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    public int[][] insert(int[][] intervals, int[] newInterval) {
        List<int[]> result = new ArrayList<>();
        int i = 0, n = intervals.length;
        
        while (i < n && intervals[i][1] < newInterval[0]) {
            result.add(intervals[i++]);
        }
        
        int[] tmpInterval = newInterval;
        while (i < n && intervals[i][0] <= newInterval[1]) {
            tmpInterval[0] = Math.min(intervals[i][0], newInterval[0]);
            tmpInterval[1] = Math.max(intervals[i][1], newInterval[1]);
            i++;
        }
        result.add(tmpInterval);
        
        while (i < n) {
            result.add(intervals[i++]);
        }
        
        return result.toArray(new int[result.size()][2]);
    }
}
```

### C#

```c#
public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        List<int[]> result = new List<int[]>();
        int i = 0, n = intervals.Length;
        
        while (i < n && intervals[i][1] < newInterval[0]) {
            result.Add(intervals[i++]);
        }
        
        int[] tmpInterval = newInterval;
        while (i < n && intervals[i][0] <= newInterval[1]) {
            tmpInterval[0] = Math.Min(intervals[i][0], newInterval[0]);
            tmpInterval[1] = Math.Max(intervals[i][1], newInterval[1]);
            i++;
        }
        result.Add(tmpInterval);
        
        while (i < n) {
            result.Add(intervals[i++]);
        }
        return result.ToArray();
    }
}
```

### Visual Basic

```vb
Class Solution 
	Public Function Insert(intervals As Integer()(), newInterval As Integer()) As Integer()()
		Dim result = New List(Of Integer())()
		Dim i = 0
		Dim n = intervals.Length

		While i < n AndAlso intervals(i)(1) < newInterval(0)
			result.Add(intervals(i))
			i += 1
		End While

		Dim tmpInterval = newInterval
		While i < n AndAlso intervals(i)(0) <= newInterval(1)
			tmpInterval(0) = Math.Min(intervals(i)(0), newInterval(0))
			tmpInterval(1) = Math.Max(intervals(i)(1), newInterval(1))
			i += 1
		End While
		result.Add(tmpInterval)
		While i < n
			result.Add(intervals(i))
			i += 1
		End While
		return result.ToArray()
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

[title]: https://leetcode.com/problems/insert-interval/