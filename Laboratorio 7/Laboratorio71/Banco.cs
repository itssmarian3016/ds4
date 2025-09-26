using System;

namespace Laboratorio71
{
    class Program
    {
        static void Main(string[] args)
        {
            var banco = new Banco();
            banco.Clientes.Add(new Cliente("Juan", 100m));
            banco.Clientes.Add(new Cliente("Ana", 50m));
            banco.Clientes.Add(new Cliente("Luis", 200m));

            banco.Clientes[0].Depositar(50m);
            banco.Clientes[1].Retirar(20m);

            Console.WriteLine("Saldos por cliente:");
            foreach (var c in banco.Clientes)
            {
                Console.WriteLine($"{c.Nombre}: {c.Saldo:C2}");
            }

            Console.WriteLine($"Total depositado en el banco: {banco.TotalDeposado():C2}");
        }
    }
}
