'Obtener los números primos menores a mil. En matemáticas, un número primo es un
'número natural mayor que 1 que tiene únicamente dos divisores distintos: él mismo y el 1


Module ejercicio213
    Sub Main()
        Dim x As Int16
        Dim b As Byte

        Do While x <= 1000
            x += 1
            b = 0
            For index = 1 To x
                If x Mod index = 0 Then
                    b += 1

                End If

            Next
            If b = 2 Then
                Console.WriteLine(x)

            End If
        Loop

    End Sub
End Module
