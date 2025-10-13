using System;

namespace Laboratorio9_1
{
    class Program
    {
        static bool EsNumero16Digitos(string s)
        {
            return s.Length == 16 && long.TryParse(s, out _);
        }

        static void Main(string[] args)
        {
            // Comentarios estilo estudiante: validar precio y forma de pago
            Console.WriteLine("Lab 9-1: Precio y forma de pago");
            decimal precio = -1;
            while (precio <= 0)
            {
                Console.Write("Ingresa el precio del producto (positivo): ");
                if (!decimal.TryParse(Console.ReadLine(), out precio) || precio <= 0)
                {
                    Console.WriteLine("Valor inválido. Intenta de nuevo.");
                    precio = -1;
                }
            }

            string forma = "";
            while (forma != "EFECTIVO" && forma != "TARJETA")
            {
                Console.Write("Forma de pago (efectivo/tarjeta): ");
                forma = Console.ReadLine().Trim().ToUpper();
                if (forma != "EFECTIVO" && forma != "TARJETA")
                    Console.WriteLine("Opción no válida. Escribe 'efectivo' o 'tarjeta'.");
            }

            if (forma == "TARJETA")
            {
                string cuenta = "";
                while (!EsNumero16Digitos(cuenta))
                {
                    Console.Write("Ingresa el número de cuenta (16 dígitos): ");
                    cuenta = Console.ReadLine().Trim();
                    if (!EsNumero16Digitos(cuenta))
                        Console.WriteLine("Número inválido. Debe tener exactamente 16 dígitos numéricos.");
                }
                Console.WriteLine($"Pago por tarjeta registrado. Cuenta: {cuenta}");
            }
            else
            {
                Console.WriteLine("Pago en efectivo seleccionado.");
            }

            Console.WriteLine($"Precio final: {precio:C}");
            Console.WriteLine("Fin del Lab 9-1. Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}