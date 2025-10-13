Module Lab10_2
    ' Comentarios estilo estudiante: funciones y subrutinas en VB.NET
    Function Sumar(a As Integer, b As Integer) As Integer
        Return a + b
    End Function

    Sub Main()
        Console.WriteLine("Lab 10-2: Función Sumar")
        Dim x As Integer = 7
        Dim y As Integer = 5
        Console.WriteLine($"{x} + {y} = {Sumar(x,y)}")
        Console.WriteLine("Fin del Lab 10-2. Presiona una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module