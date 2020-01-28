Module arrayValuesManipulation
    Sub Main()
        Dim myArray As Integer() = {1, 2, 3, 4}
        Dim sum = myArray.Sum()
        Dim prod = myArray.Aggregate(Function(runningProduct, nextFactor) runningProduct * nextFactor)
        Console.WriteLine("The sum of the values in the array is {0} and the product is {1}", sum, prod)
        Console.ReadLine()
    End Sub

End Module
