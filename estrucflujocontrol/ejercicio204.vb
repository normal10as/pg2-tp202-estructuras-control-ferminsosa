Imports Microsoft.VisualBasic
Imports System



Module ejercicio204
    Sub Main()
        Dim a As Int16
        Dim b As Decimal
        Dim total As Decimal
        Dim descuento As Decimal

        Console.WriteLine("Ingrese la cantidad: ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese el precio unitario: ")
        b = Console.ReadLine()


        If (a >= 10 And a <= 50) Then
            total = a * b
            descuento = total * 0.05

            Console.WriteLine("El subtotal es: " & total)
            Console.WriteLine("El 5% de descuento es: " & descuento)
            Console.WriteLine("El total es: " & total - descuento)
        ElseIf (a >= 51 And a <= 250) Then
            total = a * b
            descuento = total * 0.1
            Console.WriteLine("El subtotal es: " & total)
            Console.WriteLine("El 10% de descuento es: " & descuento)
            Console.WriteLine("El total es: " & total - descuento)
        ElseIf (a >= 251) Then
            total = a * b
            descuento = total * 0.2
            Console.WriteLine("El subtotal es: " & total)
            Console.WriteLine("El 20% de descuento es: " & descuento)
            Console.WriteLine("El total es: " & total - descuento)
        Else
            total = a * b

            Console.WriteLine("El subtotal es: " & total)
            Console.WriteLine("No posee descuento")
            Console.WriteLine("El total es: " & total)
        End If
    End Sub
End Module
