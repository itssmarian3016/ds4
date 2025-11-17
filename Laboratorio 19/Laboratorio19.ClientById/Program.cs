using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Laboratorio19.ClientById
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var url = "https://localhost:44360/api/values/2";
                    Console.WriteLine("Calling: " + url);
                    var resp = await client.GetStringAsync(url);
                    Console.WriteLine("Response:");
                    Console.WriteLine(resp);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error calling API: " + ex.Message);
                }
            }
        }
    }
}
