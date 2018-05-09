Imports Microsoft.VisualBasic
Imports System

Module ejercicio207
    Sub Main()
        Dim angulo As Int16
        Console.WriteLine("Ingrese un angulo")
        angulo = Console.ReadLine()
        Select Case angulo
            Case Is < 90
                Console.WriteLine("Angulo Agudo")
            Case Is = 90
                Console.WriteLine("Angulo Recto")
            Case 91 To 179
                Console.WriteLine("Angulo Obtuso")
            Case Is = 180
                Console.WriteLine("Angulo LLano")
            Case 181 To 359
                Console.WriteLine("Angulo Cóncavo")
            Case Else
                Console.WriteLine("Error angulo incorrecto")
        End Select

    End Sub
End Module
