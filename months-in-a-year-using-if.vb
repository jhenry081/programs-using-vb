Module Module1

    Sub Main()
        'Prompt user with choices
        Console.WriteLine("Enter a value between 1 - 12: ")

        'Get a choice
        Dim month As Integer = Console.ReadLine()

        If month = 1 Then
            Console.WriteLine("The month is January")
        ElseIf month = 2 Then
            Console.WriteLine("The month is February")
        ElseIf month = 3 Then
            Console.WriteLine("The month is March")
        ElseIf month = 4 Then
            Console.WriteLine("The month is April")
        ElseIf month = 5 Then
            Console.WriteLine("The month is May")
        ElseIf month = 6 Then
            Console.WriteLine("The month is June")
        ElseIf month = 7 Then
            Console.WriteLine("The month is July")
        ElseIf month = 8 Then
            Console.WriteLine("The month is August")
        ElseIf month = 9 Then
            Console.WriteLine("The month is September")
        ElseIf month = 10 Then
            Console.WriteLine("The month is October")
        ElseIf month = 11 Then
            Console.WriteLine("The month is November")
        ElseIf month = 12 Then
            Console.WriteLine("The month is December")
        Else
            Console.WriteLine("The number entered is out of range")
        End If

        Console.ReadLine()
    End Sub

End Module
