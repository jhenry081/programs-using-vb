Module Module1

    Sub Main()

        'Prompt user to enter the first number
        Console.WriteLine("Enter the number of the table (1-12): ")

        'Get weight in kg from user
        Dim n1 As Integer = Console.ReadLine()

        'Prompt user to enter the second number
        Console.WriteLine("Enter the limit of multiplicands(1-12): ")

        Dim n2 As Integer = Console.ReadLine()

        Dim i As Integer

        Console.WriteLine("Multiplication table for {0} by {1}", n1, n2)
        Console.WriteLine("-----------------------------------")

        If n1 <= 12 And n2 <= 12 Then
            For i = 1 To n2
                Dim a As Integer
                a = n1 * i
                Console.WriteLine("{0} * {1} = {2}", n1, i, a)
            Next

        Else
            Console.WriteLine("You have exceeded the limit, try again")
        End If
        Console.ReadLine()
    End Sub
End Module