Imports System

Module Program
    Sub Main()


        Dim pesomuestra As Integer
        Dim RB As Single
        Dim VT As Single

        Console.Write(" INGRESE PESO MUESTRA :")
        pesomuestra = Console.ReadLine()
        Console.Write("INGRESE RB :")
        RB = Console.ReadLine()
        VT = pesomuestra * RB
        Console.Write(" EL VOLUMEN TOTAL ES :")
        Console.Write(VT)
        Console.ReadKey()


    End Sub
End Module
