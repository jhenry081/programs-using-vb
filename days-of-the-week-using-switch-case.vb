Module Module1

    Sub Main()
        'Prompt user to enter a value btn 1 & 7
        Console.WriteLine("Enter a value between 1 - 7: ")

        'Initialize & store value entered by the user
        Dim num As Integer = Console.ReadLine()

        'As per the input, act accordingly
        Select Case num
            Case Is = 1
                Console.WriteLine("The day is Monday")
            Case Is = 2
                Console.WriteLine("The day is Tuesday")
            Case Is = 3
                Console.WriteLine("The day is Wednesday")
            Case Is = 4
                Console.WriteLine("The day is Thursday")
            Case Is = 5
                Console.WriteLine("The day is Friday")
            Case Is = 6
                Console.WriteLine("The day is Saturday")
            Case Is = 7
                Console.WriteLine("The day is Sunday")
            Case Else
                Console.WriteLine("The number you entered is out of range")
        End Select

        'To hold the console screen
        Console.ReadLine()
    End Sub

End Module
