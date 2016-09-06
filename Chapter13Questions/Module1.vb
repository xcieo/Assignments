Module Module1

    Sub Main()
        '-------------------------------------------------------------
        'Dim Ounces As Integer
        'Dim Grams As Integer
        'Console.WriteLine("Ounces{0}Grams", vbTab)
        'For Ounces = 1 To 10
        '    Grams = Ounces * 28.35
        '    Console.WriteLine("{0}{1}{2}", Ounces, vbTab, Grams)
        'Next

        '--------------------------------------------------------------

        'Dim UserID As String
        'Dim upper = 0, digit As Integer = 0
        'UserID = Console.ReadLine()

        'For Each a In UserID
        '    If a = UCase(a) And Not IsNumeric(a) Then
        '        upper += 1
        '    End If
        '    If IsNumeric(a) Then
        '        digit += 1
        '    End If
        'Next

        'If digit = 4 And upper = 4 Then
        '    Console.WriteLine("Correct Format")
        'Else
        '    Console.WriteLine("Wrong Format")
        'End If

        '-----------------------------------------------------------------

        Dim Tally(5) As Integer
        Dim Choice As Integer
        Dim Titles() As String = {"", "Reading books", "Play computer games", "Sports", "Programming", "Watching TV"}
        Dim FileWrite As IO.StreamWriter
        Dim FileRead As IO.StreamReader
        Do
            Choice = Console.ReadLine()
            If Choice >= 1 And Choice <= 5 Then
                Tally(Choice) += 1
            End If
        Loop Until (Choice = 0)

        FileRead = New IO.StreamReader("ArrayData.txt")
        For index = 1 To 5
            Tally(index) = FileRead.ReadLine()
        Next
        FileRead.Close()

        For index = 1 To 5
            Console.Write("{0}{1}", Titles(index), vbTab)
            For x = 1 To Tally(index)
                Console.Write("\")
            Next
            Console.Write(vbNewLine)
        Next

        FileWrite = New IO.StreamWriter("ArrayData.txt")
        For index = 1 To 5
            FileWrite.WriteLine(Tally(index))
        Next
        FileWrite.Close()

        Console.ReadKey()
    End Sub

End Module
