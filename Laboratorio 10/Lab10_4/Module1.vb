Module Lab10_4
    ' Comentarios estilo estudiante: programa principal que usa una clase simple
    Class Persona
        Public Property Nombre As String
        Public Property Edad As Integer

        Public Sub New(n As String, e As Integer)
            Nombre = n
            Edad = e
        End Sub

        Public Sub Mostrar()
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}")
        End Sub
    End Class

    Sub Main()
        Console.WriteLine("Lab 10-4: Uso de clase Persona en VB.NET")
        Dim p As New Persona("María", 20)
        p.Mostrar()
        Console.WriteLine("Fin del Lab 10-4. Presiona una tecla para salir...")
        Console.ReadKey()
    End Sub
End Module