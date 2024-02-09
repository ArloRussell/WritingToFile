Module Exercise4
    'A. Russell
    '1/4/24
    'Exercise 4
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
        Printline("Student", "Test", "Grade")
        Printline("Name", "Total", "Average")
        Console.WriteLine("-".PadRight(55, "-"))
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
            Printline(name, total.ToString("N0"), ave.ToString("P0"))
        End While
        Console.WriteLine("-".PadRight(55, "-"))
        infile.Close()

    End Sub

    Sub Printline(str1 As String, str2 As String, str3 As String)
        Console.WriteLine("{0} | {1} | {2}", str1.PadRight(20), str2.PadRight(20), str3.PadRight(20))
    End Sub
End Module
