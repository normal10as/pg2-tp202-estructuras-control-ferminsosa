Imports Microsoft.VisualBasic
Imports System


Module ejercicio202
    Sub Main()
        Dim a As Int16
        Dim b As Int16

        For index As Int16 = 1 To 3
            Console.WriteLine("Ingrese un numero: ")
            a = Console.ReadLine()
            If a > b Then
                b = a
            End If
        Next
        Console.WriteLine("El numero mayor es " & b)
    End Sub
End Module