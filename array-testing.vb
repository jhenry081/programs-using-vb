Module Module1
    Sub Main()
        Dim results(,) As Integer = {{56, 78, 60}, {87, 57, 56}, {70, 89, 77}, {90, 45, 99}}
        Dim subjects() As String = {"Physics", "Chemistry", "Maths"}

        'Dim i, j As Integer

        For i = 0 To 3
            Dim total_marks As Integer = 0
            For j = 0 To 2
                Console.WriteLine("{0} : {1}", subjects(j), results(i, j))
                total_marks += results(i, j)

                Console.WriteLine()

            Next
            Console.WriteLine()
            Console.WriteLine("average: {0}", total_marks / 3)
            Console.WriteLine()
        Next

            Console.ReadLine()
    End Sub

End Module
