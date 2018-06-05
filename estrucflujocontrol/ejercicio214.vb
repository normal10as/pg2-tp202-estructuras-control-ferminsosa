'Se ingresan repetitivamente dos valores relativos a un producto en venta: cantidad y
'precio unitario. Si la cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es
'entre 51 y 250 el descuento es del 10% y si es 251 o más el descuento es del 20%. Informar por
'cada producto subtotal (cantidad por precio unitario), porcentaje de descuento aplicado, monto
'descontado y el total (subtotal – monto descontado). Al finalizar el ingreso, por cantidad igual a
'cero, informar el total de pesos descontados y el total a cobrar.



Module ejercicio214
    Sub Main()
        Dim a As Int16
        Dim b As Decimal

        Dim subtotal As Decimal
        Dim descuento As Decimal
        Dim total As Decimal
        Dim sumatotal As Decimal
        Dim sumadescuento As Decimal
        Console.WriteLine("Ingrese la cantidad (0 para terminar): ")
        a = Console.ReadLine()


        While a <> 0
            Console.WriteLine("Ingrese el precio unitario: ")
            b = Console.ReadLine()

            Select Case a
                Case 10 To 50
                    subtotal = a * b
                    descuento = subtotal * 0.05
                    total = subtotal - descuento
                    Console.WriteLine("El subtotal es: " & subtotal)
                    Console.WriteLine("El 5% de descuento es: " & descuento)
                    Console.WriteLine("El total es: " & total)
                    Console.WriteLine(" ")
                Case 51 To 250
                    subtotal = a * b
                    descuento = subtotal * 0.1
                    total = subtotal - descuento
                    Console.WriteLine("El subtotal es: " & subtotal)
                    Console.WriteLine("El 10% de descuento es: " & descuento)
                    Console.WriteLine("El total es: " & total)
                    Console.WriteLine(" ")
                Case Is >= 251
                    subtotal = a * b
                    descuento = subtotal * 0.2
                    total = subtotal - descuento
                    Console.WriteLine("El subtotal es: " & subtotal)
                    Console.WriteLine("El 20% de descuento es: " & descuento)
                    Console.WriteLine("El total es: " & total)
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

            sumadescuento += descuento
            sumatotal += total
            Console.WriteLine("Ingrese la cantidad (0 para terminar): ")
            a = Console.ReadLine()

        End While

        Console.WriteLine("El descuento total es: " & sumadescuento)
        Console.WriteLine("El total a cobrar es: " & sumatotal)
        Console.WriteLine(" ")
    End Sub
End Module
