# [299. Bulls and Cows][title]

[Problem statement][title]

## Solution

### Java

```java
class Solution {
    public String getHint(String secret, String guess) {
        int bulls = 0, cows = 0;
        int[] freq = new int[10];
        
        for (int i = 0; i < secret.length(); i++) {
            if (secret.charAt(i) == guess.charAt(i)) {
                bulls++;
            } else {
                if (freq[secret.charAt(i) - '0'] < 0) cows++;
                if (freq[guess.charAt(i) - '0'] > 0) cows++;
                freq[secret.charAt(i) - '0']++;
                freq[guess.charAt(i) - '0']--;
            }
        }
        return bulls + "A" + cows + "B";
    }
}
```

### C#

```c#
public class Solution {
    public String GetHint(String secret, String guess) {
        int bulls = 0, cows = 0;
        int[] freq = new int[10];
        
        for (int i = 0; i < secret.Length; i++) {
            if (secret[i] == guess[i]) {
                bulls++;
            } else {
                if (freq[secret[i] - '0'] < 0) cows++;
                if (freq[guess[i] - '0'] > 0) cows++;
                freq[secret[i] - '0']++;
                freq[guess[i] - '0']--;
            }
        }
        return bulls + "A" + cows + "B";
    }
}
```

### Visual Basic

```vb
Class Solution 
	Public Function GetHint(secret As String, guess As String) As String
		Dim bulls = 0
		Dim cows = 0
		Dim freq = New Integer(9) {}

		For i = 0 To secret.Length - 1
			If secret(i) = guess(i) 
				bulls += 1
			Else
				If freq(Integer.Parse(secret(i))) < 0
					cows += 1
				End If
				If freq(Integer.Parse(guess(i))) > 0
					cows += 1
				End If
				freq(Integer.Parse(secret(i))) += 1
				freq(Integer.Parse(guess(i))) -= 1
			End If
		Next
		Return String.Format("{0}A{1}B", bulls, cows)
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

[title]: https://leetcode.com/problems/bulls-and-cows/