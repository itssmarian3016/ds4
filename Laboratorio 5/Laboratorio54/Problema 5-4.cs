using System;

namespace Laboratorio54
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = { 4.0, 3.5, 5.0, 4.5, 3.8 };
            double suma = 0;
            foreach (double n in notas) suma += n;
            double promedio = notas.Length > 0 ? suma / notas.Length : 0;
            Console.WriteLine($"Promedio de calificaciones: {promedio:F2}");
        }
    }
}
