using System;

namespace Laboratorio62
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese índice de arreglo (0-2): ");
                int idx = int.Parse(Console.ReadLine());
                int[] arr = { 10, 20, 30 };
                Console.WriteLine(arr[idx]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: índice fuera de rango."); 
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: formato inválido."); 
            }
        }
    }
}
