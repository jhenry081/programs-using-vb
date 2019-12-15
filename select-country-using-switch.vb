Module Module1



    Sub Main()

        'Initialize the variable country to store the names of countries
        Dim country As String

        'Prompt user to enter a country
        Console.WriteLine("Enter a country( example;- Tanzania, China etc):")

        country = Console.ReadLine()

        'As per the input, act accordingly
        Select Case country

            Case "America"
                Console.WriteLine("You speak American English")
            Case "UK"
                Console.WriteLine("You speak England English")
            Case "France"
                Console.WriteLine("You speak French")
            Case "Tanzania"
                Console.WriteLine("You speak Kiswahili")
            Case "Uganda"
                Console.WriteLine("You speak English, Kiswahili and Luganda")
            Case "Kenya"
                Console.WriteLine("You speak English and Kiswahili")
            Case "China"
                Console.WriteLine("You speak Chinese")
            Case Else
                Console.WriteLine("The country you entered is not available, try another one")
        End Select

        Console.ReadLine()
    End Sub

    End Module


