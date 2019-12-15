Module Module1

    Sub Main()
        Dim x As Integer
        Console.WriteLine("Enter the first value: ")
        x = Console.ReadLine()

        Dim y As Integer
        Console.WriteLine("Enter the second value: ")
        y = Console.ReadLine()

        Console.WriteLine("" & vbCrLf)

        If (x > y) Then
            Console.WriteLine("{0} is greater than {1}", x, y)
        ElseIf (x < y) Then
            Console.WriteLine(" {0} is lesser than {1}", x, y)
        Else
            Console.WriteLine(" {0} and {1} are equal", x, y)
        End If
        Console.ReadLine()
    End Sub

End Module
