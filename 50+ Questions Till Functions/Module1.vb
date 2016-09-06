Module Module1
    Sub p38_q3()
        'Write a program that displays a conversion table For pounds To kilograms, ranging from 1
        'pound to 20 pounds [1 kg = 2.2 pounds].

        For x = 1 To 20
            Console.WriteLine("{0} pound = {1} kg", x, x / 2.2)
        Next
    End Sub

    Sub p38_q4()
        'Write a program that asks the user to enter 8 integers and displays the largest integer.
        'Adapt your program so that the user can type in any number of positive integers. Input will
        'terminate with the rogue value of—l.
        'Adapt your program so that it will also display the smallest integer.
        'Adapt your program from If necessary, so that it works if the user types in the rogue value as
        'the first value


        Console.WriteLine("Enter 8 positve values")

        Dim size As Integer = 8
        Dim array(size), maxValue, minValue As Integer

        Console.WriteLine()
        For x = 0 To size - 1
            Console.Write("Value: ")
            array(x) = Console.ReadLine()
            If array(x) < 0 Then
                Console.WriteLine("Rogue Value is Entered")
                Console.ReadKey()
                Exit Sub
            End If
        Next

        For x = 0 To size - 1

        Next

        For x = 0 To size - 1
            For y = 0 To size - 1
                If array(y) < array(x) Then
                    maxValue = array(y)
                End If
            Next
        Next

        For x = 0 To size - 1
            For y = 0 To size - 1
                If array(y) > array(x) Then
                    minValue = array(y)
                End If
            Next
        Next

        Console.WriteLine(vbNewLine & "Max Value is {0} and Min Value is {1}", maxValue, minValue)
    End Sub

    Sub p38_q5()
        'Write a game in which the user guesses what random number between 1 And 1000 the
        'computer has 'thought of, until he or she has found the correct number. The computer
        'should tell the user whether Each guess was too high, too low Or spot on. (TIP: use the
        'Maths library, which has a random function. See page 18)

        Dim rand As Random = New Random
        Dim guess, actual As Integer
        actual = rand.Next(1, 1001)
        Console.WriteLine("Guess a number between 1 and 1000")
        Console.Write("Guess: ")
        guess = Console.ReadLine()
        If guess > actual Then
            Console.WriteLine("Your Guess was too high")
        ElseIf guess < actual Then
            Console.WriteLine("Your Guess was too low")
        Else
            Console.WriteLine("Your Guess is spot on")
        End If

    End Sub

    Sub p41_q1()
        'Write a program that reads 6 names into an array. The program must display the names in
        'the same order that they were entered And then in reverse order.

        Dim array(6) As String
        Console.WriteLine("Enter the names")
        For x = 0 To 5
            Console.Write("{0}. ", x + 1)
            array(x) = Console.ReadLine()
        Next
        Console.WriteLine(vbNewLine & "Displaying in names in same order" & vbNewLine)
        For x = 0 To 5
            Console.WriteLine("{0}. {1}", x + 1, array(x))
        Next
        Console.WriteLine(vbNewLine & "Displaying in names in reverse order" & vbNewLine)
        For x = 5 To 0 Step -1
            Console.WriteLine("{0}. {1}", x + 1, array(x))
        Next

    End Sub

    Sub p41_q2()
        'Make a program that fills an array with 5 elements with values entered by the user.
        'Print out all elements in order.

        Dim array(5) As String
        Console.WriteLine("Enter the values")
        For x = 0 To 4
            Console.Write("{0}. ", x + 1)
            array(x) = Console.ReadLine()
        Next
        Console.WriteLine(vbNewLine & "Displaying all elements in order" & vbNewLine)
        For x = 0 To 4
            Console.WriteLine("{0}. {1}", x + 1, array(x))
        Next

    End Sub

    Sub p41_q3()
        'Make a program that first asks the user how many values to enter. The program will then
        'fill an array with all entered values. When all values are entered the program prints out the
        'highest entered value And its position (And index ) in the array.

        Dim size As Integer
        Console.WriteLine("How many value you want to enter")
        size = Console.ReadLine()
        Dim array(size), maxValue, maxIndex As Integer

        Console.WriteLine()
        For x = 0 To size - 1
            Console.Write("Value: ")
            array(x) = Console.ReadLine()
        Next

        For x = 0 To size - 1
            For y = 0 To size - 1
                If array(x) < array(y) Then
                    maxValue = array(y)
                    maxIndex = y
                End If
            Next
        Next

        Console.WriteLine(vbNewLine & "Max Value is {0} at index {1}", maxValue, maxIndex)


    End Sub

    Sub p41_q4()
        'Write a program to simulate the throwing of a die 30 times.
        Dim rand As Random = New Random
        Dim dicethrow As Integer
        Dim array(6) As Integer
        For x = 0 To 29
            Console.WriteLine("Press any key to throw dice")
            Console.ReadKey()
            dicethrow = rand.Next(1, 7)
            Console.WriteLine(dicethrow)
            array(dicethrow) += 1
        Next
        Console.WriteLine()
        For x = 0 To 5
            Console.WriteLine("{0} is thrown {1} times", x + 1, array(x))
        Next

    End Sub

    Sub p42_q1()
        'Write a program which asks the user for the subjects done in each period for each day And
        'then prints out the timetable with suitable headings.

        Dim week() As String = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"}
        Dim timetable(week.Count, 5) As String
        Dim count As Integer
        For y = 0 To week.Count - 1
            Console.WriteLine("For {0}", week(y))
            Console.Write("Enter the number of Subjects for this day ")
            Console.WriteLine()
            count = Console.ReadLine()
            For i = 0 To count - 1
                Console.Write("Subject Name: ")
                timetable(y, i) = Console.ReadLine()
            Next
        Next

        Console.WriteLine(vbNewLine & "Time Table" & vbNewLine)

        For x = 0 To week.Count - 1
            Console.Write(week(x) & vbTab)
            For y = 0 To 4
                Console.Write(timetable(x, y))
            Next
            Console.WriteLine()
        Next

    End Sub

    Sub p42_q2()
        'Using a two-dimensional array, write a program that stores the names Of ten countries In
        'column 1 And their capitals in column 2. The program should then pick a random country
        'And ask the user for the capital. Display an appropriate message to the user to show
        'whether they are right Or wrong.
        'Expand the program above to ask the user 5 questions And give a score of how many they
        'got Right out of 5.

        Dim array(2, 10), answer As String

        Console.WriteLine("Enter the Data for 10 countries and their Capitals")
        For y = 0 To 9
            Console.Write("Country: ")
            array(0, y) = Console.ReadLine()
            Console.Write("Capital: ")
            array(1, y) = Console.ReadLine()
        Next
        Console.Write(vbNewLine)
        Dim n As Random = New Random
        Dim x As Integer = n.Next(0, 10)
        Dim correct As Integer = 0
        For count = 0 To 4
            Console.WriteLine("What is the capital of {0]", array(0, x))
            answer = Console.ReadLine()
            If answer = array(1, x) Then
                correct += 1
            End If
            x = n.Next(0, 10)
        Next

        Console.WriteLine("You entered {0} out of 5 correct answers", correct)

    End Sub

    Sub p42_q3()
        'Store in a 1-D array a set of 5 place names, And in a 2-D array the distances between the
        'places.Ensure that the order of the places Is the same in both arrays. When the names of
        '2 places are input, the distance between them Is displayed. If they are Not both in the table,
        'a suitable message should be displayed.

        Dim cities() As String = {"Lahore", "Islamabad", "Karachi", "Faisalabad", "Quetta"}
        Dim groups(10, 3), city1, city2 As String
        Dim rowfound As Integer = -1
        Dim row As Integer = 0
        Console.WriteLine("Enter Distances between following cites")

        For x = 0 To 4

            For y = x + 1 To 4

                Console.Write("{0} and {1} : ", cities(x), cities(y))
                groups(row, 0) = cities(x)
                groups(row, 1) = cities(y)
                groups(row, 2) = Console.ReadLine()
                row += 1
            Next

        Next

        'For x = 0 To 10
        '    Console.WriteLine(groups(x, 0) & vbTab & groups(x, 1) & vbTab & groups(x, 2))
        'Next

        Console.WriteLine("To Check Distances Enter names of two cites")
        city1 = Console.ReadLine()
        city2 = Console.ReadLine()

        For x = 0 To 9
            If (groups(x, 0) = city1 Or groups(x, 1) = city1) And (groups(x, 0) = city2 Or groups(x, 1) = city2) Then
                rowfound = x
            End If
        Next
        If rowfound <> -1 Then
            Console.WriteLine("Distance between {0} and {1} is {2}", city1, city2, groups(rowfound, 2))
        Else
            Console.WriteLine("Not Found")
        End If


    End Sub

    Sub p42_q4()
        'Design And Write() a program to store such a Latin Square of a size given by the user. The
        'program should also display the Latin Square.

        Dim n, position As Integer
        Console.WriteLine("Enter Value of n")
        n = Console.ReadLine()
        Console.Write(vbNewLine)
        Dim matrix(n, n)
        For x = 0 To n - 1
            position = x
            For column = 0 To x
                matrix(position, column) = x + 1
                position -= 1
            Next
        Next

        For value = 1 To n - 1
            position = n - 1
            For row = value To n - 1
                matrix(row, position) = value
                position -= 1
            Next
        Next

        For y = 0 To n - 1
            For x = 0 To n - 1
                Console.Write(matrix(x, y) & vbTab)

            Next
            Console.Write(vbNewLine)
        Next

    End Sub

    Sub p43()
        'Create a program that fills a two-dimensional array with ascending values.
        'The Number Of rows, the number of columns And the starting value Is determined by the user.
        'Print out all elements of this array.

        Dim rows, columns, starting_value, value As Integer

        Console.WriteLine("Enter following information")
        Console.Write("Rows: ")
        rows = Console.ReadLine()
        Console.Write("Columns: ")
        columns = Console.ReadLine()
        Console.Write("Starting Value: ")
        starting_value = Console.ReadLine()

        Dim array(rows, columns) As Integer
        value = starting_value
        For y = 0 To columns - 1
            For x = 0 To rows - 1
                array(x, y) = value
                value += 1
            Next
        Next

        For y = 0 To columns - 1
            For x = 0 To rows - 1
                Console.Write(array(x, y) & vbTab)

            Next
            Console.Write(vbNewLine)
        Next


    End Sub

    Sub p62_q1()
        'Write a program that reads in a string and displays the number of characters in the string.
        Dim sentence As String

        Console.WriteLine("Enter a sentence")
        sentence = Console.ReadLine()
        Console.WriteLine("{0} characters are in this sentence", sentence.Count)


    End Sub

    Sub p62_q2()
        'Write a program that displays the ASCII code for any given character.

        Dim ch As Char
        Console.WriteLine("Enter a character")
        ch = Console.ReadLine()
        Console.WriteLine("The ASCII value of {0} is {1}", ch, Asc(ch))


    End Sub

    Sub p62_q3()
        'Write a program that will display the character for a given ASCII code.

        Dim ascii As Integer
        Console.WriteLine("Enter a ASCII for a character")
        ascii = Console.ReadLine()
        Console.WriteLine("The character is {0} ", Chr(ascii))
    End Sub



    Sub Main()
        Dim size As Integer = 7
        Dim sto(size) As Integer
        Dim input, num As Integer
        Dim x As Integer = 0
        input = Console.ReadLine()
        num = input
        Do Until (num = 0 Or num = 1)
            sto(x) = num Mod 2
            num \= 2
            x += 1
        Loop
        sto(x) = num


        Console.Write("{0} in binary is ", input)
        For i = size To 0 Step -1
            Console.Write(sto(i))
        Next


        Console.ReadKey()
    End Sub

End Module

