using System;

namespace Laboratorio63
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader reader = null;
            try
            {
                reader = new System.IO.StreamReader(new System.IO.StringReader("línea de prueba"));
                Console.WriteLine(reader.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
            finally
            {
                if (reader != null) reader.Dispose();
                Console.WriteLine("Bloque finally ejecutado."); 
            }
        }
    }
}
