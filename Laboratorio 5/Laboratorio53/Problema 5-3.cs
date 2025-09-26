using System;

namespace Laboratorio53
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {1, 2, 3, 4, 5};
            Console.WriteLine("Recorriendo arreglo con foreach:");
            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
        }
    }
}
