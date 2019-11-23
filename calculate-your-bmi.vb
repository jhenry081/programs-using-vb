Module Module1

    Sub Main()
        'Prompt user to enter weight in kg
        Console.WriteLine("Enter your weight in kg: ")

        'Get weight in kg from user
        Dim weight As Integer = Console.ReadLine()

        'Prompt user to enter height in cm
        Console.WriteLine("Enter your height in cm: ")

        'Get height in cm from user
        Dim height As Integer = Console.ReadLine()

        'Initialize variable & formula for BMI
        Dim bmi As Integer = (weight ^ 2) / height

        'As per the input(bmi), provide the results
        Select Case bmi
            Case Is <= 18.4
                Console.WriteLine("You are underweight")
            Case 18.5 To 24.9
                Console.WriteLine("You have normal weight")
            Case 25 To 29.9
                Console.WriteLine("You are overweight")
            Case Is > 30
                Console.WriteLine("You are obese, seek help immediately!")
            Case Else
                Console.WriteLine("Check the values that you entered and try again")
        End Select

        Console.ReadLine()
    End Sub

End Module