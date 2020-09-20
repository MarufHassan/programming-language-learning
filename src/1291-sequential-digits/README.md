# [1291. Sequential Digits][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    public List<Integer> sequentialDigits(int low, int high) {
        List<Integer> ans = new ArrayList<>();
        Queue<Integer> queue = new LinkedList<>();
        
        for (int i = 1; i <= 9; i++) {
            queue.add(i);
        }
        while (!queue.isEmpty()) {
            int num = queue.poll();
            if (num >= low) {
                ans.add(num);
            }
            int lastdigit = num % 10;
            int next = num * 10 + (lastdigit + 1);
            if (lastdigit < 9 && next <= high) {
                queue.add(next);
            }
        }
        
        return ans;
    }
}
```

### C#

```c#
public class Solution {
    public IList<int> SequentialDigits(int low, int high) {
        IList<int> ans = new List<int>();
        Queue<int> queue = new Queue<int>();
        for (int i = 1; i <= 9; i++) {
            queue.Enqueue(i);
        }
        
        while (queue.Count != 0) {
            int num = queue.Dequeue();
            if (num >= low) {
                ans.Add(num);
            }
            int lastdigit = num % 10;
            int next = num * 10 + (lastdigit + 1);
            if (lastdigit < 9 && next <= high) {
                queue.Enqueue(next);
            }
        }
        return ans;
    }
}
```

### Visual Basic

```vb
Class Solution 
	Public Function SequentialDigits(low As Integer, high As Integer) As IList(Of Integer)
		Dim ans = New List(Of Integer)
		Dim queue = New Queue(Of Integer)

		For i = 1 To 9
			queue.Enqueue(i)
		Next

		While queue.Count <> 0 
			Dim num = queue.Dequeue()
			If num >= low Then
				ans.Add(num)
			End If
			Dim lastdigit = num MOD 10
			Dim nextNum = num * 10 + (lastdigit + 1)
			If lastdigit < 9 AndAlso nextNum <= high Then
				queue.Enqueue(nextNum)
			End If
		End While
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

[title]: https://leetcode.com/problems/sequential-digits/