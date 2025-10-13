using System;

namespace Laboratorio9_4
{
    // Clase Aleatorios con Random como atributo y métodos solicitados
    class Aleatorios
    {
        private Random rnd;

        public Aleatorios()
        {
            rnd = new Random();
        }

        // Generar un número entre min y max (inclusive)
        public int GenerarNumeroEntre(int min, int max)
        {
            if (min > max) (min, max) = (max, min);
            return rnd.Next(min, max + 1);
        }

        // Generar un arreglo de 'tamaño' con números aleatorios entre min y max (puede repetirse)
        public int[] GenerarArregloAleatorio(int tamaño, int min, int max)
        {
            if (tamaño < 0) throw new ArgumentException("Tamaño no puede ser negativo");
            int[] arr = new int[tamaño];
            for (int i = 0; i < tamaño; i++)
                arr[i] = GenerarNumeroEntre(min, max);
            return arr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso simple de la clase Aleatorios
            Console.WriteLine("Lab 9-4: Clase Aleatorios");
            var a = new Aleatorios();
            Console.WriteLine("Número aleatorio entre 10 y 20: " + a.GenerarNumeroEntre(10,20));

            var arr = a.GenerarArregloAleatorio(8, 1, 10);
            Console.WriteLine("Arreglo aleatorio (puede repetir): " + string.Join(", ", arr));

            Console.WriteLine("Fin del Lab 9-4. Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}