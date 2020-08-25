Imports System

Module Solution
	Public Sub Main()
		Dim t As Integer = Integer.Parse(Console.ReadLine())

        For i = 1 To t
            Dim line As String = Console.ReadLine()
            Dim x As Long
            If Not Long.TryParse(line, x) Then
                Console.WriteLine(line + " can't be fitted anywhere.")
                Exit For
            End If
            If x >= Byte.MinValue AndAlso x <= Byte.MaxValue Then
                Console.WriteLine("* byte")
            End If
            If x >= Short.MinValue AndAlso x <= Short.MaxValue Then
                Console.WriteLine("* short")
            End If
            If x >= Integer.MinValue AndAlso x <= Integer.MaxValue Then
                Console.WriteLine("* int")
            End If
            If x >= Long.MinValue AndAlso x <= Long.MaxValue Then
                Console.WriteLine("* long")
            End If
        Next 
	End Sub
End Module