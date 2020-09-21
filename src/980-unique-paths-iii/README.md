# [980. Unique Paths III][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    public int uniquePathsIII(int[][] grid) {
        int empty = 0, sx = 0, sy = 0;
        
        for (int r = 0; r < grid.length; r++) {
            for (int c = 0; c < grid[0].length; c++) {
                if (grid[r][c] == 0) {
                    empty++;
                } else if (grid[r][c] == 1) {
                    sx = r;
                    sy = c;
                }
            }
        }
        return dfs(grid, sx, sy, empty);
    }
    
    private int dfs(int[][] grid, int sx, int sy, int empty) {
        if (sx < 0 || sy < 0 || sx >= grid.length || 
            sy >= grid[0].length || grid[sx][sy] == -1) {
            return 0;
        }
        
        if (grid[sx][sy] == 2) {
            return empty < 0 ? 1 : 0;
        }
        grid[sx][sy] = -1;
        empty -= 1;
        
        int paths = dfs(grid, sx + 1, sy, empty);
        paths += dfs(grid, sx, sy + 1, empty);
        paths += dfs(grid, sx - 1, sy, empty);
        paths += dfs(grid, sx, sy - 1, empty);
        
        grid[sx][sy] = 0;
        empty += 1;
        
        return paths;
    }
}
```

### C#

```c#
ppublic class Solution {
    public int UniquePathsIII(int[][] grid) {
        int empty = 0, sx = 0, sy = 0;
        
        for (int r = 0; r < grid.Length; r++) {
            for (int c = 0; c < grid[0].Length; c++) {
                if (grid[r][c] == 0) {
                    empty++;
                } else if (grid[r][c] == 1) {
                    sx = r;
                    sy = c;
                }
            }
        }
        return dfs(grid, sx, sy, empty);
    }
    
    private int dfs(int[][] grid, int sx, int sy, int empty) {
        if (sx < 0 || sy < 0 || sx >= grid.Length || 
            sy >= grid[0].Length || grid[sx][sy] == -1) {
            return 0;
        }
        
        if (grid[sx][sy] == 2) {
            return empty < 0 ? 1 : 0;
        }
        grid[sx][sy] = -1;
        empty -= 1;
        
        int paths = dfs(grid, sx + 1, sy, empty);
        paths += dfs(grid, sx, sy + 1, empty);
        paths += dfs(grid, sx - 1, sy, empty);
        paths += dfs(grid, sx, sy - 1, empty);
        
        grid[sx][sy] = 0;
        empty += 1;
        
        return paths;
    }
}
```

### Visual Basic

```vb
Class Solution 
	Public Function UniquePathsIII(grid As Integer()()) As Integer
		Dim empty = 0
		Dim sx = 0
		Dim sy = 0

		For r As Integer = 0 To grid.Length - 1
			For c As Integer = 0 To grid(0).Length - 1
				If grid(r)(c) = 0 Then
					empty += 1
				ElseIf grid(r)(c) = 1 Then
					sx = r
					sy = c
				End If
			Next
		Next
		Return Dfs(grid, sx, sy, empty)
	End Function

	Private Function Dfs(grid As Integer()(), sx As Integer, sy As Integer, empty As Integer) As Integer
		If sx < 0 OrElse sy < 0 OrElse sx >= grid.Length OrElse sy >= grid(0).Length OrElse grid(sx)(sy) = -1 Then
			Return 0
		End If
		If grid(sx)(sy) = 2 Then
			Return IIf(empty < 0, 1, 0)
		End If
		grid(sx)(sy) = -1
		empty -= 1

		Dim paths = Dfs(grid, sx + 1, sy, empty)
		paths += Dfs(grid, sx, sy + 1, empty)
		paths += Dfs(grid, sx - 1, sy, empty)
		paths += Dfs(grid, sx, sy - 1, empty)

		grid(sx)(sy) = 0
		empty += 1

		Return paths
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

[title]: https://leetcode.com/problems/unique-paths-iii/