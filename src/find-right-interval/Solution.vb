Imports System
Imports System.Collections.Generic
Imports System.IO

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

Public Module Driver
	Public Sub Main()
		Dim inputfile As StreamReader = new StreamReader("input.txt")
		Dim outputfile As StreamReader = new StreamReader("output.txt")

		Dim solution = new Solution()
		Dim testno = 1
		While True 
			Dim line As String = inputfile.ReadLine()
			If IsNothing(line) Then
				Exit While
			End If
			Dim arr As Integer()() = stringToInt2dArray(line)
			Dim result As Integer() = solution.FindRightInterval(arr)

			Dim output = integerArrayToString(result)
			Dim expected = outputfile.ReadLine()
			checkAnswer(expected, output, testno)
			testno += 1
		End While
	End Sub

	Public Sub checkAnswer(expected As String, output As String, testno As Integer)
		If expected.Equals(output) Then
			Console.WriteLine("TEST {0} SUCCESS EXPECTED: {1} OUTPUT: {2}", testno, expected, output)
		Else
			Console.WriteLine("TEST {0} FAILED EXPECTED: {1} OUTPUT: {2}", testno, expected, output)
		End If
	End Sub

	Public Function integerArrayToString(nums As Integer()) As String
		Dim length As Integer = nums.Length
		If length = 0 Then
			Return "[]"
		End If
		Dim result As String = ""
		For index = 0 To length - 1
			Dim number As Integer = nums(index)
			result += number.ToString() + ","
		Next
		Return "[" + result.Substring(0, result.Length() - 1) + "]"
	End Function

	Public Function stringToIntegerArray(input As String) As Integer() 
		input = input.Trim()
		input = input.Substring(1, input.Length - 2)
		If input.Length = 0 Then
			return New Integer(0) {}
		End If
		Dim parts As String() = input.split(","c)
		Dim output As Integer() = New Integer(parts.Length - 1) {}

		For index = 0 To parts.Length - 1
			Dim part As String = parts(index).Trim()
			output(index) = Integer.Parse(part)
		Next
		Return output
	End Function

	Public Function stringToInt2dArray(input As String) As Integer()()
		input = input.Trim()
		input = input.Substring(1, input.Length - 2)
		If input.Length = 0 Then
			return New Integer(0)() {}
		End If
		Dim list as List(Of Integer()) = new List(Of Integer())
		Dim startIndex As Integer = 0
		Dim endIndex As Integer = 0

		While True
			startIndex = input.IndexOf("["c, startIndex, input.Length - startIndex)

			If startIndex < 0
				Exit While
			End If

			endIndex = input.IndexOf("]"c, startIndex, input.Length - startIndex)

			Dim parts As String() = input.Substring(startIndex + 1, endIndex - startIndex - 1).Split(","c)
			Dim arr As Integer() = new Integer(parts.Length - 1) {}
			For i = 0 to arr.Length - 1
				arr(i) = Integer.Parse(parts(i).Trim())
			Next
			list.Add(arr)
			startIndex = endIndex + 1
		End While
		Return list.ToArray()
	End Function

	Public Function stringToIntegerArrayList(input As String) As List(Of Integer)
		input = input.Trim()
		input = input.Substring(1, input.Length - 2)
		Dim parts As String() = input.SPlit(","c)
		Dim output = New List(Of Integer)()
		For index = 0 To parts.Length - 1
			Dim part = parts(index).Trim()
			output.Add(Integer.Parse(part))
		Next
		Return output
	End Function

	Public Function integerArrayListToString(nums As List(Of Integer), length As Integer) As String
		If length = 0 Then
			Return "[]"
		End If
		Dim result = ""
		For index = 0 To length - 1
			Dim number = nums(index)
			result += number.ToString() + ", "
		Next
		Return "[" + result.Substring(0, result.Length - 2) + "]"
	End Function

	Public Function integerArrayListToString(nums As List(Of Integer)) As String
		Return integerArrayListToString(nums, nums.Count)
	End Function
	
End Module