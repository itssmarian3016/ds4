using System;

namespace Laboratorio8_4
{
    class Producto
    {
        private decimal precio;
        public string Nombre { get; set; }

        public decimal Precio
        {
            get => precio;
            set
            {
                if (value < 0) throw new ArgumentException("El precio no puede ser negativo.");
                precio = value;
            }
        }

        public Producto(string nombre, decimal precioInicial)
        {
            Nombre = nombre;
            Precio = precioInicial;
        }

        public void Mostrar() => Console.WriteLine($"Producto: {Nombre}, Precio: {Precio:C}");
    }

    class Program
    {
        static void Main()
        {
            var p = new Producto("Cuaderno", 3.50m);
            p.Mostrar();
            Console.ReadKey();
        }
    }
}