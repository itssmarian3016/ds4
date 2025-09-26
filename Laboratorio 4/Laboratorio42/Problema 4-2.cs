using System;

namespace Laboratorio42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero para calcular su factorial: ");
            int n = int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"El factorial de {n} es {fact}");
        }
    }
}