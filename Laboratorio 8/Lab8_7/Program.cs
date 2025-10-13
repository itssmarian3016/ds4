using System;

namespace Laboratorio8_7
{
    sealed class ClaseFinal
    {
        public void Saludo() => Console.WriteLine("Soy una clase final (sealed).");
    }

    class Program
    {
        static void Main()
        {
            var c = new ClaseFinal();
            c.Saludo();
            Console.ReadKey();
        }
    }
}