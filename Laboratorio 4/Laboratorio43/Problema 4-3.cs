using System;

namespace Laboratorio43
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Menú simple:");
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                    Console.WriteLine("¡Hola!");
            } while (opcion != 2);
        }
    }
}