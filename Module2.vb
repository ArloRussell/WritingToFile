Module Module2
    Private filename As String = "Russell-Exercise1.txt"
    Private Const separator As String = ","
    Sub main()
        Dim input As String
        Do
            Console.Write("Enter r to read in a file, w to write to file or q to quit -> ")
            input = Console.ReadLine.Trim.ToLower
            If input = "r" Then
                ReadInFile()
            ElseIf input = "w" Then
                WriteToFile()
            End If
        Loop While input <> "q"
    End Sub
    Sub ReadInFile()
        If Not IO.File.Exists(filename) Then
            Console.WriteLine($"{filename} does not exist")
            Return
        End If
        Dim infile As New IO.StreamReader(filename)
        While infile.Peek <> -1
            'name is 0, subject is 1, grade is 2
            Dim line() As String = infile.ReadLine.Split(separator)
            Console.WriteLine($"{line(0)} got a {line(2)} in {line(1)}")
        End While
        infile.Close()
    End Sub
    Sub WriteToFile()
        Dim name, subject, grade As String
        Console.Write("Enter the person's name -> ")
        name = Console.ReadLine.Trim
        Console.Write($"Enter {name}'s subject -> ")
        subject = Console.ReadLine.Trim
        Console.Write($"Enter {name}'s grade for {subject} -> ")
        grade = Console.ReadLine.Trim
        'write the data to the file
        Dim file As New IO.StreamWriter(filename, True)
        file.WriteLine($"{name}{separator}{subject}{separator}{grade}")
        file.Close()
    End Sub

End Module
