Module Module1

    Sub Main()
        Dim ProductName(0 To 9) As String
        Dim ProductQuantity(0 To 9) As Integer
        Dim ProductPrice(0 To 9) As Integer
        Dim GrandTotal As Integer = 0
        Dim NumberOfProducts As Integer = 0
        Dim TotalQty As Integer = 0
        Dim max, min As Integer
        max = 100
        min = 0
        ' Getting input from user
        While NumberOfProducts = 0 Or NumberOfProducts > 10
            Console.Write("How many enteries you want to do (Max = 10) : ")
            NumberOfProducts = Console.ReadLine()
        End While
        NumberOfProducts -= 1
        For x = 0 To NumberOfProducts
            Console.WriteLine()
            Console.WriteLine((x + 1).ToString() + " - Enter the name of Product : ")
            ProductName(x) = Console.ReadLine()
            Console.WriteLine("Enter the Quantity of Product : ")
            ProductQuantity(x) = Console.ReadLine()
            Console.WriteLine("Enter the Price of Product : ")
            ProductPrice(x) = Console.ReadLine()
        Next

        ' Processing and giving output

        Console.WriteLine()
        Console.WriteLine("No." + " - " + "Product Name" + vbTab + "Product Quantity" + vbTab + "Total")
        Console.WriteLine()

        'Output to the screen
        For x = 0 To NumberOfProducts
            Console.WriteLine((x + 1).ToString() + " - " + ProductName(x).ToString() + vbTab + ProductQuantity(x).ToString() + vbTab + (ProductPrice(x) * ProductQuantity(x)).ToString())
        Next


        For x = 0 To NumberOfProducts
            GrandTotal += ProductPrice(x)
            TotalQty += ProductQuantity(x)
        Next

        Console.WriteLine()
        Console.WriteLine("The grand total : " + GrandTotal)
        If (TotalQty > min) Then
            Console.WriteLine("Maximum Quantity Reached")
        ElseIf TotalQty < min Then
            Console.WriteLine("Minimum Quantity is not Reached")
        End If

        Console.ReadKey()


    End Sub

End Module
