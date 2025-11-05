using System;
using Microsoft.Owin.Hosting;

namespace Laboratorio152
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string url = "http://localhost:9000";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine($"Servidor ejecutándose en {url}...");
                Console.ReadLine();
            }
        }
    }
}
