Module Module1

    Sub FindMinMax(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal e As Integer, ByRef MIN As Integer, ByRef MAX As Integer)

        If a > b And a > c And a > d And a > e Then
            MAX = a
        ElseIf b > c And b > d And b > e Then
            MAX = b
        ElseIf c > d And c > e Then
            MAX = c
        ElseIf d > e Then
            MAX = d
        Else
            MAX = e
        End If

        If a < b And a < c And a < d And a < e Then
            MIN = a
        ElseIf b < c And b < d And b < e Then
            MIN = b
        ElseIf c < d And c < e Then
            MIN = c
        ElseIf d < e Then
            MIN = d
        Else
            MIN = e
        End If
    End Sub

    Sub Main()

        Dim min, max As Integer

        FindMinMax(10, 2, 30, 4, 5, min, max)

        Console.WriteLine("Minimum Value is {0}", min)
        Console.WriteLine("Maximum Value is {0}", max)

        Console.ReadKey()

    End Sub

End Module
