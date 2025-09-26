namespace Laboratorio71
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public decimal Saldo { get; private set; }

        public Cliente(string nombre, decimal saldoInicial)
        {
            Nombre = nombre;
            Saldo = saldoInicial;
        }

        public void Depositar(decimal monto) { Saldo += monto; }
        public bool Retirar(decimal monto)
        {
            if (monto <= Saldo) { Saldo -= monto; return true; }
            return false;
        }
    }
}
