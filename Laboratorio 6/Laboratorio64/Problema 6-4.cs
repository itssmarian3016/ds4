using System;

namespace Laboratorio64
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message) { }
    }

    class Program
    {
        static void CheckAge(int age)
        {
            if (age < 0 || age > 120)
                throw new InvalidAgeException("Edad inválida: " + age);
        }

        static void Main(string[] args)
        {
            try
            {
                CheckAge(-5);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Capturada excepción personalizada: " + ex.Message);
            }
        }
    }
}
