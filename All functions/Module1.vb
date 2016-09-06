Module Module1

    Sub Main()
        Dim position As String
        Dim length As Integer
        Dim options As Integer
        Dim find As String
        Dim animals() As String = {"elephant", "snake", "tiger", "lion", "zebra", "kangroo", "jaguar"}
        Dim range As Integer
        Dim value As Integer
        Console.WriteLine("choose searching options")
        Console.WriteLine("press 1 for searching with initial")
        Console.WriteLine("press 2 for searching with the leangth of word")
        Console.WriteLine("press 3 for finding the index")
        Console.WriteLine("press 4 for including a condition")
        Dim arr2() As String
        Dim x() As String


        options = Console.ReadLine
        Select Case options
            Case 1

                Console.WriteLine("type the initials of the required animals")
                find = Console.ReadLine()
                Console.WriteLine(Array.Find(animals, Function(y) (y.StartsWith(find))))
            Case 2
                Console.WriteLine("enter the word length")
                length = Console.ReadLine
                x = (Array.FindAll(animals, Function(y) ((y.Length = length))))
                Console.WriteLine(x(0))
            Case 3
                Console.WriteLine("enter name")
                position = Console.ReadLine
                Console.WriteLine(Array.FindIndex(animals, Function(s) s = position))
            Case 4
                Console.WriteLine("press 1 for range being smaller then your value")
                Console.WriteLine("press 2 for range being smaller then or equal to your value")
                Console.WriteLine("press 3 for range being greater then your value")
                Console.WriteLine("press 4 for range being greater then or equal to your value")
                range = Console.ReadLine
                Console.WriteLine("enter the value")
                value = Console.ReadLine
                Select Case range
                    Case 1
                        arr2 = (Array.FindAll(animals, Function(y) (y.Length < value)))
                        Console.WriteLine(String.Join(",", arr2))
                    Case 2
                        arr2 = (Array.FindAll(animals, Function(y) (y.Length <= value)))
                        Console.WriteLine(String.Join(",", arr2))
                    Case 3
                        arr2 = (Array.FindAll(animals, Function(y) (y.Length > value)))
                        Console.WriteLine(String.Join(",", arr2))
                    Case 4
                        arr2 = (Array.FindAll(animals, Function(y) (y.Length >= value)))
                        Console.WriteLine(String.Join(",", arr2))
                    Case Else
                        Console.WriteLine("Error")

                End Select

            Case Else
                Console.WriteLine("Option not found !!!")


        End Select

        Console.ReadKey()
    End Sub

End Module
