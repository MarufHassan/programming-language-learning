Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text

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
			Dim arr = StringToIntegerArray(line)
            Dim k = StringToInteger(inputfile.ReadLine())
            Dim t = StringToInteger(inputfile.ReadLine())

			Dim expected = outputfile.ReadLine()
			Dim result = solution.ContainsNearbyAlmostDuplicate(arr, k, t)
			Dim output = BooleanToString(result)
			CheckAnswer(expected, output, testno)
			testno += 1
		End While
	End Sub

	Public Sub CheckAnswer(expected As String, output As String, testno As Integer)
		If expected.Equals(output) Then
			Console.WriteLine("TEST {0} SUCCESS EXPECTED: {1} OUTPUT: {2}", testno, expected, output)
		Else
			Console.WriteLine("TEST {0} FAILED EXPECTED: {1} OUTPUT: {2}", testno, expected, output)
		End If
	End Sub

	Public Function StringToInteger(input As String) As Integer
		Return Integer.Parse(input)
	End Function

	Public Function StringToBoolean(input As String) As Boolean
		Return IIf(input.Equals("true"), True, False)
	End Function

	Public Function BooleanToString(input As Boolean) As String
		Return IIf(input, "true", "false")
	End Function

	Public Function IntegerArrayToString(nums As Integer()) As String
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

	Public Function StringToIntegerArray(input As String) As Integer() 
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

	Public Function StringToInt2dArray(input As String) As Integer()()
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

	Public Function StringToIntegerArrayList(input As String) As List(Of Integer)
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

	Public Function IntegerArrayListToString(nums As List(Of Integer), length As Integer) As String
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

	Public Function IntegerArrayListToString(nums As List(Of Integer)) As String
		Return IntegerArrayListToString(nums, nums.Count)
	End Function
	
End Module