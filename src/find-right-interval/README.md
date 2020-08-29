# [436. Find Right Interval][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    public int binarySearch(List<Integer> list, int target) {
        int left = 0, right = list.size() - 1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (list.get(mid) < target) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        return list.get(left);
    }

    public int[] findRightInterval(int[][] intervals) {
        int n = intervals.length;
        int[] ans = new int[n];
        Arrays.fill(ans, -1);
        if (n <= 1) {
            return ans;
        }

        List<Integer> keys = new ArrayList<>();
        Map<Integer, Integer> map = new HashMap<>();

        for (int i = 0; i < n; i++) {
            int start = intervals[i][0];
            keys.add(start);
            map.put(start, i);
        }
        Collections.sort(keys);

        for (int i = 0; i < n; i++) {
            int end = intervals[i][1];
            int start = binarySearch(keys, end);
            if (end > start) {
                ans[i] = -1;
            } else {
                ans[i] = map.get(start);
            }
        }
        return ans;
    }
}
```

### C#

```c#
class Solution
{
    private int binarySearch(List<int> list, int target)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (list[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return list[left];
    }

    public int[] FindRightInterval(int[][] intervals)
    {
        int n = intervals.Length;
        int[] ans = new int[n];
        for (int i = 0; i < n; i++)
        {
            ans[i] = -1;
        }
        if (n <= 1)
        {
            return ans;
        }

        var keys = new List<int>();
        var map = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            int start = intervals[i][0];
            keys.Add(start);
            map[start] = i;
        }
        keys.Sort();
        for (int i = 0; i < n; i++)
        {
            int end = intervals[i][1];
            int start = binarySearch(keys, end);
            if (end > start)
            {
                ans[i] = -1;
            }
            else
            {
                ans[i] = map[start];
            }
        }

        return ans;
    }
}
```

### Visual Basic

```vb
Class Solution
	Private Function binarySearch(list As List(Of Integer), target As Integer) As Integer
		Dim left, right, mid As Integer
		left = 0
		right = list.Count - 1

		While left < right
			mid = left + (right - left) / 2
			If list(mid) < target Then
				left = mid + 1
			Else
				right = mid
			End If
		End While
		Return list(left)
	End Function

	Public Function FindRightInterval(intervals As Integer()()) As Integer()
		Dim n As Integer = intervals.Length
		Dim ans As Integer() = New Integer(n - 1){}

		Dim keys = New List(Of Integer)()
		Dim map = New Dictionary(Of Integer, Integer)
		For i = 0 To n - 1
			Dim start = intervals(i)(0)
			keys.Add(start)
			map(start) = i
		Next
		keys.Sort()
		
		For i = 0 To n - 1
			Dim endvalue = intervals(i)(1)
			Dim start = binarySearch(keys, endvalue)
			If endvalue > start Then
				ans(i) = -1
			Else
				ans(i) = map(start)
			End If
		Next

		Return ans
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

[title]: https://leetcode.com/problems/find-right-interval/