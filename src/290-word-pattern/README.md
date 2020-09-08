# [290. Word Pattern][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    public boolean wordPattern(String pattern, String str) {
        Map<Character, String> map = new HashMap<>();
        Set<String> set = new HashSet<>();
        
        String[] tokens = str.split(" ");
        if (tokens.length != pattern.length())
            return false;
        
        for (int i = 0; i < tokens.length; i++) {
            char c = pattern.charAt(i);
            if (map.containsKey(c)) {
                if (!tokens[i].equals(map.get(c))) {
                    return false;
                }
            } else {
                if (set.contains(tokens[i])) {
                    return false;
                }
                set.add(tokens[i]);
                map.put(c, tokens[i]);
            }
        }
        
        return true;
    }
}
```

### C#

```c#
public class Solution {
    public bool WordPattern(string pattern, string str) {
        var map = new Dictionary<char, string>();
        var set = new SortedSet<string>();
        
        String[] tokens = str.Split(' ');
        if (tokens.Length != pattern.Length)
            return false;
        
        for (int i = 0; i < tokens.Length; i++) {
            char c = pattern[i];
            if (map.ContainsKey(c)) {
                if (!tokens[i].Equals(map[c])) {
                    return false;
                }
            } else {
                if (set.Contains(tokens[i])) {
                    return false;
                }
                set.Add(tokens[i]);
                map.Add(c, tokens[i]);
            }
        }
        
        return true;
    }
}
```

### Visual Basic

```vb
Class Solution 
	Public Function WordPattern(pattern As String, str As String) As Boolean
		Dim map = New Dictionary(Of Char, String)
		Dim sets = New SortedSet(Of String)

		Dim tokens = str.Split(" "c)
		If tokens.Length <> pattern.Length Then
			Return False
		End If
		For i = 0 To tokens.Length - 1
			Dim c = pattern(i)
			If map.Containskey(c) Then
				If Not tokens(i).Equals(map(c)) Then
					Return False
				End If
			Else
				If sets.Contains(tokens(i)) Then
					Return False
				End If
				sets.Add(tokens(i))
				map.Add(c, tokens(i))
			End If
		Next
		Return true
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

[title]: https://leetcode.com/problems/word-pattern/