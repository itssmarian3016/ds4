using System;

namespace Laboratorio8_5
{
    public partial class PersonaPartial
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    public partial class PersonaPartial
    {
        public void Mostrar()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    class Program
    {
        static void Main()
        {
            var p = new PersonaPartial { Nombre = "Lucía", Edad = 19 };
            p.Mostrar();
            Console.ReadKey();
        }
    }
}