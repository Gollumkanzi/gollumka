Imports System

Module Program
    Sub Main()
        Dim opcion As Integer

        ' Mostrar el menú hasta que el usuario elija la opción 5
        Do
            Console.WriteLine("Menú:")
            Console.WriteLine("1. Opción 1")
            Console.WriteLine("2. Opción 2")
            Console.WriteLine("3. Opción 3")
            Console.WriteLine("4. Opción 4")
            Console.WriteLine("5. Salir")

            ' Leer la opción del usuario
            Console.Write("Elige una opción (1-5): ")
            opcion = Integer.Parse(Console.ReadLine())

            ' Realizar acciones según la opción elegida
            Select Case opcion
                Case 1
                    Console.WriteLine(" Valentino Rossi (Urbino, Italia; 16 de febrero de 1979) es un expiloto de motociclismo y piloto de automovilismo italiano que compite en el Campeonato Mundial de Resistencia de la FIA en 2024. Ha ganado nueve títulos del Campeonato del Mundo de Motociclismo en cuatro categorías: 125cc (1997), 250cc (1999), 500cc (2001) y ha sido hexacampeón de MotoGP (2002, 2003, 2004, 2005, 2008 y 2009). Ha participado en la máxima categoría, con los tres grandes equipos de motociclismo de su momento: Honda, Yamaha y Ducati, siendo desde 2013 y hasta 2020 piloto oficial Yamaha. En 2021 vistió los colores del Petronas Yamaha SRT.1​

Es el piloto con más podios (235) en la historia del Mundial de Motociclismo, y además ha conseguido el mayor número de victorias (89), podios (199) y vueltas rápidas (76) en MotoGP. Es el único piloto en la historia del motociclismo que ha ganado el título en cuatro clases diferentes: 125cc (1), 250cc (1), 500cc (1) y MotoGP (6), además de ser el único piloto que ha ganado el título de la categoría reina en cuatro tipos diferentes de motocicletas, debido al cambio de reglamento en los años: Honda de 500 cc de 2 tiempos, Honda de 990 cc de 4 tiempos, Yamaha de 990 cc de 4 tiempos, Yamaha de 800 cc de 4 tiempos. 1.")
                ' Agrega aquí las acciones para la Opción 1
                Case 2
                    Console.WriteLine("Marc Márquez Alentà (Cervera, Lérida, 17 de febrero de 1993) es un piloto de motociclismo español que compite en MotoGP.2​ Ha ganado ocho títulos del Campeonato del Mundo de Motociclismo en tres categorías diferentes: 125cc (2010), Moto2 (2012) y seis veces en MotoGP (2013, 2014, 2016, 2017, 2018 y 2019).3​ Desde 2013 hasta 2023 fue piloto del equipo Repsol Honda, acumulando 59 victorias y 101 podios en más de 150 carreras disputadas.4​ En 2024 forma parte del Gresini Racing junto a su hermano Álex Márquez.

En su primera temporada en la categoría, se hizo con el Campeonato del Mundo de Motociclismo, convirtiéndose en el piloto más joven en ganar un campeonato de la máxima categoría de este deporte (MotoGP), superando así el récord de Freddie Spencer. Es, además, el piloto más joven de la historia en ser bi, tri, tetra, penta y hexa campeón de la categoría reina del motociclismo.

Tiene un hermano tres años menor, Álex Márquez (n. 1996), que compite también en la categoría de MotoGP y ha obtenido dos títulos del Campeonato del Mundo de Motociclismo. Marc y Álex son los únicos hermanos que han conseguido un Campeonato del Mundo de Motociclismo y además en la misma temporada (en 2014 y en 2019), junto con haber sido los primeros hermanos en vencer en un Gran Premio en el mismo día (el 15 de junio de 2014 en el Gran Premio de Cataluña de Motociclismo, en el circuito de Montmeló, España) y los que más veces han coincidido en el podio de un Gran Premio 2.")
                ' Agrega aquí las acciones para la Opción 2
                Case 3
                    Console.WriteLine("Marco Bezzecchi (Rimini, Italia; 12 de noviembre de 1998) es un piloto de motociclismo italiano. Fue tercero del Campeonato del Mundo de Motociclismo de Moto3 en 2018 y de Moto2 en 2021. Desde la temporada 2022 compite en la categoría reina de MotoGP con el equipo Pertamina Enduro VR46 Racing Team, resultando tercero en la temporada 2023. 3.")
                ' Agrega aquí las acciones para la Opción 3
                Case 4
                    Console.WriteLine("Aleix Espargaró Villà es un piloto de motociclismo español. Compite en el campeonato del mundo de motociclismo de MotoGP en el Aprilia Racing Factory Team, resultando cuarto en 2022 como mejor resultado. Se proclamó campeón de España de 125 cc en 2004 y del campeonato mundial de CRT en 2012. 4.")
                ' Agrega aquí las acciones para la Opción 4
                Case 5
                    Console.WriteLine("Fabio Quartararo es un piloto francés de motociclismo. Compite en el equipo Monster Energy Yamaha en el Campeonato del Mundo de Motociclismo de MotoGP. Antes de su entrada en la categoría reina, ganó seis títulos del Campeonato de España de Velocidad incluyendo dos títulos de Moto3 Junior en 2013 y 2014.")
                    ' Salir del bucle
            End Select
        Loop While opcion <> 5

    End Sub
End Module
