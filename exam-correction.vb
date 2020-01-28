Module examCorrection
    Public Class Comp

        Public Function ArraySumAndAverage() As Integer
        Dim myArray() As Integer = {45, 53, 55, 76, 9, 12, 68, 67}
        Dim sum = myArray.Sum
        Dim arrayLength = myArray.Length

        Dim average = sum / arrayLength

            Console.WriteLine("The sum of the array is {0}, and the average is {1}", sum, average)

            Console.WriteLine(vbCrLf)
            Return ArraySumAndAverage
        End Function

        Public Function PrimeNumbers() As Integer
            Dim p, n, i As Integer
            p = 1
            Console.WriteLine("Prime numbers between 1 & 100 are : ")
            For n = 1 To 100
                For i = 2 To n - 1
                    If n Mod i = 0 Then
                        p = 0
                        Exit For
                    Else
                        p = 1
                    End If
                Next
                If p = 1 Then
                    Console.WriteLine(n)
                End If
            Next

            Console.WriteLine(vbCrLf)
            Return PrimeNumbers
        End Function

        Public Function MultiplyByTwo() As Integer
            Dim x, y As Integer
            Console.WriteLine("Enter the value to be multiplied by two: ")
            x = Console.ReadLine
            y = x * 2
            Console.WriteLine("{0} * 2 = {1}", x, y)

            Console.WriteLine(vbCrLf)
            Return MultiplyByTwo
        End Function

        Public Function Test() As Integer
            Dim x As Integer = 7
            Dim i, y As Integer

            For i = 1 To 12
                y = x * i
                Console.WriteLine("{0} * {1} = {2}", x, i, y)
            Next

            Console.WriteLine(vbCrLf)
            Return Test
        End Function

        Public Function AddNumbers(x, y) As Integer
            Dim z As Integer
            z = x + y
            Console.WriteLine(z)

            Console.WriteLine(vbCrLf)
            Return z
        End Function

        Public Function Even() As Integer
            Console.WriteLine("Even numbers btn 1 & 100 are: ")
            Dim i As Integer

            For i = 1 To 100
                If (i Mod 2) = 0 Then
                    Console.WriteLine(i)
                End If
            Next

            Console.WriteLine(vbCrLf)
            Return Even
        End Function

        Public Function Odd() As Integer
            Console.WriteLine("Odd numbers btn 1 & 100 are: ")
            Dim i As Integer

            For i = 1 To 100
                If (i Mod 2) = 1 Then
                    Console.WriteLine(i)
                End If
            Next

            Console.WriteLine(vbCrLf)
            Return Odd
        End Function

        Public Function Factorial(num) As Integer
            Dim result As Integer
            If num = 1 Then
                Return 1
            Else
                result = Factorial(num - 1) * num
                Return result
            End If
            Console.WriteLine(vbCrLf)
        End Function

        Public Function WhileEven() As Integer
            Dim i As Integer = 1
            While (i <= 100)
                If (i Mod 2) = 0 Then
                    Console.WriteLine(i)
                End If
                i += 1
            End While

            Console.WriteLine(vbCrLf)
            Return WhileEven
        End Function

        Public Function ComparingValues() As Integer
            Dim x, y As Integer

            Console.WriteLine("Enter the first number")
            x = Console.ReadLine()
            Console.WriteLine("Enter the second number")
            y = Console.ReadLine()

            Console.WriteLine(vbCrLf)

            If x > y Then
                Console.WriteLine("{0} > {1}", x, y)
            ElseIf x < y Then
                Console.WriteLine("{0} < {1}", x, y)
            Else
                Console.WriteLine("{0} = {1}", x, y)
            End If

            Return ComparingValues
        End Function
    End Class

    Sub Maandazi()
        Console.WriteLine("Maandazi!")
        Console.WriteLine(vbCrLf)
    End Sub

    Public Sub Main()
        Dim comp As New Comp

        comp.AddNumbers(2, 3)
        comp.ArraySumAndAverage()
        comp.PrimeNumbers()
        comp.Test()
        comp.Even()
        comp.Odd()
        comp.WhileEven()
        comp.MultiplyByTwo()
        Console.WriteLine("The factorial of 4 is: {0}", comp.Factorial(4))

        Maandazi()
        comp.ComparingValues()
        Console.ReadLine()
    End Sub
End Module