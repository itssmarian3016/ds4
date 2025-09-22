using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            // Variables de instancia de clase
            client.FirstName = "María";
            client.LastName = "González";
            client.age = 20;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());

        }
    }

    public class Client
    {
        // Declarando variables de instancia en clase
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string age { get; set; }

        public string GetFullName());
        {
            // Utilizando variables de instancia dentro de metodo clase
            return FirstName + " " + LastName;
        }
            
        
    }
}