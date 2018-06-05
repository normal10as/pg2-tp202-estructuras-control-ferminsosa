Module ejercicio212
    Sub Main()
        Dim a As UInt16
        Dim b As UInt16 = 1
        Dim c As UInt16
        For f = 0 To 19
            c = a + b
            a = b
            b = c
            Console.WriteLine(c)
        Next

    End Sub

End Module
