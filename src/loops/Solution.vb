Imports System

Module Solution
	Public Sub Main()
		Dim t As Integer = Integer.Parse(Console.ReadLine())

        For i = 1 To t
            Dim line As String = Console.ReadLine()
            Dim tokens As String() = line.Split(" "c)
            Dim a As Integer = Integer.Parse(tokens(0))
            Dim b As Integer = Integer.Parse(tokens(1))
            Dim n As Integer = Integer.Parse(tokens(2))

            Dim sum As Integer = a
            Dim powerOfTwo As Integer = 1
            For j = 0 To n - 1
                sum += (powerOfTwo * b)
                Console.Write(String.Format("{0} ", sum))
                powerOfTwo *= 2
            Next
            Console.WriteLine()
        Next 
	End Sub
End Module