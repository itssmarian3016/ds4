using System;

namespace Laboratorio51
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sueldos = new double[5];
            sueldos[0] = 250.50;
            sueldos[1] = 300.00;
            sueldos[2] = 280.75;
            sueldos[3] = 310.00;
            sueldos[4] = 295.20;

            Console.WriteLine("Sueldos de los 5 operarios:");
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine($"Operario {i+1}: {sueldos[i]:C2}");
            }
        }
    }
}
