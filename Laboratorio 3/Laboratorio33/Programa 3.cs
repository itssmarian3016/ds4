using System;

namespace Laboratorio33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Problema 3: Perímetro del rectángulo ===");

            double ladoA = LeerDouble("Ingrese el lado A: ");
            double ladoB = LeerDouble("Ingrese el lado B: ");

            double perimetro = Rectangulo.CalcularPerimetro(ladoA, ladoB);

            Console.WriteLine($"\nPerímetro = {perimetro}");
            Console.ReadKey();
        }

        static double LeerDouble(string mensaje)
        {
            double valor;
            while (true)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out valor) && valor >= 0)
                    return valor;
                Console.WriteLine("Entrada inválida.");
            }
        }
    }
}