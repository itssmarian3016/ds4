using System;

namespace Laboratorio32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Problema 2: Área del círculo ===");

            double radio = LeerDouble("Ingrese el radio: ");
            double area = Geometria.CalculoArea(radio);

            Console.WriteLine($"\nÁrea del círculo con radio {radio} = {area}");
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