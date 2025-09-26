using System;

namespace Laboratorio52
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,4];

            Console.WriteLine("Ingrese 12 enteros para la matriz 3x4 (fila por fila):");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    string line = Console.ReadLine();
                    if (!int.TryParse(line, out matriz[i,j]))
                    {
                        matriz[i,j] = 0;
                    }
                }
            }

            Console.WriteLine("Contenido de la matriz:"); 
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
