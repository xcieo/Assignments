Module Module1

    Sub Main()
        Dim str As String
        str = "hoscky j"
        'Console.WriteLine(Mid(mystring, 4, 1))
        str = "Real Madrid"
        'Console.WriteLine(str.Length)
        str = "art nouveau"
        'Console.WriteLine(str.Substring(4))
        str = "Los"
        'Console.WriteLine(string.Concat("Los", "Angles"))

        'Console.WriteLine(Chr(65))

        'Console.WriteLine(Asc("A"))

        String.Concat("Big", " ", "Ben")
        String.Concat(String.Concat("Tower", "of"), "London")
        str = "Camel"
        String.Concat(Mid(str, 1, 1), Mid("aardvark", 2, 1), Mid("goat", 4, 1))
        str = "Taj Mahal"
        Console.WriteLine(str.Length + 3)
        Console.WriteLine(CInt("8") + CInt("9"))
        Dim x As String = "BAMBI"
        Dim y As Integer = Mid(x, 3, 2).Length
        Console.WriteLine(y)
        Dim MyString As String = "The quick brown fox"
        Console.WriteLine(Mid(MyString, 11, 5))
        Console.WriteLine(Mid(MyString, 17, 3))
        Console.WriteLine(String.Concat(Mid(MyString, 1, 3), Mid(MyString, 16, 4)))
        Console.WriteLine(String.Concat(Mid(MyString, 5, 5), Mid(MyString, 1, 3)))
        Console.WriteLine(Mid("art nouveau", 5, 7))
        Console.WriteLine(Asc("B") + Asc("8"))
        Console.WriteLine(Asc("Z") - Asc("H"))
        Console.WriteLine(String.Concat(Chr(81), Chr(85), Chr(69), Chr(69), Chr(78)))
        Console.WriteLine(Mid(String.Concat(Chr(66), Chr(69), Chr(65), Chr(84)), 2, 3))










        Console.ReadKey()

    End Sub

End Module
