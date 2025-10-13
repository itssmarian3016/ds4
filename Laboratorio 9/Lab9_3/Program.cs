using System;

namespace Laboratorio9_3
{
    class Program
    {
        static bool EsTriangulo(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        static void Main(string[] args)
        {
            // Entrada de 3 lados y clasificación del triángulo
            Console.WriteLine("Lab 9-3: Clasificación de triángulos");
            double[] lados = new double[3];
            for (int i = 0; i < 3; i++)
            {
                double val = -1;
                while (val <= 0)
                {
                    Console.Write($"Ingresa el lado #{i+1} (positivo): ");
                    if (!double.TryParse(Console.ReadLine(), out val) || val <= 0)
                    {
                        Console.WriteLine("Valor inválido. Intenta de nuevo.");
                        val = -1;
                    }
                }
                lados[i] = val;
            }

            if (!EsTriangulo(lados[0], lados[1], lados[2]))
            {
                Console.WriteLine("No se puede formar un triángulo con esos lados.");
            }
            else
            {
                // Clasificar
                if (lados[0] == lados[1] && lados[1] == lados[2])
                    Console.WriteLine("Triángulo equilátero.");
                else if (lados[0] == lados[1] || lados[0] == lados[2] || lados[1] == lados[2])
                    Console.WriteLine("Triángulo isósceles.");
                else
                    Console.WriteLine("Triángulo escaleno.");
            }

            Console.WriteLine("Fin del Lab 9-3. Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}