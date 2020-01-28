  Imports System.IO
Module fileProg
    Sub Main()
        Try
            ' Create an instance of StreamReader to read from a file. 
            ' The using statement also closes the StreamReader. 
            Using sr As StreamReader = New StreamReader("E:/Jamaica.txt")
                Dim line As String
                ' Read and display lines from the file until the end of  
                ' the file is reached. 
                line = sr.ReadLine()
                While (line <> Nothing)
                    Console.WriteLine(line)
                    line = sr.ReadLine()
                End While
            End Using
        Catch e As Exception
            ' Let the user know what went wrong.
            Console.WriteLine("The file could not be read:")
            Console.WriteLine(e.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
