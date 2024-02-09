Module Exercise5
    'A. Russell
    '1/4/24
    'Exercise 5
    Private filename As String = "Russell-Exercise3.txt"
    Private Const separator As String = "-"
    Sub Main()
        Table()
    End Sub

    Sub Table()
        Dim infile As New IO.StreamReader(filename)
        Dim title As String
        title = "        INTELLECT HAVEN COLLEGE 
        DENVER COLORADO 
        GRADING REPORT"

        Console.WriteLine(title)
        Console.WriteLine()
        Printline("Student", "Test", "Test", "Test", "Test", "Grade")
        Printline("Name", "One", "Two", "Three", "Four", "Average")
        Console.WriteLine("-".PadRight(70, "-"))
        While infile.Peek <> -1

            Dim line() As String = infile.ReadLine.Split(separator)
            Dim name As String = line(0)
            Dim score(line.Length - 1) As Integer
            Integer.TryParse(line(1), score(1))
            Integer.TryParse(line(2), score(2))
            Integer.TryParse(line(3), score(3))
            Integer.TryParse(line(4), score(4))
            Dim total As Integer = score(1) + score(2) + score(3) + score(4)
            Dim ave As Double = (total / 4) / 100
            Printline(name, score(1).ToString("N0"), score(2).ToString("N0"), score(3).ToString("N0"), score(4).ToString("N0"), ave.ToString("P0"))
        End While
        Console.WriteLine("-".PadRight(70, "-"))
        infile.Close()

    End Sub

    Sub Printline(str1 As String, str2 As String, str3 As String, str4 As String, str5 As String, str6 As String)
        Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5}", str1.PadRight(10), str2.PadRight(10), str3.PadRight(10), str4.PadRight(10), str5.PadRight(10), str6.PadRight(10))
    End Sub
End Module
