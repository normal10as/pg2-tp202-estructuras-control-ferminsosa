Module ejercicio211
    Sub Main()
        Dim a As Int16
        Dim par As Int16
        Dim impar As Int16
        Console.WriteLine("Ingrese un numero: ")
        a = Console.ReadLine()
        Do While a <> 0
            Console.WriteLine("Ingrese un numero: ")
            a = Console.ReadLine()
            If a Mod 2 = 0 And a <> 0 Then
                par += 1
            Else
                impar += 1
            End If

        Loop
        If par <> 0 And impar <> 0 Then
            Console.WriteLine("Ingreso " & par & " numeros pares")
            Console.WriteLine("Ingreso " & impar & " numeros impares")
        ElseIf par = 0 And impar <> 0 Then
            Console.WriteLine("Todos los numeros ingresados fueron impares, y se ingreso " & impar & " numeros")
        ElseIf par <> 0 And impar = 0 Then
            Console.WriteLine("Todos los numeros ingresados fueron pares, y se ingreso " & par & " numeros")
        End If

    End Sub
End Module
