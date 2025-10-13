using System;

namespace Laboratorio8_9
{
    interface IVolador
    {
        void Volar();
        int AlturaMaxima { get; }
    }

    class Avion : IVolador
    {
        public int AlturaMaxima => 12000;
        public void Volar() => Console.WriteLine("El avión vuela a gran altura.");
    }

    class Superman : IVolador
    {
        public int AlturaMaxima => int.MaxValue;
        public void Volar() => Console.WriteLine("¡Superman vuela por los cielos!");
    }

    class Program
    {
        static void Main()
        {
            IVolador[] voladores = { new Avion(), new Superman() };
            foreach (var v in voladores)
            {
                v.Volar();
                Console.WriteLine($"Altura máxima: {v.AlturaMaxima}");
            }
            Console.ReadKey();
        }
    }
}