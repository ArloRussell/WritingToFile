Module Module1

    Sub Main()
        'This is the object that is going to be used to write to file
        'Passing in true means it will append data to the file if it exists
        Dim file As IO.StreamWriter = New IO.StreamWriter("Arlo-Sample.csv", True)

        Const fieldSeperator As String = ","
        Dim fname, lname, animal As String
        'Dim shift As Integer 'Ceaser
        For i As Integer = 0 To 2
            Console.Write("Please enter the person's first name >> ")
            fname = Console.ReadLine.Trim
            Console.Write($"PLease enter {fname}'s last name >> ")
            lname = Console.ReadLine.Trim
            Console.Write($"Please enter {fname}'s favorite animal >> ")
            animal = Console.ReadLine.Trim
            file.WriteLine($"{fieldSeperator}{fname}{fieldSeperator}{lname}{fieldSeperator}{animal}")
        Next
        file.Close()
    End Sub

End Module
