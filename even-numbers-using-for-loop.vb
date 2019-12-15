Module Module1

    Sub Main()
        Dim n1 As Integer
        Dim n2 As Integer

        Console.WriteLine("Enter first even value")
        n1 = Console.ReadLine()

        Console.WriteLine("Enter second even value")
        n2 = Console.ReadLine()

        For i As Integer = n1 To n2 Step 5
            Console.WriteLine("Even numbers between {0} and {1} are: {2}", n1, n2, i)
        Next

        Console.ReadLine()
    End Sub

End Module
