using System;
using System.Collections.Generic;

namespace Laboratorio9_5
{
    // Uso de la clase Aleatorios para generar arreglo sin repetidos
    class Aleatorios
    {
        private Random rnd;
        public Aleatorios() { rnd = new Random(); }

        public int GenerarNumeroEntre(int min, int max)
        {
            if (min > max) (min, max) = (max, min);
            return rnd.Next(min, max + 1);
        }

        // Genera arreglo de tamaño 'tamaño' con números NO repetidos entre min y max
        public int[] GenerarArregloNoRepetido(int tamaño, int min, int max)
        {
            if (min > max) (min, max) = (max, min);
            int rango = max - min + 1;
            if (tamaño > rango) throw new ArgumentException("Tamaño mayor que la cantidad de valores únicos disponibles.");

            // Crear lista con todos los valores del rango y barajar
            List<int> pool = new List<int>();
            for (int v = min; v <= max; v++) pool.Add(v);

            // Fisher–Yates shuffle parcial para obtener 'tamaño' elementos aleatorios
            for (int i = 0; i < tamaño; i++)
            {
                int j = rnd.Next(i, pool.Count);
                int tmp = pool[i];
                pool[i] = pool[j];
                pool[j] = tmp;
            }

            int[] resultado = new int[tamaño];
            for (int i = 0; i < tamaño; i++) resultado[i] = pool[i];
            return resultado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 9-5: Arreglo no repetido usando Aleatorios");
            var a = new Aleatorios();

            int min = a.GenerarNumeroEntre(1, 5);
            int max = a.GenerarNumeroEntre(6, 15);
            if (min > max) (min, max) = (max, min);

            Console.WriteLine($"Rango elegido aleatoriamente: {min} .. {max}");

            int tamaño = Math.Min(5, max - min + 1); // ejemplo: pedir 5 números o lo máximo disponible
            var arr = a.GenerarArregloNoRepetido(tamaño, min, max);

            Console.WriteLine("Arreglo no repetido: " + string.Join(", ", arr));
            Console.WriteLine("Fin del Lab 9-5. Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}