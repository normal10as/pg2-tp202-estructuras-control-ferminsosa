
Module ejercicio304
    Sub main()
        Dim lA As Decimal
        Dim lB As Decimal
        Dim res As Int16
        Console.WriteLine("Ingrese lado A")
        lA = Console.ReadLine()
        Console.WriteLine("Ingrese lado B")
        lB = Console.ReadLine()
        lA = Math.Floor(lA)
        lB = Math.Floor(lA)
        res = validar(lA, lB)
        Console.WriteLine("La hipotenusa es =" & res)
    End Sub
    Private Function validar(ByRef ValA As Int16, ByRef ValB As Int16) As Int16
        Dim a As Int16 = 1
        Dim h As Int16
        While (a = 1)
            If ValA > 0 And ValB > 0 Then
                h = Math.Sqrt(Math.Pow(ValA, 2) + Math.Pow(ValB, 2))
                a = 0
            Else
                If ValA <= 0 And ValB <= 0 Then
                    Console.WriteLine("Ningun valor corresponde a un entero positivo")
                ElseIf ValB <= 0 Then
                    Console.WriteLine("El valor B no es entero positivo")
                Else
                    Console.WriteLine("El valor A no es entero positivo")
                End If
                Console.WriteLine("Ingrese lado A")
                ValA = Console.ReadLine()
                Console.WriteLine("Ingrese lado B")
                ValB = Console.ReadLine()
                a = 1
            End If
        End While
        Return h
    End Function
End Module