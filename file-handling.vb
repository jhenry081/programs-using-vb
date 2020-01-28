Imports System.IO
Module Module1

    Sub Main()
        Dim mydir As DirectoryInfo = New DirectoryInfo("E:\")
        Dim f As FileInfo() = mydir.GetFiles()
        Dim file As FileInfo

        For Each file In f
            Console.WriteLine("File name: {0} Size: {1} ", file.Name, file.Length)
        Next

        Console.ReadLine()
    End Sub

End Module