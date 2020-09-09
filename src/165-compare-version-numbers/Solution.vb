Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Text

Class Solution 
	Public Function CompareVersion(version1 As String, version2 As String) As Integer
		Dim tokens1 = version1.Split("."c)
		Dim tokens2 = version2.Split("."c)
		Dim len = Math.Max(tokens1.Length, tokens2.Length)
		
		For i = 0 To len - 1
			Dim num1 As Integer = 0
			Dim num2 As Integer = 0
			If i < tokens1.Length Then
				num1 = tokens1(i)
			End If
			If i < tokens2.Length Then
				num2 = tokens2(i)
			End If
			
			Dim cmp = num1.CompareTo(num2)
			If cmp <> 0
				Return cmp
			End If
		Next
		Return 0
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
			Dim version1 = line
			Dim version2 = inputfile.ReadLine()

			Dim expected = outputfile.ReadLine()
			Dim output = solution.CompareVersion(version1, version2)
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