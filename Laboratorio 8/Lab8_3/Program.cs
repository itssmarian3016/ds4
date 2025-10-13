using System;

namespace Laboratorio8_3
{
    class Program
    {
        static int Suma(int a, int b) => a + b;
        static double Suma(double a, double b) => a + b;
        static int Suma(int a, int b, int c) => a + b + c;

        static void Main()
        {
            Console.WriteLine(Suma(2, 3));
            Console.WriteLine(Suma(2.5, 3.1));
            Console.WriteLine(Suma(1, 2, 3));
            Console.ReadKey();
        }
    }
}