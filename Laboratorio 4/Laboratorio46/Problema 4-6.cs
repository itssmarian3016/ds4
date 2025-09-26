using System;

namespace Laboratorio46
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            Console.Write("Ingrese el radio de un círculo: ");
            double r = double.Parse(Console.ReadLine());
            double area = PI * r * r;
            Console.WriteLine($"Área del círculo: {area:F2}");
        }
    }
}