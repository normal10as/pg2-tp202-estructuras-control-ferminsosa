
Module ejercicio305
    Private Const pi As Decimal = 3.14159265
    Sub main()
        Dim base As Single
        Dim h As Single
        Console.WriteLine("Ingrese Base R en centimetros ")
        base = Console.ReadLine()
        Console.WriteLine("Ingrese Altura H en centimetros ")
        h = Console.ReadLine()
        Console.WriteLine("El volumne del cilindro es =" & calculo(base, h) & " en centimetros")
    End Sub
    Private Function calculo(ByRef r As Decimal, ByRef h As Decimal) As Decimal
        Dim a As Byte = 1
        Dim v As Decimal
        While (a = 1)
            If r >= 0 And h >= 0 Then
                v = Math.Pow(r, 2) * pi * h
                a = 0
            Else
                If r <= 0 And h <= 0 Then
                    Console.WriteLine("Ningun valor corresponde a positivos")
                ElseIf h <= 0 Then
                    Console.WriteLine("La altura H es negativa")
                Else
                    Console.WriteLine("La Base R es negativa")
                End If
                Console.WriteLine("Ingrese Base R en centimetros ")
                r = Console.ReadLine()
                Console.WriteLine("Ingrese Altura H en centimetros ")
                h = Console.ReadLine()
                a = 1
            End If
        End While
        Return v
    End Function
End Module