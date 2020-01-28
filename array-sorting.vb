Module arraySorting

    Sub Main()
        Dim zooAnimals = New String() {"lion", "turtle", "ostrich", "rhinoceros", "antelope", "zebra"}

        Array.Sort(zooAnimals)

        Console.WriteLine("The ordered list of animals is;-")

        For Each animal In zooAnimals
            Console.WriteLine(animal)
        Next

        Console.ReadLine()
    End Sub

End Module
