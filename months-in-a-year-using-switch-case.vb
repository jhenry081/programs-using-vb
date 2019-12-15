Module Module1

    Sub Main()
        'Prompt user with choices
        Console.WriteLine("Enter a value between 1 - 12: ")

        'Get a choice
        Dim month As Integer = Console.ReadLine()

        'As per the input, act accordingly
        Select Case month
            Case Is = 1
                Console.WriteLine("The month is January")
            Case Is = 2
                Console.WriteLine("The month is February")
            Case Is = 3
                Console.WriteLine("The month is March")
            Case Is = 4
                Console.WriteLine("The month is April")
            Case Is = 5
                Console.WriteLine("The month is May")
            Case Is = 6
                Console.WriteLine("The month is June")
            Case Is = 7
                Console.WriteLine("The month is July")
            Case Is = 8
                Console.WriteLine("The month is August")
            Case Is = 9
                Console.WriteLine("The month is September")
            Case Is = 10
                Console.WriteLine("The month is October")
            Case Is = 11
                Console.WriteLine("The month is November")
            Case Is = 12
                Console.WriteLine("The month is December")
            Case Else
                Console.WriteLine("The number you entered is out of range")
        End Select

        Console.ReadLine()
    End Sub

End Module
