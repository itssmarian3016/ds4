using System;

namespace Laboratorio47
{
    class Program
    {
        static void Saludo(string nombre = "Invitado")
        {
            Console.WriteLine($"Hola, {nombre}!");
        }

        static void Main(string[] args)
        {
            Saludo();
            Saludo("María");
        }
    }
}