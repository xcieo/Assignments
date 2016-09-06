Module Module1

    Sub Main()
        Dim Names(0 To 29) As String
        Dim Test1(0 To 29) As Integer
        Dim Test2(0 To 29) As Integer
        Dim Test3(0 To 29) As Integer
        Dim Avg(0 To 29) As Integer
        Dim Total(0 To 29) As Integer
        Dim Grade(0 To 29) As String
        Dim max As Integer = 29
        For x = 0 To max
            Console.WriteLine()
            Console.Write("Enter the Name of the student : ")
            Names(x) = Console.ReadLine()
            Console.Write("Enter the Test 1 Marks : ")
            Test1(x) = Console.ReadLine()
            Console.Write("Enter the Test 2 Marks : ")
            Test2(x) = Console.ReadLine()
            Console.Write("Enter the Test 3 Marks : ")
            Test3(x) = Console.ReadLine()
        Next

        For x = 0 To max
            Total(x) = (Test1(x) + Test2(x) + Test3(x))
            Avg(x) = (Total(x) / 3)
            Select Case Total(x)
                Case 90 To 100
                    Grade(x) = "Distinction"
                Case 50 To 89
                    Grade(x) = "Merit"
                Case Is < 50
                    Grade(x) = "Fail"
            End Select

        Next

        Console.WriteLine()

        For x = 0 To max
            Console.WriteLine((x + 1).ToString() + " - Name : " + Names(x))
            Console.WriteLine(vbTab + "Test 1 : " + Test1(x).ToString() + vbTab + "Test 2 : " + Test2(x).ToString() + vbTab + "Test 3 : " + Test3(x).ToString() + vbTab + "Total : " + Total(x).ToString() + vbTab + "Average : " + Avg(x).ToString() + vbTab + "Grade : " + Grade(x))
            Console.WriteLine()
        Next

        Console.ReadKey()
    End Sub

End Module
