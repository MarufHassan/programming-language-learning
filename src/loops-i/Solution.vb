Imports System

Module Solution
	Public Sub Main()
		Dim N As Integer = Console.Read()
        N -= 48
        For i = 1 To 10
            Console.WriteLine(String.Format("{0} x {1} = {2}", N, i, N * i))
        Next
	End Sub
End Module