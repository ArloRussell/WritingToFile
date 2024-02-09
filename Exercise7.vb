Imports System.Net.Configuration

Module Exercise7
    'A. Russell
    '1/5/24
    'Exercise 7
    Private filename As String = "Russell-Exercise6.txt"
    Private Const separator As String = "-"
    Sub Main()
        Table()
    End Sub

    Sub Table()
        Dim infile As New IO.StreamReader(filename)
        Dim title As String

        title = "        Ready Cash Bank 
        4100 State Street 
        Erie, Pennsylvania 
        Computer Charge Report 
"

        Console.WriteLine(title)
        Console.WriteLine()
        Printline("Account", "Start", "I/O", "Current")
        Printline("Number", "Time", "Requests", "Charge")
        Console.WriteLine("-".PadRight(50, "-"))
        While infile.Peek <> -1

            Dim line() As String = infile.ReadLine.Split(separator)
            Dim account As String = line(0)
            Dim start As String = line(1)
            Dim request As Integer = line(2)
            Dim cost As Double = request * 2.25
            Printline(account, start, request.ToString("N0"), cost.ToString("C2"))
        End While
        Console.WriteLine("-".PadRight(50, "-"))
        infile.Close()

    End Sub

    Sub Printline(str1 As String, str2 As String, str3 As String, str4 As String)
        Console.WriteLine("{0} | {1} | {2} | {3}", str1.PadRight(10), str2.PadRight(10), str3.PadRight(10), str4.PadRight(10))
    End Sub
End Module
