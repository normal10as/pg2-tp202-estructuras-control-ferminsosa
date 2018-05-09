Imports Microsoft.VisualBasic
Imports System



Module ejercicio205
    Sub Main()
        Dim mes As Int16
        Console.WriteLine("Ingrese un numero de mes (0 para salir) ")
        mes = Console.ReadLine()
        While mes > 0

            Select Case mes
                Case 1
                    Console.WriteLine("El mes ingresado es Enero")
                Case 2
                    Console.WriteLine("El mes ingresado es Febrero")
                Case 3
                    Console.WriteLine("El mes ingresado es Marzo")
                Case 4
                    Console.WriteLine("El mes ingresado es Abril")
                Case 5
                    Console.WriteLine("El mes ingresado es Mayo")
                Case 6
                    Console.WriteLine("El mes ingresado es Junio")
                Case 7
                    Console.WriteLine("El mes ingresado es Julio")
                Case 8
                    Console.WriteLine("El mes ingresado es Agosto")
                Case 9
                    Console.WriteLine("El mes ingresado es Septiembre")
                Case 10
                    Console.WriteLine("El mes ingresado es Octubre")
                Case 11
                    Console.WriteLine("El mes ingresado es Noviembre")
                Case 12
                    Console.WriteLine("El mes ingresado es Diciembre")
                Case Else
                    Console.WriteLine("El mes ingresado no es correcto")

            End Select
            Console.WriteLine("Ingrese otro numero (0 para salir")
            mes = Console.ReadLine()
        End While

    End Sub
End Module
