using System;
using System.Collections.Generic;

namespace Laboratorio55
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Estudiante>()
            {
                new Estudiante { Nombre = "María", Edad = 19 },
                new Estudiante { Nombre = "Carlos", Edad = 20 },
                new Estudiante { Nombre = "Ana", Edad = 18 }
            };

            foreach (var est in lista)
            {
                Console.WriteLine($"Nombre: {est.Nombre}, Edad: {est.Edad}"); 
            }
        }
    }
}
