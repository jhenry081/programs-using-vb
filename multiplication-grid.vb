Module Module1

    Sub Main()
        'Prompt user to enter the first number
        Console.WriteLine("Enter the number of the table (1-12): ")

        'Initialization and storage for the first number
        Dim n1 As Integer = Console.ReadLine()

        'Prompt user to enter the second number
        Console.WriteLine("Enter the limit of multiplicands(1-12): ")

        'Initialization and storage for the second number
        Dim n2 As Integer = Console.ReadLine()

        Dim row, column, product As Integer

        Console.WriteLine("Multiplication chart to {0} x {1}", n1, n2)
        Console.WriteLine("------------------------------------")

        If n1 <= 12 And n2 <= 12 Then
            For row = 1 To n2
                For column = 1 To n2
                    product = row * column
                Next
                Console.WriteLine("{0} {1} {0}", row, product)
            Next
            Console.WriteLine("")
        Else
            Console.WriteLine("You have exceeded the limit, try again")
        End If

        Console.ReadLine()
    End Sub

End Module
