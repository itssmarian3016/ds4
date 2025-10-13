using System;

namespace Laboratorio8_8
{
    abstract class Animal
    {
        public string Nombre { get; set; }
        public Animal(string nombre) { Nombre = nombre; }
        public abstract void HacerSonido();
        public virtual void Mostrar() => Console.WriteLine($"Animal: {Nombre}");
    }

    class Perro : Animal
    {
        public Perro(string nombre) : base(nombre) { }
        public override void HacerSonido() => Console.WriteLine("Guau guau");
    }

    class Gato : Animal
    {
        public Gato(string nombre) : base(nombre) { }
        public override void HacerSonido() => Console.WriteLine("Miau");
    }

    class Program
    {
        static void Main()
        {
            Animal[] animales = { new Perro("Rex"), new Gato("Mishu") };
            foreach (var a in animales)
            {
                a.Mostrar();
                a.HacerSonido();
            }
            Console.ReadKey();
        }
    }
}