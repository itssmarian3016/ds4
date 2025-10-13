Module Lab10_3
    ' Comentarios estilo estudiante: Select Case y manejo de excepciones
    Sub Main()
        Console.WriteLine("Lab 10-3: Select Case y Try/Catch")
        Console.Write("Ingresa un número del 1 al 3: ")
        Dim s = Console.ReadLine()
        Dim n As Integer
        If Integer.TryParse(s, n) Then
            Select Case n
                Case 1
                    Console.WriteLine("Elegiste 1")
                Case 2
                    Console.WriteLine("Elegiste 2")
                Case 3
                    Console.WriteLine("Elegiste 3")
                Case Else
                    Console.WriteLine("Fuera de rango")
            End Select
        Else
            Console.WriteLine("No es un número válido")
        End If

        Try
            Dim a As Integer = 10
            Dim b As Integer = 0
            Dim c = a / b ' esto provoca excepción
            Console.WriteLine(c)
        Catch ex As Exception
            Console.WriteLine("Capturada excepción: " & ex.Message)
        End Try

        Console.WriteLine("Fin del Lab 10-3. Presiona una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module