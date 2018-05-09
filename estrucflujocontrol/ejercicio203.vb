Imports Microsoft.VisualBasic
Imports System



Module ejercicio203
    Sub Main()
        Dim a As Int16
        Dim b As Int16
        Dim c As Int16
        For index As Int16 = 1 To 5
            Console.WriteLine("Ingrese un numero: ")
            a = Console.ReadLine()
            If a > b Then
                b = a
                c = index
            End If
        Next
        Console.WriteLine("El numero ingresado en la posicion " & c & " es el mayor. ")
    End Sub
End Module
