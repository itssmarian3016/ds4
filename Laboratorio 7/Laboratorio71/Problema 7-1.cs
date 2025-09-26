using System.Collections.Generic;

namespace Laboratorio71
{
    public class Banco
    {
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();

        public decimal TotalDeposado()
        {
            decimal total = 0;
            foreach (var c in Clientes) total += c.Saldo;
            return total;
        }
    }
}
