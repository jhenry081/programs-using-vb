' Assignment 1 - Computer Programming Fundamentals
' Full Credits [Wilbroad Simon Assey - BENG19-COE-2]
' Revised [Mohamed A. Hassan - BENG19-COE-1]


Imports System      'System namespace of the program
Imports System.IO   'System I/O

Module Module1 'Module declaration

    'Every program must contain a module of a class that contains the data and procedures that the program uses.

    Public Sub Main() 'Main procedure, which is the entry point for all VB.Net programs

        'Question 1:
        Dim calculator As New UnitConversion
        Dim choice As Integer

        calculator.distance()
        calculator.disp_distance()

        calculator.temperature()
        calculator.disp_temperature()

        calculator.velocity()
        calculator.disp_velocity()

        calculator.currency()
        calculator.disp_currency()

        'Question 2:
        Dim largestnum As New LargestNumber
        largestnum.largest_num()

        'Question 3
        Console.WriteLine("Choose 1 to find distance in miles" & vbNewLine)
        Console.WriteLine("Choose 2 to find temperature in Degrees Centigrade" & vbNewLine)
        Console.WriteLine("Choose 3 to find speed in m/s" & vbNewLine)
        Console.WriteLine("Choose 4 to find currency in USD" & vbNewLine)
        Console.WriteLine("" & vbNewLine)
        Console.WriteLine("Select a choice: " & vbBack)
        choice = Console.ReadLine

        If choice = 1 Then
            calculator.distance()
            calculator.disp_distance()

        ElseIf choice = 2 Then
            calculator.temperature()
            calculator.disp_temperature()

        ElseIf choice = 3 Then
            calculator.velocity()
            calculator.disp_velocity()

        ElseIf choice = 4 Then
            calculator.currency()
            calculator.disp_currency()
        End If

        'Question 4:
        Dim MrDiscount As New BookshopDiscount
        MrDiscount.disc_books()

        'Question 6:
        Dim SevenDivisible As New SumOfDivisible
        SevenDivisible.divisible_numbers()

        'Question 7: Loop for Question 1
        Dim b As Integer
        While choice < 5
            Console.WriteLine("Select a choice")
            choice = Console.ReadLine
            Console.WriteLine("Choose 1 to find distance in miles" & vbNewLine)
            Console.WriteLine("Choose 2 to find temperature in Degree Centigrade" & vbNewLine)
            Console.WriteLine("Choose 3 to find speed in m/s" & vbNewLine)
            Console.WriteLine("Choose 4 to find currency in USD" & vbNewLine)
            Console.WriteLine("" & vbNewLine)
            If choice = 1 Then
                calculator.distance()
                calculator.disp_distance()

            ElseIf choice = 2 Then
                calculator.temperature()
                calculator.disp_temperature()

            ElseIf choice = 3 Then
                calculator.velocity()
                calculator.disp_velocity()

            ElseIf choice = 4 Then
                calculator.currency()
                calculator.disp_currency()
            End If
        End While

        'Question 8:
        Dim TheMonths As New MonthsArray
        TheMonths.month()

        'Question 9:
        Dim Marks As New ExamMarks
        Marks.listmark()

        'Question 10:
        Dim D_Array As New TwoDimension_Array
        D_Array.ArrayOfStudents()


        Console.ReadLine()
    End Sub

    'Question 1: Write a computer program that converts user's input (entered through the keyboard) from one measurement unit to equivalent unit.
    Public Class UnitConversion
        Public dist As Double
        Public fahrenheit As Double
        Public km As Double
        Public amount As Double
        Public speed As Double
        Public degC As Double
        Public mps As Double
        Public tzs As Double

        'Qn 1.a) Distance in miles and program changes it to kilometers
        Public Function distance()
            Console.WriteLine("This Program converts the distance in Kilometers to Miles" & vbNewLine)
            Console.WriteLine("Input the distance (Miles) " & vbBack & vbNewLine)
            km = Console.ReadLine()
            dist = km / 1.6093

            Return dist
        End Function

        Public Sub disp_distance()
            Console.WriteLine(km & " km is equivalent to " & dist & " miles")
        End Sub

        'Qn 1.b) Temperature in Fahrenheit and program changes it to Centigrade
        Public Function temperature()
            Console.WriteLine("This program converts the temperature in Fahrenheit to Degrees Centigrade" & vbNewLine)
            Console.WriteLine("Input the Temperature (Fahrenheit) " & vbBack & vbNewLine)
            fahrenheit = Console.ReadLine
            degC = (fahrenheit - 32) * 5 / 9

            Return degC
        End Function

        Public Sub disp_temperature()
            Console.WriteLine(fahrenheit & " Fahrenheit is equivalent to " & degC & " Degrees Centigrade")
        End Sub

        ' Qn 1.c) Speed in kilometer per hour and program changes it to meter per second
        Public Function velocity()
            Console.WriteLine("This program converts speed in km/h to m/s" & vbNewLine)
            Console.WriteLine("Input speed in km/hr " & vbBack & vbNewLine)
            speed = Console.ReadLine()
            mps = 0.2778 * speed

            Return mps
        End Function

        Public Sub disp_velocity()
            Console.WriteLine(speed & " km/h is equal to " & mps & " m/s")
        End Sub

        'Qn 1.d) Currency in US dollar and program changes it to Tanzania shillings
        Public Function currency()
            Console.WriteLine("This program converts the currency from USD to TZS" & vbNewLine)
            Console.WriteLine("Enter amount in USD: " & vbBack & vbNewLine)
            amount = Console.ReadLine()
            tzs = amount * 2307

            Return tzs
        End Function

        Public Sub disp_currency()
            Console.WriteLine(amount & " USD is equivalent to " & tzs & " TZS")
        End Sub
    End Class

    'Question 2: Write a program that allows user to print largest number out of three integers entered by a user
    Public Class LargestNumber
        Public Sub largest_num()
            Dim num1, num2, num3 As Double

            Console.WriteLine("This program outputs the largest number of three integers" & vbNewLine)
            Console.WriteLine("Input three numbers" & vbNewLine)

            Console.WriteLine("Enter the First number: " & vbBack & vbNewLine)
            num1 = Console.ReadLine

            Console.WriteLine("Enter the Second number: " & vbBack & vbNewLine)
            num2 = Console.ReadLine

            Console.WriteLine("Enter the Third number: " & vbBack & vbNewLine)
            num3 = Console.ReadLine

            If num1 > num2 And num1 > num3 Then
                Console.WriteLine("The largest number is " & num1 & vbNewLine)

            ElseIf num2 > num3 And num2 > num1 Then
                Console.WriteLine("The largest number is " & num2 & vbNewLine)

            ElseIf num3 > num2 And num3 > num1 Then
                Console.WriteLine("The largest number is " & num3 & vbNewLine)
            Else
                Console.WriteLine("Unknown number")
            End If
        End Sub
    End Class

    'Question 4: Discount is provided to customers who buy books in the following criteria:
    'a. Buy three to five books and get discount of 10.05%
    'b. Buy six to ten books and get discount of 12.50%
    'c. Buy more than ten books and get discount is 15.00%

    Public Class BookshopDiscount
        Public Sub disc_books()
            Dim numbooks, amount As Integer
            Dim discount, discount1, discount2 As Double
            Dim tamount1, tamount2, tamount3, creturn1, creturn2, creturn3 As Double

            Console.WriteLine("Enter number of books: " & vbBack & vbNewLine)
            numbooks = Console.ReadLine

            Console.WriteLine("Enter the total amount for all the books: " & vbBack & vbNewLine)
            amount = Console.ReadLine

            If numbooks >= 3 Then
                discount = amount * (10.05 / 100)
                tamount1 = amount - discount
                creturn1 = amount - tamount1

                Console.WriteLine("Total amount to be paid is " & tamount1 & vbNewLine)
                Console.WriteLine("Discount is " & discount & vbNewLine)
                Console.WriteLine("Change returned is " & creturn1 & vbNewLine)

            ElseIf numbooks >= 6 Then
                discount1 = amount * (12.5 / 100)
                tamount2 = amount - discount
                creturn2 = amount - tamount2

                Console.WriteLine("Total amount to be paid is " & tamount2 & vbNewLine)
                Console.WriteLine("Discount is " & discount1 & vbNewLine)
                Console.WriteLine("Change returned is " & creturn2 & vbNewLine)

            ElseIf numbooks >= 10 Then
                discount2 = amount * (15.0 / 100)
                tamount3 = amount - discount2
                creturn3 = amount - tamount3

                Console.WriteLine("Total amount to be paid is " & tamount3 & vbNewLine)
                Console.WriteLine("Discount is " & discount2 & vbNewLine)
                Console.WriteLine("Change returned is " & creturn3 & vbNewLine)
            End If

        End Sub
    End Class

    'Question 6: Write a program that prints all integers (31 to 99) divisible by seven. Prints the sum of printed numbers (Use FOR loop)
    Public Class SumOfDivisible
        Public Sub divisible_numbers()
            Dim x As Integer
            Dim sum As Integer = 0

            Console.WriteLine("This program prints all integers (31 to 99) which are divisible by seven and prints the sum of the numbers" & vbNewLine)

            For x = 31 To 99
                If x Mod 7 = 0 Then
                    Console.WriteLine("The numbers are " & x & vbNewLine)
                    sum = sum + x
                End If
            Next

            Console.WriteLine(vbNewLine & "The sum is " & sum & vbNewLine)
        End Sub
    End Class

    'Question 8: Write a program that declares and initializes array of names of the months in a year and then display the contents of the array.
    Public Class MonthsArray
        Public Sub month()
            Dim monthnames As String
            Dim months As String() = New String() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

            Console.WriteLine(vbNewLine & "One Year Contains the following Month" & vbNewLine)

            For Each monthnames In months
                Console.WriteLine("" & monthnames & "")
            Next
        End Sub
    End Class

    'Question 9: Declare and initialize array with a list of examination marks 56,23,89,27,88,11,67,55,45,70.
    ' Write computer program that prints minimum and maximum examination scores.

    Public Class ExamMarks
        Public Sub listmark()
            Dim marks() = {56, 23, 89, 27, 88, 11, 67, 55, 45, 70}
            System.Array.Sort(marks)
            Console.WriteLine(vbNewLine & "The minmum examination scores is " & marks(0) & vbNewLine)
            Console.WriteLine(vbNewLine & "The maximum examination scores is " & marks(9) & vbNewLine)
        End Sub
    End Class

    'Question 10: Consider list of marks of four students in three subject:
    'Student     Physics     Chemistry   Math
    'Student 1   56          78          60
    'Student 2   87          67          56
    'Student 3   70          89          77
    'Student 4   90          45          99
    'Using 2-Dimesional array, write computer program that prints a list of examination marks in three subjects and average examination score for each student.

    Public Class TwoDimension_Array
        Public Sub ArrayOfStudents()
            Dim student_marks(4, 3) As Integer
            student_marks = {{56, 78, 60}, {87, 67, 56}, {70, 89, 77}, {90, 45, 99}}
            Dim x, y, z, sum As Integer
            x = 1
            sum = 0

            For y = 0 To 3
                Console.WriteLine("Student {0): " & x)

                For z = 0 To 2
                    sum += student_marks(y, z)
                    Console.WriteLine(student_marks(y, z))
                Next z

                Console.WriteLine("Average is : " & sum / 3)
                x += 1
                sum = 0

                Console.WriteLine("")
            Next y
        End Sub
    End Class
End Module