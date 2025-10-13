using System;

namespace Laboratorio8_1
{
    class Persona
    {
        public string Nombre { get; private set; }
        public int Edad { get; private set; }
        public string NIF { get; private set; }

        public Persona(string nombre, int edad, string nif)
        {
            Nombre = nombre;
            Edad = edad;
            NIF = nif;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}, NIF: {NIF}");
        }
    }

    class Trabajador : Persona
    {
        public int Sueldo { get; set; }

        public Trabajador(string nombre, int edad, string nif, int sueldo)
            : base(nombre, edad, nif)
        {
            Sueldo = sueldo;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Sueldo: {Sueldo}");
        }
    }

    class Program
    {
        static void Main()
        {
            Persona p = new Persona("Ana", 21, "A1234567");
            Trabajador t = new Trabajador("Carlos", 30, "B7654321", 1200);

            p.Mostrar();
            Console.WriteLine("---");
            t.Mostrar();

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}