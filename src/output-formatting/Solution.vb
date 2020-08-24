Imports System

Module Solution
	Public Sub Main()
		Console.WriteLine("================================")
        For i = 1 To 3
            Dim line As String = Console.ReadLine()
            Dim tokens() As String = line.Split(" "c)
            Dim s1 As String = tokens(0)
            Dim x As Integer = Integer.Parse(tokens(1))

            Console.WriteLine(String.Format("{0,-15}{1:000}", s1, x))
        Next 
        Console.WriteLine("================================")
	End Sub
End Module