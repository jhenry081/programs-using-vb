Module Module1

    Sub Main()
        'Prompt user with choices
        Console.WriteLine("Enter a value between 1 - 7: ")

        'Get a choice
        Dim num As Integer = Console.ReadLine()

        If num = 1 Then
            Console.WriteLine("The day is Monday")
        ElseIf num = 2 Then
            Console.WriteLine("The day is Tuesday")
        ElseIf num = 3 Then
            Console.WriteLine("The day is Wednesday")
        ElseIf num = 4 Then
            Console.WriteLine("The day is Thursday")
        ElseIf num = 5 Then
            Console.WriteLine("The day is Friday")
        ElseIf num = 6 Then
            Console.WriteLine("The day is Saturday")
        ElseIf num = 7 Then
            Console.WriteLine("The day is Sunday")
        Else
            Console.WriteLine("The number entered is out of range")
        End If

        Console.ReadLine()
    End Sub

End Module
