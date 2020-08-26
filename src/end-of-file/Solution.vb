Imports System

Module Solution
	Public Sub Main()
		Dim lineno As Integer = 1
        Dim line As String = Nothing
        While True 
            line = Console.ReadLine()
            If IsNothing(line) Then
                Exit While
            End If
            
            Console.WriteLine(String.Format("{0} {1}", lineno, line))
            lineno += 1
        End While
	End Sub
End Module