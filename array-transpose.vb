Module arrayTranspose

    Sub Main()
        Dim i, j, m, n As Integer
        Dim arr1 As Integer(,) = New Integer(30, 30) {}
        Dim arr2 As Integer(,) = New Integer(30, 30) {}

        Console.WriteLine("Enter the number of rows and columns of the matrix: ")
        Console.WriteLine("Rows entered = ", m)
        m = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Columns entered = ", n)
        n = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Set elements in the matrix...")
        Console.WriteLine("The value of m is {0}, and n is {1}", m, n)

        For i = 0 To i < m
            For j = 0 To j < n
                Console.WriteLine(" {arr1({0})},arr2({1}) : ", i, j)
                arr1(i, j) = Convert.ToInt32(Console.ReadLine())
            Next
        Next

        Console.WriteLine("Matrix before Transpose: ")
        For i = 0 To i < m
            Console.WriteLine(" ")
            For j = 0 To j < n
                Console.WriteLine("{0}", arr1(i, j))
            Next
        Next

        For i = 0 To i < m
            For j = 0 To j < n
                arr2(j, i) = arr1(i, j)
            Next
        Next

        Console.WriteLine("Matrix after Transpose: ")
        For i = 0 To i < m
            Console.WriteLine(" ")
            For j = 0 To j < n
                Console.WriteLine("{0}", arr2(i, j))
            Next
            Console.WriteLine("")
        Next

        Console.ReadLine()

    End Sub

End Module