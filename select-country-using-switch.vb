Module Module1
    Sub Main()

        'Initialize the variable country to store the names of countries
        Dim country As String

        'Prompt user to enter a country
        Console.WriteLine("Enter a country( example;- Tanzania, China etc):")

        country = Console.ReadLine()

        Console.WriteLine(vbCrLf)

        'As per the input, act accordingly
        Select Case country

            Case "America"
                Console.WriteLine("You speak American English")
            Case "UK"
                Console.WriteLine("You speak British English")
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
            Case "Finland"
                Console.WriteLine("You speak Finnish")
            Case "Germany"
                Console.WriteLine("You speak Dutch")
            Case "Spain"
                Console.WriteLine("You speak Spanish")
            Case "UAE"
                Console.WriteLine("You speak Arabic")
            Case "Ethiopia"
                Console.WriteLine("You speak Amharic")
            Case "Australia"
                Console.WriteLine("You speak Australian English")
            Case "Thailand"
                Console.WriteLine("You speak Chinese")
            Case "Russia"
                Console.WriteLine("You speak Russian")
            Case "Japan"
                Console.WriteLine("You speak Japanese")
            Case "Burundi"
                Console.WriteLine("You speak Kiswahili and French")
            Case "Congo"
                Console.WriteLine("You speak Kiswahili and French")
            Case "Mexico"
                Console.WriteLine("You speak Mexican")
            Case "Korea"
                Console.WriteLine("You speak Korean")
            Case Else
                Console.WriteLine("The country you entered is not available, try another one")
        End Select

        Console.ReadLine()
    End Sub

End Module