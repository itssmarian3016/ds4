using System;

namespace Laboratorio72
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int d1 = rnd.Next(1,7);
            int d2 = rnd.Next(1,7);
            int d3 = rnd.Next(1,7);

            Console.WriteLine($"Dados: {d1}, {d2}, {d3}");
            if (d1 == d2 && d2 == d3)
                Console.WriteLine("¡Gano! Los tres dados iguales.");
            else
                Console.WriteLine("Perdió.");
        }
    }
}
