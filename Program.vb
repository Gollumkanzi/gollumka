Imports System

Module Program
    Sub Main(args As String())
        Dim ph As Integer
        Console.WriteLine("Cual es el valor de ph? ")

        ph = Console.ReadLine()

        If ph < 7 Then
            Console.WriteLine(" es acido !!!!!")

        End If

        If ph > 7 Then
            Console.WriteLine(" es alcalino !!!!!")

        End If

        If ph < 3 Then
            Console.WriteLine(" A�ADIR DOS TASAS DE NaHCO3 !!!!!")

        End If
        If ph > 3 And ph < 7 Then

            Console.WriteLine(" A�ADIR 1 TASA NaHCO3 !!!!!")

        End If
        If ph > 7 And ph < 10 Then
            Console.WriteLine(" A�ADIR 50 ML NaSO4 !!!!!")

        End If
        If ph > 10 And ph < 14 Then
            Console.WriteLine(" A�ADIR 100 ML NaSO4 !!!!!")

        End If


        If ph = 7 Then

            Console.WriteLine(" es NEUTRO !!!!!")

        End If
        If ph > 14 Then
            Console.WriteLine(" FUERA DE RANGO !!!!!")

        End If
        If ph < 0 Then
            Console.WriteLine(" FUERA DE RANGO  !!!!!")

        End If

        Console.WriteLine(" SUERTE !")
    End Sub
End Module
