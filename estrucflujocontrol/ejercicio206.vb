Imports Microsoft.VisualBasic
Imports System


Module ejercicio206
    Sub Main()
        Dim a As Int16
        Dim b As Decimal
        Dim total As Decimal
        Dim descuento As Decimal

        Do


            Console.WriteLine("Ingrese la cantidad: ")
            a = Console.ReadLine()
            Console.WriteLine("Ingrese el precio unitario: ")
            b = Console.ReadLine()

            Select Case a
                Case 10 To 50
                    total = a * b
                    descuento = total * 0.05

                    Console.WriteLine("El subtotal es: " & total)
                    Console.WriteLine("El 5% de descuento es: " & descuento)
                    Console.WriteLine("El total es: " & total - descuento)
                    Console.WriteLine(" ")
                Case 51 To 250
                    total = a * b
                    descuento = total * 0.1
                    Console.WriteLine("El subtotal es: " & total)
                    Console.WriteLine("El 10% de descuento es: " & descuento)
                    Console.WriteLine("El total es: " & total - descuento)
                    Console.WriteLine(" ")
                Case Is >= 251
                    total = a * b
                    descuento = total * 0.2
                    Console.WriteLine("El subtotal es: " & total)
                    Console.WriteLine("El 20% de descuento es: " & descuento)
                    Console.WriteLine("El total es: " & total - descuento)
                    Console.WriteLine(" ")
                Case Is <= 0
                    Console.WriteLine("Hasta luego")
                    Console.WriteLine(" ")
                Case Else
                    total = a * b

                    Console.WriteLine("El subtotal es: " & total)
                    Console.WriteLine("No posee descuento")
                    Console.WriteLine("El total es: " & total)
                    Console.WriteLine(" ")

            End Select

        Loop While a <= 0

    End Sub
End Module
