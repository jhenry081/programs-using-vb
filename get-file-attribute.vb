Imports System.IO
Module Module1

    Sub Main()
        'creating a DirectoryInfo object
        Dim mydir As DirectoryInfo = New DirectoryInfo("D:\intranet")
        ' getting the files in the directory, their names and size
        Dim f As FileInfo() = mydir.GetFiles()
        Dim file As FileInfo
        For Each file In f
            Console.WriteLine("File Name: {0} Size: {1} Created : {2} Last Access : {3} File Attribute : {4}", file.Name, file.Length, file.CreationTime, file.LastAccessTime, file.Attributes)
        Next file
        Console.ReadKey()
    End Sub

End Module
