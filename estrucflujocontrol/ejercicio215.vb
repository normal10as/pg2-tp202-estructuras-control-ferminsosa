'ingrese el capital inicial, la cantidad de meses
'MES: es el número de mes.
'CAPITAL: en el primer mes es el capital inicial y en los meses siguientes es el saldo
'acumulado anterior. Por ejemplo, en el mes 1, el capital es el ingresado, para el mes 2, deberá
'tener incrementado el interés que ganó en el mes 1, y así sucesivamente.
'INTERES: es el capital por la tasa mensual de interés (tasa anual / 12), osea es el valor que
'gana en el mes correspondiente.
'SALDO: es el el capital sumado el interés.
'TOTAL INTERES GANADO: es la sumatoria de los intereses mensuales.

Imports Microsoft.VisualBasic
Imports System


Module ejercicio215
    Sub Main()
        Dim capital As Decimal
        Dim mes As Byte
        Dim interes As Decimal
        Dim saldo As Decimal
        Dim totalInteres As Decimal

        Console.WriteLine("Ingrese el capital inicial")
        capital = Console.ReadLine()
        Console.WriteLine("Ingrese el numero de meses")
        mes = Console.ReadLine()

        Console.WriteLine("MES |CAPITAL |INTERES |SALDO  ")
        For index = 1 To mes
            interes = Math.Round(capital * 0.03, 3)
            saldo = Math.Round(capital + interes, 3)
            Console.WriteLine(index & " |" & capital & " |" & interes & " |" & saldo)
            capital = saldo

            totalInteres += interes

        Next
        Console.WriteLine("Total de Intereses Ganado: " & totalInteres)

    End Sub
End Module
