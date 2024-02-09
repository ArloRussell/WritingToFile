Module Exercise6
    Sub Main()
        Dim filepath As IO.StreamWriter = New IO.StreamWriter("Russell-Exercise6.txt", True)
        Dim fieldSeperator, acNum, time, requests, input As String
        Dim num As Integer
        fieldSeperator = "-"
        Console.WriteLine("Arlo Russell" & vbNewLine)
        Console.Write("Please enter the number of accounts >> ")
        input = Console.ReadLine
        Integer.TryParse(input, num)
        For i As Integer = 1 To num
            num = GetValNum("account number")
            acNum = num.ToString
            num = GetValNum("start time")
            time = num.ToString
            num = GetValNum("I/O requests")
            requests = num.ToString

            filepath.Write(acNum.PadRight(10) & fieldSeperator)
            filepath.Write(time.PadRight(10) & fieldSeperator)
            filepath.Write(requests)
            filepath.WriteLine()
        Next
        filepath.Close()
    End Sub
    Function GetValNum(ent As String)
        Dim input As String
        Dim num As Integer
        Dim val As Boolean
        Do
            Console.Write($"Enter {ent} >> ")
            input = Console.ReadLine
            val = Integer.TryParse(input, num)
            If val Then
                If num <= 0 Then
                    val = False
                Else
                    If ent = "time" Then
                        If num > 2359 Then
                            val = False
                        Else
                            val = True
                        End If
                    Else
                        val = True
                    End If
                End If
            End If
        Loop While Not val
        Return num
    End Function
End Module
