Module ejercicio305
    Private Const pi As Decimal = 3.14159265
    Sub main()
        Dim base As Single
        Dim h As Single
        Console.WriteLine("Ingrese Base en cm ")
        base = Console.ReadLine()
        Console.WriteLine("Ingrese Altura en cm ")
        h = Console.ReadLine()
        Console.WriteLine("El volumne del cilindro es = " & calculo(base, h) & " cm")
    End Sub
    Private Function calculo(ByRef r As Decimal, ByRef h As Decimal) As Decimal
        Dim datoA As Byte = 1
        Dim datoV As Decimal
        While (datoA = 1)
            If r >= 0 And h >= 0 Then
                datoV = Math.Pow(r, 2) * pi * h
                datoA = 0
            Else
                If r <= 0 And h <= 0 Then
                    Console.WriteLine("Usar valores positivos")
                ElseIf h <= 0 Then
                    Console.WriteLine("Usar Valores Positivos para la Altura")
                Else
                    Console.WriteLine("Usar valores positivos para la Base")
                End If
                Console.WriteLine("Ingrese Base en cm ")
                r = Console.ReadLine()
                Console.WriteLine("Ingrese Altura en cm")
                h = Console.ReadLine()
                datoA = 1
            End If
        End While
        Return datoV
    End Function
End Module
