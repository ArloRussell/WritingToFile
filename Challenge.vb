Module Challenge
    'A. Russell
    '1/8/24
    'Challenge + Crying.
    Private filename As String = "MLBStats2000-2019.csv"
    Private Const separator As String = ","

    Sub Main()
        Console.WriteLine("Arlo Russell" & vbNewLine)
        Dim num As Integer
        Dim year As String
        num = TakeNum()
        If num = 1 OrElse num = 2 Then
            year = GivenYear()
            'Console.WriteLine(year)
            If num = 1 Then
                Console.WriteLine("Here!!")
                Players(year, "best")
                Console.WriteLine("Here!!")
            Else
                Players(year, "worst")
            End If
        ElseIf num = 3 OrElse num = 4 Then
            If num = 3 Then
                AllTime("best")
            Else
                AllTime("worst")
            End If
        ElseIf num = 5 Then
            WriteToFile()
        End If
    End Sub
    Function TakeNum()
        Dim input As String
        Dim num As Integer
        Dim valid As Boolean

        Do
            Console.WriteLine("1 - look up the best players based on batting average for a given year" &
                              vbNewLine & "2 - look up the worst players based on batting average for a given year" &
                              vbNewLine & "3 - list the best players based on batting averages from 2000-2019" &
                              vbNewLine & "4 - list the worst players based on batting averages from 2000-2019" &
                              vbNewLine & "5 - process the list and write the top 5 batters from each year to file" &
                              vbNewLine & "Q - Quit" &
                              vbNewLine & "(Note: only players with 120+ games played are evaluated)" &
                              vbNewLine)
            Console.Write("Please enter a 1, 2, 3, 4, 5, or Q >> ")
            input = Console.ReadLine.Trim.ToUpper
            If input = "Q" Then
                Exit Do
            End If
            valid = Integer.TryParse(input, num)
            If valid Then
                If num = 1 OrElse num = 2 OrElse num = 3 OrElse num = 4 OrElse num = 5 Then
                    valid = True
                Else
                    valid = False
                End If
            End If
        Loop While Not valid
        If input = "Q" Then
            Return input
        Else
            Return num
        End If
    End Function
    Function GivenYear()
        Dim input As String
        Dim num As Integer
        Dim valid As Boolean
        Do
            Console.Write("Please enter a year between 2000 and 2019 >> ")
            input = Console.ReadLine.Trim
            valid = Integer.TryParse(input, num)
            If num >= 0 AndAlso num <= 19 OrElse num >= 2000 AndAlso num <= 2019 Then
                valid = True
                If num >= 0 AndAlso num <= 19 Then
                    num += 2000
                End If
            Else
                valid = False
            End If
        Loop While Not valid
        Return num.ToString
    End Function
    Sub Players(year As String, bw As String)
        Dim infile As New IO.StreamReader(filename)
        Dim line() As String = infile.ReadLine.Split(separator)
        If bw = "best" Then
            While infile.Peek <> -1
                Console.WriteLine("Works To Here")
                If year = line(3) Then 'This is the problem     I am in tears.
                    Console.WriteLine("Butt")
                    Console.WriteLine("Butt2")
                    Console.WriteLine(line(1) & line(2))
                End If
            End While
        Else
            If year = line(3) Then
                Console.WriteLine("Butt3")
                While infile.Peek <> -1
                    Console.WriteLine("Butt4")
                    Console.WriteLine(line(3) & line(4))
                End While
            End If
        End If
        Console.WriteLine("Butt5")
    End Sub
    Sub AllTime(bw As String)
        Dim infile As New IO.StreamReader(filename)
        Dim line() As String = infile.ReadLine.Split(separator)
        If bw = "best" Then
            'Best
        Else
            'Worst
        End If
    End Sub
    Sub WriteToFile()
        Dim name, fieldSeparator As String
        Console.Write("PLease enter the output .csv file name >> ")
        name = Console.ReadLine
        Dim filepath As IO.StreamWriter = New IO.StreamWriter(name, True)
        fieldSeparator = ","
    End Sub
End Module
