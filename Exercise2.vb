Module Exercise2
    'A. Russell
    '1/4/24
    'Exercise 2

    Private filename As String = "Russell-Exercise1.txt"
    Private Const separator As String = "-"
    Sub Main()
        Table()
    End Sub

    Sub Table()
        Dim infile As New IO.StreamReader(filename)
        Dim title As String
        title = "        RED FOX INDUSTRIES 
        1567 WEST 97TH STREET 
        ERIE PENNSYLVANIA 
        PAYROLL REPORT"

        Console.WriteLine(title)
        Console.WriteLine()
        Printline("Employee", "Employee", "Employee")
        Printline("Number", "Name", "Sales")
        Console.WriteLine("-".PadRight(55, "-"))
        While infile.Peek <> -1

            Dim line() As String = infile.ReadLine.Split(separator)
            Printline(line(0), line(1), line(2))
        End While
        Console.WriteLine("-".PadRight(55, "-"))
        infile.Close()

    End Sub

    Sub Printline(str1 As String, str2 As String, str3 As String)
        Console.WriteLine("{0} | {1} | {2}", str1.PadRight(20), str2.PadRight(20), str3.PadRight(20))
    End Sub
End Module
