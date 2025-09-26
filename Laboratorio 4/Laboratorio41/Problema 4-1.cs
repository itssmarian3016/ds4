using System;

namespace Laboratorio41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número entero n: ");
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}