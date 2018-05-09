Imports Microsoft.VisualBasic
Imports System

Module ejercicio201
    Sub Main()

        Dim a As Int16
        Dim b As Int16
        Console.WriteLine("Ingrese un valor")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese un valor")
        b = Console.ReadLine()

        If a > b Then
            Console.WriteLine("El Numero " & a & " es mayor")
        ElseIf (a < b) Then
            Console.WriteLine("El Numero " & b & " es mayor")
        Else
            Console.WriteLine("Los numeros son iguales")
        End If

    End Sub

End Module

