using System;
using System.Collections.Generic;

namespace Laboratorio56
{
    class Program
    {
        static void Main(string[] args)
        {
            var capitals = new Dictionary<string, string>()
            {
                { "Panama", "Ciudad de Panamá" },
                { "Costa Rica", "San José" },
                { "Colombia", "Bogotá" }
            };

            foreach (var kvp in capitals)
            {
                Console.WriteLine($"País: {kvp.Key} - Capital: {kvp.Value}"); 
            }
        }
    }
}
