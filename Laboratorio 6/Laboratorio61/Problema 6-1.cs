using System;

namespace Laboratorio61
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese el numerador: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el denominador: ");
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine($"Resultado: {c}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: división por cero."); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: formato de número inválido."); 
            }
        }
    }
}
