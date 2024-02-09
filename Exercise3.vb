Module Exercise3
    'A. Russell
    '1/4/24
    'Exercise 3
    Sub Main()
        Dim filepath As IO.StreamWriter = New IO.StreamWriter("Russell-Exercise3.txt", True)
        Dim fieldSeperator, name, test1, test2, test3, test4, input As String
        Dim num As Integer
        fieldSeperator = "-"
        Console.WriteLine("Arlo Russell" & vbNewLine)
        Console.Write("Please enter the number of students >> ")
        input = Console.ReadLine
        Integer.TryParse(input, num)
        For i As Integer = 1 To num
            Console.Write("Enter student name >> ")
            name = Console.ReadLine.Trim
            test1 = GetValNum(1)
            test2 = GetValNum(2)
            test3 = GetValNum(3)
            test4 = GetValNum(4)

            filepath.Write(name & fieldSeperator)
            filepath.Write(test1 & fieldSeperator)
            filepath.Write(test2 & fieldSeperator)
            filepath.Write(test3 & fieldSeperator)
            filepath.Write(test4)
            filepath.WriteLine()
        Next
        filepath.Close()
    End Sub
    Function GetValNum(count As Integer)
        Dim input As String
        Dim grade As Integer
        Dim valid As Boolean
        Do
            Console.Write($"Enter the student's grade for test {count} >> ")
            input = Console.ReadLine()
            valid = Integer.TryParse(input, grade)
            If valid Then
                If grade < 0 OrElse grade > 100 Then
                    valid = False
                Else
                    valid = True
                End If
            End If
        Loop While Not valid
        Return grade
    End Function
End Module
