Imports Microsoft.VisualBasic
Imports System


Module ejercicio209
    Sub Main()
        Dim a As Int16

        Console.WriteLine("Ingrese la opcion deseada.")
        Console.WriteLine("")
        Console.WriteLine("Para convertir metros ingrese       1 .")
        Console.WriteLine("Para convertir centimetros ingrese  2 .")
        Console.WriteLine("Para convertir pies ingrese         3 .")
        Console.WriteLine("Para convertir yardas ingrese       4 .")
        Console.WriteLine("Para convertir pulgadas ingrese     5 .")
        a = Console.ReadLine()
        Dim metros As Single
        Dim centi As Single
        Dim pies As Single
        Dim yardas As Single
        Dim pulgadas As Single

        Select Case a
            Case 1
                Console.WriteLine("Ingrese los metros a convertir")
                metros = Console.ReadLine()
                centi = metros * 100
                pulgadas = centi / 2.54
                pies = pulgadas / 12
                yardas = pies / 3
                Console.WriteLine(metros & " metros son " & centi & " centimetros.")
                Console.WriteLine(metros & " metros son " & pies & " pies.")
                Console.WriteLine(metros & " metros son " & yardas & " yardas.")
                Console.WriteLine(metros & " metros son " & pulgadas & " pulgadas.")
                Console.WriteLine(" ")
            Case 2
                Console.WriteLine("Ingrese los centimetros a convertir")
                centi = Console.ReadLine()
                metros = centi * 0.01
                pulgadas = centi / 2.54
                pies = pulgadas / 12
                yardas = pies / 3
                Console.WriteLine(centi & " centimetros son " & metros & " metros.")
                Console.WriteLine(centi & " centimetros son " & pies & " pies.")
                Console.WriteLine(centi & " centimetros son " & yardas & " yardas.")
                Console.WriteLine(centi & " centimetros son " & pulgadas & " pulgadas.")
                Console.WriteLine(" ")
            Case 3
                Console.WriteLine("Ingrese los pies a convertir")
                pies = Console.ReadLine()
                pulgadas = pies * 12
                centi = pulgadas * 2.54
                metros = centi / 100

                yardas = pies / 3
                Console.WriteLine(pies & " pies son " & centi & " centimetros.")
                Console.WriteLine(pies & " metros son " & metros & " metros.")
                Console.WriteLine(pies & " metros son " & yardas & " yardas.")
                Console.WriteLine(pies & " metros son " & pulgadas & " pulgadas.")
                Console.WriteLine(" ")
            Case 4
            Case 5
            Case Else
                Console.WriteLine("del 1 al 5")
        End Select



    End Sub
End Module
