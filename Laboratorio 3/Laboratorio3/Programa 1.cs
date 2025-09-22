using System;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Problema 1: (a+b)*(a-b) ===");

            double a = LeerDouble("Ingrese el valor de a: ");
            double b = LeerDouble("Ingrese el valor de b: ");

            double resultado = CalculosMatematicos.Calcular(a, b);

            Console.WriteLine($"\nResultado: (a+b)*(a-b) = {resultado}");
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }

        static double LeerDouble(string mensaje)
        {
            double valor;
            while (true)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out valor))
                    return valor;
                Console.WriteLine("Entrada inválida, intente de nuevo.");
            }
        }
    }
}