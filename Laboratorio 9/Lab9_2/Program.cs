using System;

namespace Laboratorio9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar números del 1 al 100 que sean pares o divisibles entre 3
            Console.WriteLine("Lab 9-2: Números pares o divisibles entre 3 (1..100)");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Fin del Lab 9-2. Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}