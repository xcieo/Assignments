Module Module1

    Sub Main()
        Dim max As Integer = 1
        Dim Names(0 To max) As String
        Dim Height(0 To max) As Integer
        Dim Weight1(0 To max) As Integer
        Dim Weight2(0 To max) As Integer
        Dim BMI(0 To max) As Integer
        Dim Total(0 To max) As Integer
        Dim Result(0 To max) As String
        Dim Difference(0 To max) As Integer
        Dim Avg(0 To max) As Integer

        For x = 0 To max
            Console.WriteLine()
            Console.Write("Enter the Name of the student : ")
            Names(x) = Console.ReadLine()
            Console.Write("Enter the Height : ")
            Height(x) = Console.ReadLine()
            Console.Write("Enter the First Weight : ")
            Weight1(x) = Console.ReadLine()
            Console.Write("Enter the Second Weight : ")
            Weight2(x) = Console.ReadLine()
        Next

        For x = 0 To max
            Total(x) = (Weight1(x) + Weight2(x))
            Avg(x) = ((Weight1(x) + Weight2(x)) / 2)
            BMI(x) = (Total(x) / ((Height(x) * Height(x))))
            Select Case BMI(x)
                Case Is < 20.5
                    Result(x) = "Normal"
                Case Is > 20.5
                    Result(x) = "Over Weight"
            End Select
            Difference(x) = Math.Abs(Weight1(x) - Weight2(x))
        Next

        Console.WriteLine()

        For x = 0 To max
            Console.WriteLine((x + 1).ToString() + " - Name : " + Names(x))
            Console.WriteLine(vbTab + "Average Weight : " + Avg(x).ToString() + vbTab + "BMI : " + BMI(x).ToString() + vbTab + "Difference : " + Difference(x).ToString() + vbTab + "Average Weight : " + Avg(x).ToString())
            Console.WriteLine()
        Next

        Console.ReadKey()

    End Sub

End Module
