Imports System

Module Solution
	Public Sub Main()
		Dim N As Integer = Convert.ToInt32(Console.Read())
        If N Mod 2 = 1 Then
			Console.WriteLine("Weird")
		Else
			If N < 6 Then
				Console.WriteLine("Not Weird")
			ElseIf N <= 20 Then
				Console.WriteLine("Weird")
			Else
				Console.WriteLine("Weird")
			End If
		End If
		
		
	End Sub
End Module