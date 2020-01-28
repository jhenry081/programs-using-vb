Module Module1
    Private Function GCD(ByVal a As Integer, ByVal b As Integer) As Integer
        If a = 0 Then
            Return b
        End If

        While b <> 0
            If a > b Then
                a -= b
            Else
                b -= a

            End If
        End While
        Return a
    End Function
    Public Function LCM(ByVal a As Integer, ByVal b As Integer) As Integer
        Return (a * b) \ GCD(a, b)
    End Function
    Sub Main()

        Console.WriteLine("Enter first value")
        Dim a As Integer = Console.ReadLine()

        Console.WriteLine("Enter a second value")
        Dim b As Integer = Console.ReadLine()

        Console.WriteLine("GCD is: " & GCD(a, b))
        Console.WriteLine("LCM is: " & LCM(a, b))
        Console.ReadLine()

    End Sub

End Module