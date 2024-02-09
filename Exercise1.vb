Module Exercise1
    'A. Russell
    '1/4/24
    'Exercise 1
    Sub Main()
        Dim filepath As IO.StreamWriter = New IO.StreamWriter("Russell-Exercise1.txt", True)
        Dim fieldSeperator, emNum, name, sales, input As String
        Dim num As Integer
        fieldSeperator = "-"
        Console.WriteLine("Arlo Russell" & vbNewLine)
        Console.Write("Please enter the number of employees >> ")
        input = Console.ReadLine
        Integer.TryParse(input, num)
        For i As Integer = 1 To num
            Console.Write("Enter employee number >> ")
            emNum = Console.ReadLine.Trim
            Console.Write("Enter employee name >> ")
            name = Console.ReadLine.Trim
            Console.Write("Enter employee total sales >> ")
            sales = Console.ReadLine.Trim

            filepath.Write(emNum & fieldSeperator)
            filepath.Write(name & fieldSeperator)
            filepath.Write(sales)
            filepath.WriteLine()
        Next
        filepath.Close()
    End Sub
End Module
