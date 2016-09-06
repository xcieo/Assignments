Module Module1

    Sub Q1()
        'Write a program that will read in three integers And display the sum.
        Dim v1, v2, v3, total As Integer
        Console.WriteLine("Enter three values")
        v1 = Console.ReadLine()
        v2 = Console.ReadLine()
        v3 = Console.ReadLine()
        total = v1 + v2 + v3
        Console.WriteLine("Sum of these Three Numbers is " & total)
    End Sub

    Sub Q2()
        'Write a program that will read two integers and display the product.
        Dim v1, v2, total As Integer
        Console.WriteLine("Enter two values")
        v1 = Console.ReadLine()
        v2 = Console.ReadLine()
        total = v1 * v2
        Console.WriteLine("Product of two Numbers is " & total)
    End Sub

    Sub Q3()
        'Enter the length, width And depth of a rectangular swimming pool. Calculate the volume of
        'water required to fill the pool And display this volume.
        Dim v1, v2, v3, total As Integer
        Console.WriteLine("Enter Dimensions of the pool")
        Console.Write("Length: ")
        v1 = Console.ReadLine()
        Console.Write("Width : ")
        v2 = Console.ReadLine()
        Console.Write("Depth : ")
        v3 = Console.ReadLine()
        total = v1 * v2 * v3
        Console.WriteLine("Volume of water required is " & total)
    End Sub

    Sub Q4()
        'Write a program that will display random numbers between 1 and 6 until a six is generated.
        Dim n As Random = New Random
        Dim x As Integer
        Do Until x = 6
            x = n.Next(1, 7)
            Console.WriteLine(x)
        Loop
    End Sub

    Sub Q5()
        'Write a program that will display six random numbers between 5 and 10.
        Dim n As Random = New Random
        For x = 1 To 6
            Console.WriteLine(n.Next(5, 11))
        Next
    End Sub

    Sub Q6()
        'Write a console application that asks for your forename And then your surname And then
        'displays both names on the same line.
        Dim firstname, lastname As String
        Console.Write("Enter your first name : ")
        firstname = Console.ReadLine()
        Console.Write("Enter your last name  : ")
        lastname = Console.ReadLine()

        Console.WriteLine("You Name is " & firstname & " " & lastname)
    End Sub

    Sub Q7()
        'Write a program that will ask the user for their first name. The program should then
        'concatenate the name With a message, such as 'Hello Fred. How are you?' and output this
        'String to the user.

        Dim firstName As String

        Console.Write("Enter you first name: ")
        firstName = Console.ReadLine()
        Console.WriteLine("Hello {0}. How are you?", firstName)
    End Sub

    Sub Q8()
        'Write a program that asks the user to enter two double numbers and displays the product
        'of these two numbers to 2 decimal places, with user-friendly messages. (tip: see page 19
        'for examples)

        Dim num1, num2 As Double
        Console.WriteLine("Enter two decimal numbers")
        num1 = Console.ReadLine()
        num2 = Console.ReadLine()
        Console.Write("The product is {0}", Format(num1 * num2, "#####.00"))
    End Sub

    Sub Q9()
        'Calculate the area of a rectangle where the length and breadth are entered by the user. 

        Dim length, width As Integer
        Console.WriteLine("Enter length and width of the rectangle to calculate its area")
        length = Console.ReadLine()
        width = Console.ReadLine()
        Console.WriteLine("The area of rectangle is {0}", length * width)

    End Sub

    Sub Q10()
        'Calculate the area and circumference of a circle, where the radius is entered into an edit
        'box. The radius and area may not always be integer values.

        Dim radius As Integer
        Console.WriteLine("Enter radius of the circle to calculate its area")
        radius = Console.ReadLine()
        Console.WriteLine("The area of circle is {0}", Format(2 * Math.PI * radius, "###########.00"))

    End Sub

    Sub Q11()
        'Create an automatic percent calculator that a teacher could use after an exam. The
        'teacher will enter the total number of marks and the raw score. The form them calculates
        'the percentage (to two decimal places).

        Dim totalNumbers, obtained As Double

        Console.WriteLine("Welcome to automatic percentage calculator")
        Console.WriteLine("Enter the total Marks")
        totalNumbers = Console.ReadLine()

        While True
            Console.Write("Marks obtained: ")
            obtained = Console.ReadLine()
            Console.WriteLine("Percentage of {0} marks out of {1} is {2}%", obtained, totalNumbers, Format(((obtained / totalNumbers) * 100), "###.00"))

        End While

    End Sub

    Sub Q12()
        'Create a currency converter where the number of pounds is entered and the procedure
        'calculates the number of Euros. Assume the exchange rate of £1 = €1.15.
        'Adjust your program to allow any exchange rate.

        Dim amount As Double

        Console.WriteLine("Enter the amount to convert to Euro from Pounds")
        amount = Console.ReadLine()
        Console.WriteLine("Euro = {0}", amount * 1.15)

    End Sub

    Sub Q13()
        'Convert a temperature entered in Celsius to Fahrenheit 
        'Write a program to convert a person's height in inches into centimetres and their
        'weight in stones into kilograms. [1 inch = 2.54 cm And 1 stone = 6.364 kg]

        Dim Celsius, Fahrenheit As Double
        Console.Write("Enter Temprature in Celsius : ")
        Celsius = Console.ReadLine()
        Fahrenheit = ((9 / 5) * Celsius) + 32
        Console.WriteLine("{0} Celsius is equal to {1} Fahrenheit", Celsius, Fahrenheit)

    End Sub

    Sub Q14()
        'Write a program to convert a person's height in inches into centimetres and their
        'weight in stones into kilograms. [1 inch = 2.54 cm And 1 stone = 6.364 kg]

        Dim height_inches, weight_stones As Double

        Console.Write("Enter your height : ")
        height_inches = Console.ReadLine()
        Console.Write("Enter your weight : ")
        weight_stones = Console.ReadLine()

        Console.WriteLine("Your Height in Centimeters is {0} and you weight in kilograms is {1}", height_inches * 2.54, weight_stones * 6.364)

    End Sub

    Sub Main()
        Q14()

        Console.ReadKey()
    End Sub

End Module
